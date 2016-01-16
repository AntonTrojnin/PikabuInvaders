using System;
using System.Windows.Forms;

namespace PikabuInvaders
{
    public partial class chooseForm : Form
    {
        public chooseForm()
        {
            InitializeComponent();
        }

        private void goodForceButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.userSide = "good";
            showMainForm();
        }

        private void forceEvilButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.userSide = "evil";
            showMainForm();
        }

        private void showMainForm()
        {
            Properties.Settings.Default.Save();
            mainForm form = new mainForm();
            this.Hide();
            form.Show();
        }
    }
}
