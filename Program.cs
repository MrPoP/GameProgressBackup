using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProgressBackup
{
    static class Program
    {
        internal static API.Client APIClient;
        internal static Login Loginfrm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (string.IsNullOrEmpty(Properties.Settings.Default.APIKey) || string.IsNullOrEmpty(Properties.Settings.Default.APISecret))
            {
                if(MessageBox.Show("Error while launching application CODE 0x0000c.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
            APIClient = new API.Client();
            if(!string.IsNullOrEmpty(Properties.Settings.Default.Email) && !string.IsNullOrEmpty(Properties.Settings.Default.Password))
            {
                Loginfrm = new Login();
                Loginfrm.LoginOutfrm(Properties.Settings.Default.Email, Properties.Settings.Default.Password);
                Application.Run(Loginfrm);
            }
            else
            {
                //registeration form
            }
            //Application.Run(new Form1());
            Properties.Settings.Default.Save();
        }
    }
}
