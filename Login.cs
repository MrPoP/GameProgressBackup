using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameProgressBackup.API;

namespace GameProgressBackup
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            loadingCircle1.Visible = false;
            loginpnl.Enabled = true;
        }
        public async void LoginOutfrm(string mail, string pssw)
        {
            var result = await Program.APIClient.Login(mail.Decrypt(), pssw.Decrypt());
            if (result == false)
            {
                statuslbl.Text = "Failed";
                statuslbl.ForeColor = Color.Red;
                loadingCircle1.Visible = false;
                loginpnl.Enabled = true;
            }
            else
            {
                statuslbl.Text = "Success";
                statuslbl.ForeColor = Color.Green;
                Close();
            }
        }
        private async void loginbtn_Click(object sender, EventArgs e)
        {
            var result = await Program.APIClient.Login(email.Text, psw.Text);
            if(result == false)
            {
                statuslbl.Text = "Failed";
                statuslbl.ForeColor = Color.Red;
                loadingCircle1.Visible = false;
                loginpnl.Enabled = true;
            }
            else
            {
                statuslbl.Text = "Success";
                statuslbl.ForeColor = Color.Green;
                Properties.Settings.Default.Email = email.Text.Encrypt();
                Properties.Settings.Default.Password = psw.Text.Encrypt();
                Close();
            }
        }
    }
}
