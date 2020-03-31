namespace Crowe_robert_SoftwareII_CSharp
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
            this.lbLoginUsername = new System.Windows.Forms.Label();
            this.lbLoginPassword = new System.Windows.Forms.Label();
            this.lbLoginWelcome = new System.Windows.Forms.Label();
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.btLoginLogin = new System.Windows.Forms.Button();
            this.btLoginClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLoginUsername
            // 
            this.lbLoginUsername.AutoSize = true;
            this.lbLoginUsername.Location = new System.Drawing.Point(61, 132);
            this.lbLoginUsername.Name = "lbLoginUsername";
            this.lbLoginUsername.Size = new System.Drawing.Size(58, 13);
            this.lbLoginUsername.TabIndex = 0;
            this.lbLoginUsername.Text = "Username:";
            // 
            // lbLoginPassword
            // 
            this.lbLoginPassword.AutoSize = true;
            this.lbLoginPassword.Location = new System.Drawing.Point(64, 182);
            this.lbLoginPassword.Name = "lbLoginPassword";
            this.lbLoginPassword.Size = new System.Drawing.Size(56, 13);
            this.lbLoginPassword.TabIndex = 1;
            this.lbLoginPassword.Text = "Password:";
            // 
            // lbLoginWelcome
            // 
            this.lbLoginWelcome.AutoSize = true;
            this.lbLoginWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginWelcome.Location = new System.Drawing.Point(64, 42);
            this.lbLoginWelcome.Name = "lbLoginWelcome";
            this.lbLoginWelcome.Size = new System.Drawing.Size(280, 31);
            this.lbLoginWelcome.TabIndex = 2;
            this.lbLoginWelcome.Text = "Please sign in below";
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.Location = new System.Drawing.Point(155, 132);
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(244, 20);
            this.tbLoginUsername.TabIndex = 3;
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(155, 175);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(244, 20);
            this.tbLoginPassword.TabIndex = 4;
            // 
            // btLoginLogin
            // 
            this.btLoginLogin.Location = new System.Drawing.Point(433, 132);
            this.btLoginLogin.Name = "btLoginLogin";
            this.btLoginLogin.Size = new System.Drawing.Size(88, 63);
            this.btLoginLogin.TabIndex = 5;
            this.btLoginLogin.Text = "Sign in";
            this.btLoginLogin.UseVisualStyleBackColor = true;
            this.btLoginLogin.Click += new System.EventHandler(this.btLoginLogin_Click);
            // 
            // btLoginClose
            // 
            this.btLoginClose.Location = new System.Drawing.Point(527, 132);
            this.btLoginClose.Name = "btLoginClose";
            this.btLoginClose.Size = new System.Drawing.Size(88, 63);
            this.btLoginClose.TabIndex = 6;
            this.btLoginClose.Text = "Close";
            this.btLoginClose.UseVisualStyleBackColor = true;
            this.btLoginClose.Click += new System.EventHandler(this.btLoginClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.btLoginClose);
            this.Controls.Add(this.btLoginLogin);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.tbLoginUsername);
            this.Controls.Add(this.lbLoginWelcome);
            this.Controls.Add(this.lbLoginPassword);
            this.Controls.Add(this.lbLoginUsername);
            this.MaximumSize = new System.Drawing.Size(650, 300);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoginUsername;
        private System.Windows.Forms.Label lbLoginPassword;
        private System.Windows.Forms.Label lbLoginWelcome;
        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.Button btLoginLogin;
        private System.Windows.Forms.Button btLoginClose;
    }
}

