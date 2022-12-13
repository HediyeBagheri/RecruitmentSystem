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
            this.createUser = new System.Windows.Forms.Button();
            this.loginToUserPanel = new System.Windows.Forms.Button();
            this.userTypeLbl = new System.Windows.Forms.Label();
            this.userTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // userNameForLogin
            // 
            this.userNameForLogin.AutoSize = true;
            this.userNameForLogin.Location = new System.Drawing.Point(503, 85);
            this.userNameForLogin.Name = "userNameForLogin";
            this.userNameForLogin.Size = new System.Drawing.Size(78, 20);
            this.userNameForLogin.TabIndex = 0;
            this.userNameForLogin.Text = "UserName";
            // 
            // passwordForLogin
            // 
            this.passwordForLogin.AutoSize = true;
            this.passwordForLogin.Location = new System.Drawing.Point(503, 156);
            this.passwordForLogin.Name = "passwordForLogin";
            this.passwordForLogin.Size = new System.Drawing.Size(70, 20);
            this.passwordForLogin.TabIndex = 1;
            this.passwordForLogin.Text = "Password";
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.Location = new System.Drawing.Point(255, 87);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(226, 27);
            this.txtUserNameLogin.TabIndex = 2;
            // 
            // txtPassForLogin
            // 
            this.txtPassForLogin.Location = new System.Drawing.Point(255, 156);
            this.txtPassForLogin.Name = "txtPassForLogin";
            this.txtPassForLogin.Size = new System.Drawing.Size(226, 27);
            this.txtPassForLogin.TabIndex = 3;
            // 
            // createUser
            // 
            this.createUser.Location = new System.Drawing.Point(255, 355);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(94, 29);
            this.createUser.TabIndex = 4;
            this.createUser.Text = "عضویت";
            this.createUser.UseVisualStyleBackColor = true;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // loginToUserPanel
            // 
            this.loginToUserPanel.Location = new System.Drawing.Point(479, 355);
            this.loginToUserPanel.Name = "loginToUserPanel";
            this.loginToUserPanel.Size = new System.Drawing.Size(94, 29);
            this.loginToUserPanel.TabIndex = 5;
            this.loginToUserPanel.Text = "ورود";
            this.loginToUserPanel.UseVisualStyleBackColor = true;
            this.loginToUserPanel.Click += new System.EventHandler(this.loginToUserPanel_Click);
            // 
            // userTypeLbl
            // 
            this.userTypeLbl.AutoSize = true;
            this.userTypeLbl.Location = new System.Drawing.Point(503, 228);
            this.userTypeLbl.Name = "userTypeLbl";
            this.userTypeLbl.Size = new System.Drawing.Size(69, 20);
            this.userTypeLbl.TabIndex = 7;
            this.userTypeLbl.Text = "UserType";
            // 
            // userTypeCmbBox
            // 
            this.userTypeCmbBox.FormattingEnabled = true;
            this.userTypeCmbBox.Items.AddRange(new object[] {
            "Applicant",
            "Company"});
            this.userTypeCmbBox.Location = new System.Drawing.Point(255, 225);
            this.userTypeCmbBox.Name = "userTypeCmbBox";
            this.userTypeCmbBox.Size = new System.Drawing.Size(226, 28);
            this.userTypeCmbBox.TabIndex = 6;
            // 
            // LoginOrCreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userTypeLbl);
            this.Controls.Add(this.userTypeCmbBox);
            this.Controls.Add(this.loginToUserPanel);
            this.Controls.Add(this.createUser);
            this.Controls.Add(this.txtPassForLogin);
            this.Controls.Add(this.txtUserNameLogin);
            this.Controls.Add(this.passwordForLogin);
            this.Controls.Add(this.userNameForLogin);
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
        private System.Windows.Forms.Button createUser;
        private System.Windows.Forms.Button loginToUserPanel;
        private System.Windows.Forms.Label userTypeLbl;
        private System.Windows.Forms.ComboBox userTypeCmbBox;
    }
}