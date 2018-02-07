using System;
using System.Windows.Forms;

namespace MinerManager
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            LoadSettings();
        }

        void LoadSettings()
        {
            //Generic Settings
            textBox_MinerPath.Text      = Properties.Settings.Default["MinerPath"].ToString();
            textBox_CCMinerName.Text    = Properties.Settings.Default["CCMinerName"].ToString();
            textBox_MinerName.Text      = Properties.Settings.Default["MinerName"].ToString();
            textBox_CatalystName.Text   = Properties.Settings.Default["CatalystName"].ToString();
            textBox_MaxTemp.Text        = Properties.Settings.Default["MaxTemp"].ToString();

            //Preferred Settings
            textBox_Pool.Text                   = Properties.Settings.Default["PreferredPool"].ToString();
            textBox_Wallet.Text                 = Properties.Settings.Default["WalletAddress"].ToString();
            comboBox_Algorithm.Text             = Properties.Settings.Default["PreferredAlgorithmIndex"].ToString();
            checkBox_LookupGap.Checked          = Convert.ToBoolean(Properties.Settings.Default["PreferLookupGap"]);
            checkBox_DefaultComplete.Checked    = Convert.ToBoolean(Properties.Settings.Default["PreferToSelfMine"]);
        }

        private void button_SaveChanges_Click(object sender, EventArgs e)
        {
            //Generic Settings
            Properties.Settings.Default["MinerPath"] = textBox_MinerPath.Text;
            Properties.Settings.Default["CCMinerName"] = textBox_CCMinerName.Text;
            Properties.Settings.Default["MinerName"] = textBox_MinerName.Text;
            Properties.Settings.Default["CatalystName"] = textBox_CatalystName.Text;
            Properties.Settings.Default["MaxTemp"] = textBox_MaxTemp.Text;

            //Preferred Settings
            Properties.Settings.Default["PreferredPool"] = textBox_Pool.Text;
            Properties.Settings.Default["WalletAddress"] = textBox_Wallet.Text;
            Properties.Settings.Default["PreferredAlgorithmIndex"] = comboBox_Algorithm.Text;
            Properties.Settings.Default["PreferLookupGap"] = checkBox_LookupGap.Checked;
            Properties.Settings.Default["PreferToSelfMine"] = checkBox_DefaultComplete.Checked;

            Properties.Settings.Default.Save();
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
