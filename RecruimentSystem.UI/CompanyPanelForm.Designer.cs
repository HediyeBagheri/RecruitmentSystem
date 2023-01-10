namespace RecruitmentSystem.UI
{
    partial class CompanyPanelForm
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
            this.companyRecruitBtn = new System.Windows.Forms.Button();
            this.educationBtn = new System.Windows.Forms.Button();
            this.Request = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.BtnMyRequests = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // companyRecruitBtn
            // 
            this.companyRecruitBtn.Location = new System.Drawing.Point(411, 47);
            this.companyRecruitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.companyRecruitBtn.Name = "companyRecruitBtn";
            this.companyRecruitBtn.Size = new System.Drawing.Size(107, 38);
            this.companyRecruitBtn.TabIndex = 0;
            this.companyRecruitBtn.Text = "استخدام";
            this.companyRecruitBtn.UseVisualStyleBackColor = true;
            this.companyRecruitBtn.Click += new System.EventHandler(this.CompanyRecruitBtn_Click);
            // 
            // educationBtn
            // 
            this.educationBtn.Location = new System.Drawing.Point(411, 202);
            this.educationBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.educationBtn.Name = "educationBtn";
            this.educationBtn.Size = new System.Drawing.Size(107, 38);
            this.educationBtn.TabIndex = 3;
            this.educationBtn.Text = "تکمیل مشخصات";
            this.educationBtn.UseVisualStyleBackColor = true;
            this.educationBtn.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(411, 98);
            this.Request.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(107, 38);
            this.Request.TabIndex = 1;
            this.Request.Text = "ارسال درخواست";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Click += new System.EventHandler(this.Request_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "COMPANY PANEL";
            // 
            // LblWelcome
            // 
            this.LblWelcome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblWelcome.Location = new System.Drawing.Point(90, 75);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(271, 26);
            this.LblWelcome.TabIndex = 4;
            this.LblWelcome.Text = "Welcome";
            // 
            // BtnMyRequests
            // 
            this.BtnMyRequests.Location = new System.Drawing.Point(411, 150);
            this.BtnMyRequests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMyRequests.Name = "BtnMyRequests";
            this.BtnMyRequests.Size = new System.Drawing.Size(107, 38);
            this.BtnMyRequests.TabIndex = 2;
            this.BtnMyRequests.Text = "درخواست های من";
            this.BtnMyRequests.UseVisualStyleBackColor = true;
            this.BtnMyRequests.Click += new System.EventHandler(this.BtnMyRequests_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(411, 255);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(107, 38);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "خروج";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CompanyPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 322);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMyRequests);
            this.Controls.Add(this.LblWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.educationBtn);
            this.Controls.Add(this.companyRecruitBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompanyPanelForm";
            this.Text = "CompanyPanelForm";
            this.Load += new System.EventHandler(this.CompanyPanelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button companyRecruitBtn;
        private System.Windows.Forms.Button educationBtn;
        private System.Windows.Forms.Button Request;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Button BtnMyRequests;
        private System.Windows.Forms.Button BtnExit;
    }
}