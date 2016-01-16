using Microsoft.Win32;
using System.Windows.Forms;

namespace PikabuInvaders
{
    public partial class settingsForm : Form
    {
        // Ключ для регистра для автозапуска приложения вместе с Windows
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public settingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, System.EventArgs e)
        {
            hiddenStartBox.Checked = Properties.Settings.Default.hiddenStart;
            autoAttackBox.Checked = Properties.Settings.Default.autoStart;
            sendStatisticsBox.Checked = Properties.Settings.Default.sendStatistics;
            saveCredentialsBox.Checked = Properties.Settings.Default.saveCredentials;

            if (Properties.Settings.Default.userSide == "good")
            {
                userSideComboBox.SelectedIndex = 0;
            }
            else
            {
                userSideComboBox.SelectedIndex = 1;
            }

            if (rkApp.GetValue("PikabuInvaders") != null)
            {
                startupBox.Checked = true;
            }
        }

        private void startupBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (startupBox.Checked)
            {
                hiddenStartBox.Enabled = true;
                checkHiddenStartState();
            }
            else
            {
                hiddenStartBox.Enabled = false;
                rkApp.DeleteValue("PikabuInvaders", false);
            }
        }

        private void hiddenStartBox_CheckedChanged(object sender, System.EventArgs e)
        {
            checkHiddenStartState();
        }

        private void autoAttackBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.autoStart = autoAttackBox.Checked;
        }

        private void checkHiddenStartState()
        {
            if (hiddenStartBox.Checked)
            {
                rkApp.SetValue("PikabuInvaders", "\"" + Application.ExecutablePath.ToString() + "\" /background");
            }
            else
            {
                rkApp.SetValue("PikabuInvaders", Application.ExecutablePath.ToString());
            }

            Properties.Settings.Default.hiddenStart = hiddenStartBox.Checked;
        }

        private void sendDataBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.sendStatistics = sendStatisticsBox.Checked;
        }

        private void saveCredentialsBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.saveCredentials = saveCredentialsBox.Checked;
        }

        private void sideComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (userSideComboBox.SelectedIndex == 0)
            {
                Properties.Settings.Default.userSide = "good";
            }
            else
            {
                Properties.Settings.Default.userSide = "evil";
            }
        }

        private void settingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            mainForm.userSide = Properties.Settings.Default.userSide;
        }
    }
}
