namespace RecruitmentSystem.UI.UserControls
{
    partial class MyOffer
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
            this.PicBoxMyOffer = new System.Windows.Forms.PictureBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblJob = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMyOffer)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxMyOffer
            // 
            this.PicBoxMyOffer.Location = new System.Drawing.Point(33, 29);
            this.PicBoxMyOffer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PicBoxMyOffer.Name = "PicBoxMyOffer";
            this.PicBoxMyOffer.Size = new System.Drawing.Size(271, 200);
            this.PicBoxMyOffer.TabIndex = 0;
            this.PicBoxMyOffer.TabStop = false;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(218, 327);
            this.BtnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(86, 43);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "نمایش";
            this.BtnShow.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(126, 327);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(86, 43);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "آپدیت";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(33, 327);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(86, 43);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblJob
            // 
            this.LblJob.AutoSize = true;
            this.LblJob.Location = new System.Drawing.Point(126, 253);
            this.LblJob.Name = "LblJob";
            this.LblJob.Size = new System.Drawing.Size(50, 20);
            this.LblJob.TabIndex = 4;
            this.LblJob.Text = "label1";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(126, 288);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(50, 20);
            this.LblDate.TabIndex = 5;
            this.LblDate.Text = "label2";
            // 
            // MyOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblJob);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.PicBoxMyOffer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MyOffer";
            this.Size = new System.Drawing.Size(333, 411);
            this.Load += new System.EventHandler(this.MyOffer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxMyOffer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox PicBoxMyOffer;
        public System.Windows.Forms.Button BtnShow;
        public System.Windows.Forms.Button BtnUpdate;
        public System.Windows.Forms.Button BtnDelete;
        public System.Windows.Forms.Label LblJob;
        public System.Windows.Forms.Label LblDate;
    }
}
