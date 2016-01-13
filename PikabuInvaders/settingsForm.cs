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
            if (rkApp.GetValue("PikabuInvaders") != null)
            {
                startupBox.Checked = true;
            }

            if (Properties.Settings.Default.hiddenStart)
            {
                hiddenStartBox.Checked = true;
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
        }
    }
}
