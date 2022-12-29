namespace RecruitmentSystem.UI
{
    partial class ApplicantPanelForm
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
            this.recruitBtn = new System.Windows.Forms.Button();
            this.trainingBtn = new System.Windows.Forms.Button();
            this.BtnProfileUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recruitBtn
            // 
            this.recruitBtn.Location = new System.Drawing.Point(519, 509);
            this.recruitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recruitBtn.Name = "recruitBtn";
            this.recruitBtn.Size = new System.Drawing.Size(107, 39);
            this.recruitBtn.TabIndex = 0;
            this.recruitBtn.Text = "استخدام";
            this.recruitBtn.UseVisualStyleBackColor = true;
            this.recruitBtn.Click += new System.EventHandler(this.RecruitBtn_Click);
            // 
            // trainingBtn
            // 
            this.trainingBtn.Location = new System.Drawing.Point(306, 509);
            this.trainingBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trainingBtn.Name = "trainingBtn";
            this.trainingBtn.Size = new System.Drawing.Size(107, 39);
            this.trainingBtn.TabIndex = 1;
            this.trainingBtn.Text = "اموزش";
            this.trainingBtn.UseVisualStyleBackColor = true;
            this.trainingBtn.Click += new System.EventHandler(this.TrainingBtn_Click);
            // 
            // BtnProfileUpdate
            // 
            this.BtnProfileUpdate.Location = new System.Drawing.Point(69, 509);
            this.BtnProfileUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnProfileUpdate.Name = "BtnProfileUpdate";
            this.BtnProfileUpdate.Size = new System.Drawing.Size(147, 39);
            this.BtnProfileUpdate.TabIndex = 2;
            this.BtnProfileUpdate.Text = "تکمیل رزومه";
            this.BtnProfileUpdate.UseVisualStyleBackColor = true;
            this.BtnProfileUpdate.Click += new System.EventHandler(this.BtnProfileUpdate_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 84);
            this.label1.TabIndex = 4;
            this.label1.Text = "APPLICANT PANEL";
            // 
            // LblWelcome
            // 
            this.LblWelcome.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblWelcome.Location = new System.Drawing.Point(233, 115);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(279, 45);
            this.LblWelcome.TabIndex = 5;
            this.LblWelcome.Text = "welcome";
            // 
            // ApplicantPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 600);
            this.Controls.Add(this.LblWelcome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnProfileUpdate);
            this.Controls.Add(this.trainingBtn);
            this.Controls.Add(this.recruitBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ApplicantPanelForm";
            this.Text = "ApplicantPanelForm";
            this.Load += new System.EventHandler(this.ApplicantPanelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recruitBtn;
        private System.Windows.Forms.Button trainingBtn;
        private System.Windows.Forms.Button BtnProfileUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblWelcome;
    }
}