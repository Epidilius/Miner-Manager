using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.Management;
using System.Runtime.InteropServices;

namespace MinerManager
{
    public partial class Form1 : Form
    {
        #region Process Handler Requirements
        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);
        [DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);
        #endregion

        static string BAT_TEXT = "ccminer-x64 --algo=scrypt:10 -o POOL -u WALLET -listen --max-temp=85";
        static string LOOKUP_GAP_TEXT = "--lookup-gap 2 ";
        static string BAT_SUFFIX = "\r\npause";

        delegate void GUIDelegate(TimeSpan timeLeft);
        delegate void JobDelegate();

        int ParentProcessID;

        DateTime TimerCompleteAt;
        DateTime PauseTime;

        System.Timers.Timer MinerTimer;
        System.Timers.Timer SecondTimer;

        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        void Setup()
        {
            var filePath = ConfigurationManager.AppSettings["MinerPath"] + ConfigurationManager.AppSettings["CatalystName"];
            if (!File.Exists(filePath))
            {
                var fileContents = "@echo off\r\nstart cmd /c " + ConfigurationManager.AppSettings["MinerPath"] + ConfigurationManager.AppSettings["MinerName"];
                using (var stream = File.Open(filePath, FileMode.OpenOrCreate))
                {
                    stream.Write(Encoding.ASCII.GetBytes(fileContents), 0, Encoding.ASCII.GetByteCount(fileContents));
                }
            }

            contextMenuStrip1.Items[0].Click += new EventHandler(CloseFromTray);

            ParentProcessID = -1;

            MinerTimer = null;
            SecondTimer = null;
        }

