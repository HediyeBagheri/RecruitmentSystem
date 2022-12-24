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
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.recruitBtn.Location = new System.Drawing.Point(674, 382);
            this.recruitBtn.Name = "recruitBtn";
            this.recruitBtn.Size = new System.Drawing.Size(94, 29);
            this.recruitBtn.TabIndex = 0;
            this.recruitBtn.Text = "استخدام";
            this.recruitBtn.UseVisualStyleBackColor = true;
            this.recruitBtn.Click += new System.EventHandler(this.RecruitBtn_Click);
            // 
            // tsmRecruitItem
            // 
            this.trainingBtn.Location = new System.Drawing.Point(557, 382);
            this.trainingBtn.Name = "trainingBtn";
            this.trainingBtn.Size = new System.Drawing.Size(94, 29);
            this.trainingBtn.TabIndex = 1;
            this.trainingBtn.Text = "اموزش";
            this.trainingBtn.UseVisualStyleBackColor = true;
            this.trainingBtn.Click += new System.EventHandler(this.TrainingBtn_Click);
            // 
            // BtnProfileUpdate
            // 
            this.BtnProfileUpdate.Location = new System.Drawing.Point(393, 382);
            this.BtnProfileUpdate.Name = "BtnProfileUpdate";
            this.BtnProfileUpdate.Size = new System.Drawing.Size(129, 29);
            this.BtnProfileUpdate.TabIndex = 3;
            this.BtnProfileUpdate.Text = "تکمیل رزومه";
            this.BtnProfileUpdate.UseVisualStyleBackColor = true;
            this.BtnProfileUpdate.Click += new System.EventHandler(this.BtnProfileUpdate_Click);
            // 
            // ApplicantPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnProfileUpdate);
            this.Controls.Add(this.trainingBtn);
            this.Controls.Add(this.recruitBtn);
            this.Name = "ApplicantPanelForm";
            this.Text = "ApplicantPanelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button recruitBtn;
        private System.Windows.Forms.Button trainingBtn;
        private System.Windows.Forms.Button BtnProfileUpdate;
    }
}