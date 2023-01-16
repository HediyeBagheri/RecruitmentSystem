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
            this.lblDate = new System.Windows.Forms.Label();
            this.ShowDetailsBtn = new System.Windows.Forms.Button();
            this.SendingResumeBtn = new System.Windows.Forms.Button();
            this.JobName = new System.Windows.Forms.Label();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.PicBoxOfferControll = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOfferControll)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.ShowDetailsBtn);
            this.groupBox1.Controls.Add(this.SendingResumeBtn);
            this.groupBox1.Controls.Add(this.JobName);
            this.groupBox1.Controls.Add(this.LblCompanyName);
            this.groupBox1.Controls.Add(this.PicBoxOfferControll);
            this.groupBox1.Location = new System.Drawing.Point(34, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(75, 457);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "Date";
            // 
            // ShowDetailsBtn
            // 
            this.ShowDetailsBtn.Location = new System.Drawing.Point(18, 368);
            this.ShowDetailsBtn.Name = "ShowDetailsBtn";
            this.ShowDetailsBtn.Size = new System.Drawing.Size(119, 53);
            this.ShowDetailsBtn.TabIndex = 1;
            this.ShowDetailsBtn.Text = "اطلاعات بیشتر";
            this.ShowDetailsBtn.UseVisualStyleBackColor = true;
            this.ShowDetailsBtn.Click += new System.EventHandler(this.ShowDetailsBtn_Click);
            // 
            // SendingResumeBtn
            // 
            this.SendingResumeBtn.Location = new System.Drawing.Point(144, 368);
            this.SendingResumeBtn.Name = "SendingResumeBtn";
            this.SendingResumeBtn.Size = new System.Drawing.Size(114, 53);
            this.SendingResumeBtn.TabIndex = 0;
            this.SendingResumeBtn.Text = "ارسال رزومه";
            this.SendingResumeBtn.UseVisualStyleBackColor = true;
            this.SendingResumeBtn.Click += new System.EventHandler(this.SendingResumeBtn_Click);
            // 
            // JobName
            // 
            this.JobName.AutoSize = true;
            this.JobName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JobName.Location = new System.Drawing.Point(87, 245);
            this.JobName.Name = "JobName";
            this.JobName.Size = new System.Drawing.Size(90, 36);
            this.JobName.TabIndex = 29;
            this.JobName.Text = "نام شغل";
            this.JobName.Click += new System.EventHandler(this.JobName_Click);
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCompanyName.Location = new System.Drawing.Point(87, 299);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(90, 28);
            this.LblCompanyName.TabIndex = 28;
            this.LblCompanyName.Text = "نام شرکت";
            // 
            // PicBoxOfferControll
            // 
            this.PicBoxOfferControll.Location = new System.Drawing.Point(18, 27);
            this.PicBoxOfferControll.Name = "PicBoxOfferControll";
            this.PicBoxOfferControll.Size = new System.Drawing.Size(240, 172);
            this.PicBoxOfferControll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxOfferControll.TabIndex = 27;
            this.PicBoxOfferControll.TabStop = false;
            // 
            // CompanyOfferControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CompanyOfferControl";
            this.Size = new System.Drawing.Size(373, 555);
            this.Load += new System.EventHandler(this.CompanyOfferControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOfferControll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label JobName;
        public System.Windows.Forms.Label LblCompanyName;
        public System.Windows.Forms.PictureBox PicBoxOfferControll;
        private System.Windows.Forms.Button SendingResumeBtn;
        private System.Windows.Forms.Button ShowDetailsBtn;
        public System.Windows.Forms.Label lblDate;
    }
}
