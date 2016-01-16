using System;
using System.Linq;
using System.Windows.Forms;

namespace PikabuInvaders
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.firstRun)
            {
                Application.Run(new chooseForm());
            }
            else
            {
                mainForm form = new mainForm();

                if (args.Contains("/background"))
                {
                    form.ShowInTaskbar = false;
                    form.WindowState = FormWindowState.Minimized;
                }

                Application.Run(form);
            }
        }
    }
}
