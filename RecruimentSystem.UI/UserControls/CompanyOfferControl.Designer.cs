namespace RecruitmentSystem.UI
{
    partial class CompanyOfferControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowDetailsBtn = new System.Windows.Forms.Button();
            this.SendingResumeBtn = new System.Windows.Forms.Button();
            this.JobName = new System.Windows.Forms.Label();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.ShowDetailsBtn);
            this.groupBox1.Controls.Add(this.SendingResumeBtn);
            this.groupBox1.Controls.Add(this.JobName);
            this.groupBox1.Controls.Add(this.LblCompanyName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(59, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(305, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ShowDetailsBtn
            // 
            this.ShowDetailsBtn.Location = new System.Drawing.Point(19, 287);
            this.ShowDetailsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowDetailsBtn.Name = "ShowDetailsBtn";
            this.ShowDetailsBtn.Size = new System.Drawing.Size(117, 29);
            this.ShowDetailsBtn.TabIndex = 1;
            this.ShowDetailsBtn.Text = "اطلاعات بیشتر";
            this.ShowDetailsBtn.UseVisualStyleBackColor = true;
            this.ShowDetailsBtn.Click += new System.EventHandler(this.ShowDetailsBtn_Click);
            // 
            // SendingResumeBtn
            // 
            this.SendingResumeBtn.Location = new System.Drawing.Point(171, 287);
            this.SendingResumeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendingResumeBtn.Name = "SendingResumeBtn";
            this.SendingResumeBtn.Size = new System.Drawing.Size(117, 29);
            this.SendingResumeBtn.TabIndex = 0;
            this.SendingResumeBtn.Text = "ارسال رزومه";
            this.SendingResumeBtn.UseVisualStyleBackColor = true;
            this.SendingResumeBtn.Click += new System.EventHandler(this.SendingResumeBtn_Click);
            // 
            // JobName
            // 
            this.JobName.AutoSize = true;
            this.JobName.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JobName.Location = new System.Drawing.Point(116, 181);
            this.JobName.Name = "JobName";
            this.JobName.Size = new System.Drawing.Size(63, 26);
            this.JobName.TabIndex = 29;
            this.JobName.Text = "نام شغل";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCompanyName.Location = new System.Drawing.Point(116, 231);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(73, 21);
            this.LblCompanyName.TabIndex = 28;
            this.LblCompanyName.Text = "نام شرکت";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(129, 341);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "Date";
            // 
            // CompanyOfferControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompanyOfferControl";
            this.Size = new System.Drawing.Size(416, 416);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label JobName;
        public System.Windows.Forms.Label LblCompanyName;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SendingResumeBtn;
        private System.Windows.Forms.Button ShowDetailsBtn;
        public System.Windows.Forms.Label lblDate;
    }
}
