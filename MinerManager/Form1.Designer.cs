namespace MinerManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView_Queue = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Pool = new System.Windows.Forms.TextBox();
            this.textBox_Wallet = new System.Windows.Forms.TextBox();
            this.button_AddToQueue = new System.Windows.Forms.Button();
            this.checkBox_UseLookupGap = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Hours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Minutes = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Seconds = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_CurrentJob_Seconds = new System.Windows.Forms.TextBox();
            this.button_StartJob = new System.Windows.Forms.Button();
            this.button_PauseJob = new System.Windows.Forms.Button();
            this.button_SkipJob = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_CurrentJob_Minutes = new System.Windows.Forms.TextBox();
            this.textBox_CurrentJob_Pool = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_CurrentJob_Wallet = new System.Windows.Forms.TextBox();
            this.textBox_CurrentJob_Hours = new System.Windows.Forms.TextBox();
            this.checkBox_CurrentJob_LookupGap = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_MoveDown = new System.Windows.Forms.Button();
            this.button_MoveUp = new System.Windows.Forms.Button();
            this.comboBox_Algorithm = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_CurrentJob_Algorithm = new System.Windows.Forms.ComboBox();
            this.Pool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiningDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Algorithm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsingLookupGap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Queue)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Queue
            // 
            this.dataGridView_Queue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Queue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pool,
            this.Wallet,
            this.MiningDuration,
            this.Algorithm,
            this.UsingLookupGap});
            this.dataGridView_Queue.Location = new System.Drawing.Point(15, 25);
            this.dataGridView_Queue.MultiSelect = false;
            this.dataGridView_Queue.Name = "dataGridView_Queue";
            this.dataGridView_Queue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Queue.Size = new System.Drawing.Size(473, 381);
            this.dataGridView_Queue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target Pool";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target Wallet";
            // 
            // textBox_Pool
            // 
            this.textBox_Pool.Location = new System.Drawing.Point(3, 33);
            this.textBox_Pool.Name = "textBox_Pool";
            this.textBox_Pool.Size = new System.Drawing.Size(481, 20);
            this.textBox_Pool.TabIndex = 4;
            // 
            // textBox_Wallet
            // 
            this.textBox_Wallet.Location = new System.Drawing.Point(3, 72);
            this.textBox_Wallet.Name = "textBox_Wallet";
            this.textBox_Wallet.Size = new System.Drawing.Size(481, 20);
            this.textBox_Wallet.TabIndex = 5;
            // 
            // button_AddToQueue
            // 
            this.button_AddToQueue.Location = new System.Drawing.Point(313, 107);
            this.button_AddToQueue.Name = "button_AddToQueue";
            this.button_AddToQueue.Size = new System.Drawing.Size(162, 75);
            this.button_AddToQueue.TabIndex = 6;
            this.button_AddToQueue.Text = "Add to Queue";
            this.button_AddToQueue.UseVisualStyleBackColor = true;
            this.button_AddToQueue.Click += new System.EventHandler(this.button_AddToQueue_Click);
            // 
            // checkBox_UseLookupGap
            // 
            this.checkBox_UseLookupGap.AutoSize = true;
            this.checkBox_UseLookupGap.Location = new System.Drawing.Point(123, 168);
            this.checkBox_UseLookupGap.Name = "checkBox_UseLookupGap";
            this.checkBox_UseLookupGap.Size = new System.Drawing.Size(107, 17);
            this.checkBox_UseLookupGap.TabIndex = 10;
            this.checkBox_UseLookupGap.Text = "Use Lookup Gap";
            this.checkBox_UseLookupGap.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Time To Mine";
            // 
            // textBox_Hours
            // 
            this.textBox_Hours.Location = new System.Drawing.Point(35, 114);
            this.textBox_Hours.Name = "textBox_Hours";
            this.textBox_Hours.Size = new System.Drawing.Size(81, 20);
            this.textBox_Hours.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "HH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "MM";
            // 
            // textBox_Minutes
            // 
            this.textBox_Minutes.Location = new System.Drawing.Point(35, 139);
            this.textBox_Minutes.Name = "textBox_Minutes";
            this.textBox_Minutes.Size = new System.Drawing.Size(81, 20);
            this.textBox_Minutes.TabIndex = 18;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Garlic Miner";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem_Exit.Text = "Exit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBox_Algorithm);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox_Seconds);
            this.groupBox1.Controls.Add(this.button_AddToQueue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Minutes);
            this.groupBox1.Controls.Add(this.textBox_Pool);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_Wallet);
            this.groupBox1.Controls.Add(this.textBox_Hours);
            this.groupBox1.Controls.Add(this.checkBox_UseLookupGap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(576, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 194);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add To Queue";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "SS";
            // 
            // textBox_Seconds
            // 
            this.textBox_Seconds.Location = new System.Drawing.Point(35, 165);
            this.textBox_Seconds.Name = "textBox_Seconds";
            this.textBox_Seconds.Size = new System.Drawing.Size(81, 20);
            this.textBox_Seconds.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboBox_CurrentJob_Algorithm);
            this.groupBox2.Controls.Add(this.textBox_CurrentJob_Seconds);
            this.groupBox2.Controls.Add(this.button_StartJob);
            this.groupBox2.Controls.Add(this.button_PauseJob);
            this.groupBox2.Controls.Add(this.button_SkipJob);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_CurrentJob_Minutes);
            this.groupBox2.Controls.Add(this.textBox_CurrentJob_Pool);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox_CurrentJob_Wallet);
            this.groupBox2.Controls.Add(this.textBox_CurrentJob_Hours);
            this.groupBox2.Controls.Add(this.checkBox_CurrentJob_LookupGap);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(579, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 194);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Job";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "SS";
            // 
            // textBox_CurrentJob_Seconds
            // 
            this.textBox_CurrentJob_Seconds.Enabled = false;
            this.textBox_CurrentJob_Seconds.Location = new System.Drawing.Point(32, 165);
            this.textBox_CurrentJob_Seconds.Name = "textBox_CurrentJob_Seconds";
            this.textBox_CurrentJob_Seconds.Size = new System.Drawing.Size(81, 20);
            this.textBox_CurrentJob_Seconds.TabIndex = 22;
            // 
            // button_StartJob
            // 
            this.button_StartJob.Location = new System.Drawing.Point(239, 107);
            this.button_StartJob.Name = "button_StartJob";
            this.button_StartJob.Size = new System.Drawing.Size(75, 75);
            this.button_StartJob.TabIndex = 21;
            this.button_StartJob.Text = "Start";
            this.button_StartJob.UseVisualStyleBackColor = true;
            this.button_StartJob.Click += new System.EventHandler(this.button_StartJob_Click);
            // 
            // button_PauseJob
            // 
            this.button_PauseJob.Location = new System.Drawing.Point(320, 107);
            this.button_PauseJob.Name = "button_PauseJob";
            this.button_PauseJob.Size = new System.Drawing.Size(75, 75);
            this.button_PauseJob.TabIndex = 20;
            this.button_PauseJob.Text = "Stop";
            this.button_PauseJob.UseVisualStyleBackColor = true;
            this.button_PauseJob.Click += new System.EventHandler(this.button_PauseJob_Click);
            // 
            // button_SkipJob
            // 
            this.button_SkipJob.Location = new System.Drawing.Point(401, 107);
            this.button_SkipJob.Name = "button_SkipJob";
            this.button_SkipJob.Size = new System.Drawing.Size(75, 75);
            this.button_SkipJob.TabIndex = 6;
            this.button_SkipJob.Text = "Skip";
            this.button_SkipJob.UseVisualStyleBackColor = true;
            this.button_SkipJob.Click += new System.EventHandler(this.button_SkipJob_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Target Pool";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "MM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Target Wallet";
            // 
            // textBox_CurrentJob_Minutes
            // 
            this.textBox_CurrentJob_Minutes.Enabled = false;
            this.textBox_CurrentJob_Minutes.Location = new System.Drawing.Point(32, 139);
            this.textBox_CurrentJob_Minutes.Name = "textBox_CurrentJob_Minutes";
            this.textBox_CurrentJob_Minutes.Size = new System.Drawing.Size(81, 20);
            this.textBox_CurrentJob_Minutes.TabIndex = 18;
            // 
            // textBox_CurrentJob_Pool
            // 
            this.textBox_CurrentJob_Pool.Enabled = false;
            this.textBox_CurrentJob_Pool.Location = new System.Drawing.Point(3, 33);
            this.textBox_CurrentJob_Pool.Name = "textBox_CurrentJob_Pool";
            this.textBox_CurrentJob_Pool.Size = new System.Drawing.Size(481, 20);
            this.textBox_CurrentJob_Pool.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "HH";
            // 
            // textBox_CurrentJob_Wallet
            // 
            this.textBox_CurrentJob_Wallet.Enabled = false;
            this.textBox_CurrentJob_Wallet.Location = new System.Drawing.Point(3, 72);
            this.textBox_CurrentJob_Wallet.Name = "textBox_CurrentJob_Wallet";
            this.textBox_CurrentJob_Wallet.Size = new System.Drawing.Size(481, 20);
            this.textBox_CurrentJob_Wallet.TabIndex = 5;
            // 
            // textBox_CurrentJob_Hours
            // 
            this.textBox_CurrentJob_Hours.Enabled = false;
            this.textBox_CurrentJob_Hours.Location = new System.Drawing.Point(32, 114);
            this.textBox_CurrentJob_Hours.Name = "textBox_CurrentJob_Hours";
            this.textBox_CurrentJob_Hours.Size = new System.Drawing.Size(81, 20);
            this.textBox_CurrentJob_Hours.TabIndex = 16;
            // 
            // checkBox_CurrentJob_LookupGap
            // 
            this.checkBox_CurrentJob_LookupGap.AutoSize = true;
            this.checkBox_CurrentJob_LookupGap.Enabled = false;
            this.checkBox_CurrentJob_LookupGap.Location = new System.Drawing.Point(120, 167);
            this.checkBox_CurrentJob_LookupGap.Name = "checkBox_CurrentJob_LookupGap";
            this.checkBox_CurrentJob_LookupGap.Size = new System.Drawing.Size(115, 17);
            this.checkBox_CurrentJob_LookupGap.TabIndex = 10;
            this.checkBox_CurrentJob_LookupGap.Text = "Using Lookup Gap";
            this.checkBox_CurrentJob_LookupGap.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Time Left";
            // 
            // button_Start
            // 
            this.button_Start.BackgroundImage = global::MinerManager.Properties.Resources.Checkmark;
            this.button_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Start.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Start.Location = new System.Drawing.Point(494, 177);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(70, 70);
            this.button_Start.TabIndex = 23;
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.BackgroundImage = global::MinerManager.Properties.Resources.X_Symbol;
            this.button_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Remove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Remove.Location = new System.Drawing.Point(494, 253);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(70, 70);
            this.button_Remove.TabIndex = 13;
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_MoveDown
            // 
            this.button_MoveDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_MoveDown.BackgroundImage")));
            this.button_MoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_MoveDown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_MoveDown.Location = new System.Drawing.Point(494, 101);
            this.button_MoveDown.Name = "button_MoveDown";
            this.button_MoveDown.Size = new System.Drawing.Size(70, 70);
            this.button_MoveDown.TabIndex = 12;
            this.button_MoveDown.UseVisualStyleBackColor = true;
            this.button_MoveDown.Click += new System.EventHandler(this.button_MoveDown_Click);
            // 
            // button_MoveUp
            // 
            this.button_MoveUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_MoveUp.BackgroundImage")));
            this.button_MoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_MoveUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_MoveUp.Location = new System.Drawing.Point(494, 25);
            this.button_MoveUp.Name = "button_MoveUp";
            this.button_MoveUp.Size = new System.Drawing.Size(70, 70);
            this.button_MoveUp.TabIndex = 11;
            this.button_MoveUp.UseVisualStyleBackColor = true;
            this.button_MoveUp.Click += new System.EventHandler(this.button_MoveUp_Click);
            // 
            // comboBox_Algorithm
            // 
            this.comboBox_Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Algorithm.FormattingEnabled = true;
            this.comboBox_Algorithm.Items.AddRange(new object[] {
            "scrypt:10",
            "heavy",
            "mjollnir",
            "fugue256",
            "groestl",
            "myr-gr",
            "jackpot",
            "quark",
            "anime",
            "nist5",
            "x11"});
            this.comboBox_Algorithm.Location = new System.Drawing.Point(122, 139);
            this.comboBox_Algorithm.Name = "comboBox_Algorithm";
            this.comboBox_Algorithm.Size = new System.Drawing.Size(116, 21);
            this.comboBox_Algorithm.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(123, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Algorithm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(120, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Algorithm";
            // 
            // comboBox_CurrentJob_Algorithm
            // 
            this.comboBox_CurrentJob_Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CurrentJob_Algorithm.Enabled = false;
            this.comboBox_CurrentJob_Algorithm.FormattingEnabled = true;
            this.comboBox_CurrentJob_Algorithm.Items.AddRange(new object[] {
            "scrypt:10",
            "heavy",
            "mjollnir",
            "fugue256",
            "groestl",
            "myr-gr",
            "jackpot",
            "quark",
            "anime",
            "nist5",
            "x11"});
            this.comboBox_CurrentJob_Algorithm.Location = new System.Drawing.Point(119, 139);
            this.comboBox_CurrentJob_Algorithm.Name = "comboBox_CurrentJob_Algorithm";
            this.comboBox_CurrentJob_Algorithm.Size = new System.Drawing.Size(114, 21);
            this.comboBox_CurrentJob_Algorithm.TabIndex = 24;
            // 
            // Pool
            // 
            this.Pool.HeaderText = "Pool";
            this.Pool.Name = "Pool";
            this.Pool.ReadOnly = true;
            // 
            // Wallet
            // 
            this.Wallet.HeaderText = "Wallet";
            this.Wallet.Name = "Wallet";
            this.Wallet.ReadOnly = true;
            // 
            // MiningDuration
            // 
            this.MiningDuration.HeaderText = "Mining Duration";
            this.MiningDuration.Name = "MiningDuration";
            this.MiningDuration.ReadOnly = true;
            // 
            // Algorithm
            // 
            this.Algorithm.HeaderText = "Algorithm";
            this.Algorithm.Name = "Algorithm";
            // 
            // UsingLookupGap
            // 
            this.UsingLookupGap.HeaderText = "Using Lookup Gap";
            this.UsingLookupGap.Name = "UsingLookupGap";
            this.UsingLookupGap.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 420);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_MoveDown);
            this.Controls.Add(this.button_MoveUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Queue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Miner Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Queue)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Queue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Pool;
        private System.Windows.Forms.TextBox textBox_Wallet;
        private System.Windows.Forms.Button button_AddToQueue;
        private System.Windows.Forms.CheckBox checkBox_UseLookupGap;
        private System.Windows.Forms.Button button_MoveUp;
        private System.Windows.Forms.Button button_MoveDown;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Hours;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Minutes;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_CurrentJob_Seconds;
        private System.Windows.Forms.Button button_StartJob;
        private System.Windows.Forms.Button button_PauseJob;
        private System.Windows.Forms.Button button_SkipJob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_CurrentJob_Minutes;
        private System.Windows.Forms.TextBox textBox_CurrentJob_Pool;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_CurrentJob_Wallet;
        private System.Windows.Forms.TextBox textBox_CurrentJob_Hours;
        private System.Windows.Forms.CheckBox checkBox_CurrentJob_LookupGap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Seconds;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.ComboBox comboBox_Algorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pool;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiningDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Algorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsingLookupGap;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_CurrentJob_Algorithm;
    }
}

