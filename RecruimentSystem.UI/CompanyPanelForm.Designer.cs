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
            this.SuspendLayout();
            // 
            // companyRecruitBtn
            // 
            this.companyRecruitBtn.Location = new System.Drawing.Point(534, 98);
            this.companyRecruitBtn.Name = "companyRecruitBtn";
            this.companyRecruitBtn.Size = new System.Drawing.Size(94, 29);
            this.companyRecruitBtn.TabIndex = 0;
            this.companyRecruitBtn.Text = "استخدام";
            this.companyRecruitBtn.UseVisualStyleBackColor = true;
            this.companyRecruitBtn.Click += new System.EventHandler(this.companyRecruitBtn_Click);
            // 
            // educationBtn
            // 
            this.educationBtn.Location = new System.Drawing.Point(534, 195);
            this.educationBtn.Name = "educationBtn";
            this.educationBtn.Size = new System.Drawing.Size(94, 29);
            this.educationBtn.TabIndex = 1;
            this.educationBtn.Text = "اموزش";
            this.educationBtn.UseVisualStyleBackColor = true;
            this.educationBtn.Click += new System.EventHandler(this.educationBtn_Click);
            // 
            // CompanyPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.educationBtn);
            this.Controls.Add(this.companyRecruitBtn);
            this.Name = "CompanyPanelForm";
            this.Text = "CompanyPanelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button companyRecruitBtn;
        private System.Windows.Forms.Button educationBtn;
    }
}