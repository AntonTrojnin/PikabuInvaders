using System.Diagnostics;
using System.Windows.Forms;

namespace PikabuInvaders
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void siteLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(siteLabel.Text);
        }
    }
}
