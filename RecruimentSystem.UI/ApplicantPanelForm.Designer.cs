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
            // recruitBtn
            // 
            this.recruitBtn.Location = new System.Drawing.Point(770, 509);
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
            this.trainingBtn.Location = new System.Drawing.Point(630, 509);
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
            this.BtnProfileUpdate.Location = new System.Drawing.Point(449, 509);
            this.BtnProfileUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnProfileUpdate.Name = "BtnProfileUpdate";
            this.BtnProfileUpdate.Size = new System.Drawing.Size(147, 39);
            this.BtnProfileUpdate.TabIndex = 3;
            this.BtnProfileUpdate.Text = "تکمیل رزومه";
            this.BtnProfileUpdate.UseVisualStyleBackColor = true;
            this.BtnProfileUpdate.Click += new System.EventHandler(this.BtnProfileUpdate_Click);
            // 
            // ApplicantPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.BtnProfileUpdate);
            this.Controls.Add(this.trainingBtn);
            this.Controls.Add(this.recruitBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ApplicantPanelForm";
            this.Text = "ApplicantPanelForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recruitBtn;
        private System.Windows.Forms.Button trainingBtn;
        private System.Windows.Forms.Button BtnProfileUpdate;
    }
}