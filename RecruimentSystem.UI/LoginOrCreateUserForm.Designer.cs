namespace RecruimentSystem.UI
{
    partial class LoginOrCreateUserForm
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
            this.userNameForLogin = new System.Windows.Forms.Label();
            this.passwordForLogin = new System.Windows.Forms.Label();
            this.txtUserNameLogin = new System.Windows.Forms.TextBox();
            this.txtPassForLogin = new System.Windows.Forms.TextBox();
            this.loginToUserPanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameForLogin
            // 
            this.userNameForLogin.AutoSize = true;
            this.userNameForLogin.Location = new System.Drawing.Point(64, 112);
            this.userNameForLogin.Name = "userNameForLogin";
            this.userNameForLogin.Size = new System.Drawing.Size(60, 15);
            this.userNameForLogin.TabIndex = 0;
            this.userNameForLogin.Text = "Username";
            // 
            // passwordForLogin
            // 
            this.passwordForLogin.AutoSize = true;
            this.passwordForLogin.Location = new System.Drawing.Point(64, 174);
            this.passwordForLogin.Name = "passwordForLogin";
            this.passwordForLogin.Size = new System.Drawing.Size(57, 15);
            this.passwordForLogin.TabIndex = 1;
            this.passwordForLogin.Text = "Password";
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.Location = new System.Drawing.Point(162, 109);
            this.txtUserNameLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(198, 23);
            this.txtUserNameLogin.TabIndex = 0;
            // 
            // txtPassForLogin
            // 
            this.txtPassForLogin.Location = new System.Drawing.Point(162, 171);
            this.txtPassForLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassForLogin.Name = "txtPassForLogin";
            this.txtPassForLogin.PasswordChar = '*';
            this.txtPassForLogin.Size = new System.Drawing.Size(198, 23);
            this.txtPassForLogin.TabIndex = 1;
            // 
            // loginToUserPanel
            // 
            this.loginToUserPanel.Location = new System.Drawing.Point(278, 235);
            this.loginToUserPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginToUserPanel.Name = "loginToUserPanel";
            this.loginToUserPanel.Size = new System.Drawing.Size(82, 31);
            this.loginToUserPanel.TabIndex = 2;
            this.loginToUserPanel.Text = "Sign In";
            this.loginToUserPanel.UseVisualStyleBackColor = true;
            this.loginToUserPanel.Click += new System.EventHandler(this.LoginToUserPanel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginOrCreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginToUserPanel);
            this.Controls.Add(this.txtPassForLogin);
            this.Controls.Add(this.txtUserNameLogin);
            this.Controls.Add(this.passwordForLogin);
            this.Controls.Add(this.userNameForLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginOrCreateUserForm";
            this.Text = "LoginOrCreateUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameForLogin;
        private System.Windows.Forms.Label passwordForLogin;
        private System.Windows.Forms.TextBox txtUserNameLogin;
        private System.Windows.Forms.TextBox txtPassForLogin;
        private System.Windows.Forms.Button loginToUserPanel;
        private System.Windows.Forms.Button button1;
    }
}