        //QUEUE HANDLERS
        private void button_AddToQueue_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields()) throw new ArgumentException("Empty pool or wallet");

                var targetPool = textBox_Pool.Text;
                var targetWallet = textBox_Wallet.Text;
                var minutesMining = Math.Round(TimeToMine(), 2);
                var usingLookupGap = checkBox_UseLookupGap.Checked;

                dataGridView_Queue.Rows.Add(targetPool, targetWallet, minutesMining, usingLookupGap);
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show("Check your inputs.\r\n" + argEx.Message, "Exception Caught", MessageBoxButtons.OK);
            }
        }
        private void button_MoveUp_Click(object sender, EventArgs e)
        {
            MoveQueueItem(true);
        }
        private void button_MoveDown_Click(object sender, EventArgs e)
        {
            MoveQueueItem(false);
        }
        private void button_Start_Click(object sender, EventArgs e)
        {
            StartMiner();
        }
        private void button_Remove_Click(object sender, EventArgs e)
        {

            int index = dataGridView_Queue.CurrentRow.Index;

            if (index == dataGridView_Queue.Rows.Count - 1)
                return;

            var result = MessageBox.Show("Are you sure you want to remove this mining job from the queue?", "Confirm job Removal", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dataGridView_Queue.Rows.RemoveAt(index);
            }
        }
        void MoveQueueItem(bool directionIsUp)
        {
            int currentIndex = dataGridView_Queue.CurrentRow.Index;

            if (currentIndex == dataGridView_Queue.Rows.Count - 1)
                return;
            if (currentIndex == dataGridView_Queue.Rows.Count - 2 && !directionIsUp)
                return;

            DataGridViewRow currentRow = dataGridView_Queue.CurrentRow;
            DataGridViewRow results = (DataGridViewRow)(currentRow.Clone());

            dataGridView_Queue.Rows.RemoveAt(currentIndex);

            int newIndex;

            if(directionIsUp)
                newIndex = Convert.ToInt32(((currentIndex == 0) ? 0 : currentIndex - 1));
            else
                newIndex = Convert.ToInt32(((currentIndex == 0) ? 0 : currentIndex + 1));

            for (int i = 0; i < currentRow.Cells.Count; i++)
            {
                results.Cells[i].Value = currentRow.Cells[i].Value;
            }

            dataGridView_Queue.Rows.Insert(newIndex, results);
            dataGridView_Queue.CurrentCell = dataGridView_Queue[0, newIndex];
        }
        void QueuePop()
        {
            dataGridView_Queue.Rows.RemoveAt(0);
        }

        //MINER HANDLERS
        void StartMiner()
        {
            if (!CreateScript())
                return;
            StartJobTimer(float.Parse(dataGridView_Queue.Rows[0].Cells[2].Value.ToString()));
            QueuePop();
            RunMinerScript();
        }
        bool CreateScript()
        {

            if (dataGridView_Queue.Rows.Count <= 1)
                return false;

            var filePath = ConfigurationManager.AppSettings["MinerPath"] + ConfigurationManager.AppSettings["MinerName"];
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            var pool = dataGridView_Queue.Rows[0].Cells[0].Value.ToString();
            var wallet = dataGridView_Queue.Rows[0].Cells[1].Value.ToString();
            var lookupGap = dataGridView_Queue.Rows[0].Cells[3].Value.ToString().ToLower() == "true" ? true : false;

            textBox_CurrentJob_Pool.Text = pool;
            textBox_CurrentJob_Wallet.Text = wallet;
            checkBox_CurrentJob_LookupGap.Checked = lookupGap;

            var fileContents = BAT_TEXT.Replace("POOL", pool);
            fileContents = fileContents.Replace("WALLET", wallet);
            if (lookupGap)
                fileContents += LOOKUP_GAP_TEXT;
            fileContents += BAT_SUFFIX;

            using (var stream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                stream.Write(Encoding.ASCII.GetBytes(fileContents), 0, Encoding.ASCII.GetByteCount(fileContents));
            }

            return true;
        }
        void JobDone()
        {
            DisplayTrayNotification("Job Done", "Mining done, updating mining job");
            KillAllProcessesSpawnedBy(ParentProcessID);
            StartMiner();
        }
        void RunMinerScript()
        {
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo("cmd.exe", "/c " + ConfigurationManager.AppSettings["MinerPath"] + ConfigurationManager.AppSettings["CatalystName"]);
            processInfo.WorkingDirectory = ConfigurationManager.AppSettings["MinerPath"];
            processInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = true;

            process = Process.Start(processInfo);

            ParentProcessID = process.Id;

            process.WaitForExit();
            process.Close();
        }

        //PROCESS HANDLERS
        private static List<UInt32> GetChildProcessID(int parentProcessID)
        {
            List<UInt32> matches = new List<UInt32>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE ParentProcessId=" + parentProcessID);
            ManagementObjectCollection collection = searcher.Get();
            if (collection.Count > 0)
            {
                foreach (var item in collection)
                {
                    matches.Add((UInt32)item["ProcessId"]);
                }
            }

            return matches;
        }
        private static void KillAllProcessesSpawnedBy(int parentProcessID)
        {
            var children = GetChildProcessID(parentProcessID);
           
            foreach (var childProcessId in children)
            {
                if (childProcessId != Process.GetCurrentProcess().Id)
                {
                    KillAllProcessesSpawnedBy((int)childProcessId);

                    Process childProcess = Process.GetProcessById((int)childProcessId);
                    childProcess.Kill();
                }
            }
        }
        private static void SuspendProcess(int parentProcessID)
        {
            KillAllProcessesSpawnedBy(parentProcessID);
            //ModifyProcessState(parentProcessID, false);
        }
        private void ResumeProcess(int parentProcessID)
        {
            RunMinerScript();
            //ModifyProcessState(parentProcessID, true);
        }
        static void ModifyProcessState(int parentProcessID, bool resuming)
        {
            var children = GetChildProcessID(parentProcessID);

            foreach (var childProcessId in children)
            {
                var process = Process.GetProcessById((int)childProcessId);
                if (process.ProcessName == string.Empty)
                    return;

                foreach (ProcessThread pT in process.Threads)
                {
                    IntPtr pOpenThread = OpenThread(ThreadAccess.SUSPEND_RESUME, false, (uint)pT.Id);

                    if (pOpenThread == IntPtr.Zero)
                    {
                        continue;
                    }

                    if (resuming)
                    {
                        var suspendCount = 0;
                        do
                        {
                            suspendCount = ResumeThread(pOpenThread);
                        } while (suspendCount > 0);

                        CloseHandle(pOpenThread);
                    }
                    else
                    {
                        SuspendThread(pOpenThread);
                        CloseHandle(pOpenThread);
                    }
                }
            }
        }

        //TIMER FUNCTIONS
        void StartJobTimer(float duration)
        {
            TimerCompleteAt = DateTime.Now.AddMilliseconds(duration * 60f * 1000f);
            if (duration == -1)
                TimerCompleteAt = DateTime.MinValue;

            StartMinerTimer(duration);
            StartSecondTimer();
        }
        void StartMinerTimer(float duration)
        {
            MinerTimer = new System.Timers.Timer();
            MinerTimer.Elapsed += new ElapsedEventHandler(MinerTimerTick);
            if (duration == -1) MinerTimer.Interval = int.MaxValue;
            else                MinerTimer.Interval = duration * 60f * 1000f;
            MinerTimer.Start();
        }
        void StartSecondTimer()
        {
            SecondTimer = new System.Timers.Timer();

            if (TimerCompleteAt == DateTime.MinValue)
            {
                textBox_CurrentJob_Hours.Text = "NA";
                textBox_CurrentJob_Minutes.Text = "NA";
                textBox_CurrentJob_Seconds.Text = "NA";

                return;
            }
            
            SecondTimer.Elapsed += new ElapsedEventHandler(SecondTimerTick);
            SecondTimer.Interval = 1000;
            SecondTimer.AutoReset = true;
            SecondTimer.Start();
        }
        void PauseJobTimers()
        {
            if (MinerTimer == null || SecondTimer == null)
                return;

            PauseTime = DateTime.Now;

            MinerTimer.Stop();
            SecondTimer.Stop();
        }
        void ResumeJobTimers()
        {
            if (MinerTimer == null || SecondTimer == null)
                return;

            TimerCompleteAt = TimerCompleteAt.Add(DateTime.Now.Subtract(PauseTime));
            
            MinerTimer.Start();
            SecondTimer.Start();
        }
        private void MinerTimerTick(object source, ElapsedEventArgs e)
        {
            if (textBox_CurrentJob_Hours.InvokeRequired)
            {
                JobDelegate guiDelegate = new JobDelegate(JobDone);
                Invoke(guiDelegate, new object[] {});
            }
        }
        private void SecondTimerTick(object source, ElapsedEventArgs e)
        {
            var timeLeft = TimerCompleteAt.Subtract(DateTime.Now);

            if(textBox_CurrentJob_Hours.InvokeRequired)
            {
                GUIDelegate guiDelegate = new GUIDelegate(UpdateGUI);
                Invoke(guiDelegate, new object[] { timeLeft });
            }
        }
        void UpdateGUI(TimeSpan timeLeft)
        {
            textBox_CurrentJob_Hours.Text   = timeLeft.Hours.ToString();
            textBox_CurrentJob_Minutes.Text = timeLeft.Minutes.ToString();
            textBox_CurrentJob_Seconds.Text = timeLeft.Seconds.ToString();
        }
        
        //UTIL FUNCTIONS
        bool ValidateFields()
        {
            if (String.IsNullOrWhiteSpace(textBox_Pool.Text) || String.IsNullOrWhiteSpace(textBox_Wallet.Text))
                return false;

            return true;
        }
        double TimeToMine()
        {
            float hours = GetFloatFromString(textBox_Hours.Text);
            float minutes = GetFloatFromString(textBox_Minutes.Text);
            float seconds = GetFloatFromString(textBox_Seconds.Text);
            
            if (hours == 0 && minutes == 0 && seconds == 0) return -1;

            TimeSpan hourSpan = TimeSpan.FromHours(hours);
            TimeSpan minSpan = TimeSpan.FromMinutes(minutes);
            TimeSpan secSpan = TimeSpan.FromSeconds(seconds);

            TimeSpan timeSpan = hourSpan.Add(minSpan).Add(secSpan);

            return timeSpan.TotalMinutes;
        }
        float GetFloatFromString(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
                return 0;

            try
            {
                return float.Parse(value);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Bad type", ex);
            }
        }

        //TRAY FUNCTIONS
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && FormWindowState.Normal == WindowState)
            {
                e.Cancel = true;
                MinimizeToTray();
            }
            else
            {
                if (ParentProcessID != -1)
                    KillAllProcessesSpawnedBy(ParentProcessID);
                Dispose(true);
                Application.Exit();
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
        void DisplayTrayNotification(string title, string text, int duration = 500)
        {
            if (FormWindowState.Minimized != WindowState)
                return;

            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(duration);
        }
        void MinimizeToTray()
        {
            if (FormWindowState.Normal == WindowState)
            {
                Hide();
                WindowState = FormWindowState.Minimized;
                notifyIcon1.Visible = true;
                //DisplayTrayNotification("Minimized", "Text");
            }
        }
        private void CloseFromTray(object sender, EventArgs e)
        {
            OnFormClosing(new FormClosingEventArgs(CloseReason.UserClosing, false));
        }

        //ACTIVE JOB HANDLERS
        private void button_StartJob_Click(object sender, EventArgs e)
        {
            ResumeJobTimers();
            ResumeProcess(ParentProcessID);
        }
        private void button_PauseJob_Click(object sender, EventArgs e)
        {
            PauseJobTimers();
            SuspendProcess(ParentProcessID);
        }
        private void button_SkipJob_Click(object sender, EventArgs e)
        {
            JobDone();
        }
    }
}
