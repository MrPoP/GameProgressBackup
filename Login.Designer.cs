
namespace GameProgressBackup
{
    partial class Login
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
            this.loadingCircle1 = new MRG.Controls.UI.LoadingCircle();
            this.loginpnl = new System.Windows.Forms.Panel();
            this.loginbtn = new System.Windows.Forms.Button();
            this.psw = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.statuslbl = new System.Windows.Forms.Label();
            this.loginpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadingCircle1
            // 
            this.loadingCircle1.Active = true;
            this.loadingCircle1.Color = System.Drawing.Color.DarkGray;
            this.loadingCircle1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadingCircle1.InnerCircleRadius = 5;
            this.loadingCircle1.Location = new System.Drawing.Point(0, 91);
            this.loadingCircle1.Name = "loadingCircle1";
            this.loadingCircle1.NumberSpoke = 12;
            this.loadingCircle1.OuterCircleRadius = 11;
            this.loadingCircle1.RotationSpeed = 100;
            this.loadingCircle1.Size = new System.Drawing.Size(237, 29);
            this.loadingCircle1.SpokeThickness = 2;
            this.loadingCircle1.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.loadingCircle1.TabIndex = 0;
            this.loadingCircle1.Text = "loadingCircle1";
            this.loadingCircle1.UseWaitCursor = true;
            // 
            // loginpnl
            // 
            this.loginpnl.Controls.Add(this.statuslbl);
            this.loginpnl.Controls.Add(this.loginbtn);
            this.loginpnl.Controls.Add(this.psw);
            this.loginpnl.Controls.Add(this.email);
            this.loginpnl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginpnl.Enabled = false;
            this.loginpnl.Location = new System.Drawing.Point(12, 3);
            this.loginpnl.Name = "loginpnl";
            this.loginpnl.Size = new System.Drawing.Size(213, 117);
            this.loginpnl.TabIndex = 1;
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(53, 85);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(107, 23);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "&Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // psw
            // 
            this.psw.Location = new System.Drawing.Point(19, 60);
            this.psw.MaxLength = 16;
            this.psw.Name = "psw";
            this.psw.PasswordChar = '*';
            this.psw.Size = new System.Drawing.Size(178, 20);
            this.psw.TabIndex = 1;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(19, 34);
            this.email.MaxLength = 32;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(178, 20);
            this.email.TabIndex = 0;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.Location = new System.Drawing.Point(75, 7);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(63, 23);
            this.statuslbl.TabIndex = 3;
            this.statuslbl.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(237, 120);
            this.Controls.Add(this.loadingCircle1);
            this.Controls.Add(this.loginpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(253, 154);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(253, 154);
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.loginpnl.ResumeLayout(false);
            this.loginpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MRG.Controls.UI.LoadingCircle loadingCircle1;
        private System.Windows.Forms.Panel loginpnl;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox psw;
        private System.Windows.Forms.Label statuslbl;
    }
}