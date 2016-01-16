﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            Properties.Settings.Default.Reset();
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
