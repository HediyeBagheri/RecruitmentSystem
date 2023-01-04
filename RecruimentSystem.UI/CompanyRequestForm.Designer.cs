namespace RecruitmentSystem.UI
{
    partial class CompanyRequestForm
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
            this.BtnCompanyReq = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PicBoxComRequest = new System.Windows.Forms.PictureBox();
            this.CmbJobName = new System.Windows.Forms.ComboBox();
            this.TxtMinEducationDegree = new System.Windows.Forms.TextBox();
            this.CmbTypeOfCooperation = new System.Windows.Forms.ComboBox();
            this.TxtSalaryPropose = new System.Windows.Forms.TextBox();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.TxtMinWorkExperience = new System.Windows.Forms.TextBox();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SalaryPropose = new System.Windows.Forms.Label();
            this.JobName = new System.Windows.Forms.Label();
            this.CompanyName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxComRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCompanyReq
            // 
            this.BtnCompanyReq.Location = new System.Drawing.Point(44, 627);
            this.BtnCompanyReq.Name = "BtnCompanyReq";
            this.BtnCompanyReq.Size = new System.Drawing.Size(148, 47);
            this.BtnCompanyReq.TabIndex = 48;
            this.BtnCompanyReq.Text = "ثبت درخواست";
            this.BtnCompanyReq.UseVisualStyleBackColor = true;
            this.BtnCompanyReq.Click += new System.EventHandler(this.BtnCompanyReq_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.PicBoxComRequest);
            this.groupBox1.Controls.Add(this.CmbJobName);
            this.groupBox1.Controls.Add(this.TxtMinEducationDegree);
            this.groupBox1.Controls.Add(this.CmbTypeOfCooperation);
            this.groupBox1.Controls.Add(this.TxtSalaryPropose);
            this.groupBox1.Controls.Add(this.TxtLocation);
            this.groupBox1.Controls.Add(this.TxtMinWorkExperience);
            this.groupBox1.Controls.Add(this.TxtCompanyName);
            this.groupBox1.Controls.Add(this.TxtDescription);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SalaryPropose);
            this.groupBox1.Controls.Add(this.JobName);
            this.groupBox1.Controls.Add(this.CompanyName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 596);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 29);
            this.button1.TabIndex = 72;
            this.button1.Text = "انتخاب تصویر";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PicBoxComRequest
            // 
            this.PicBoxComRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxComRequest.Location = new System.Drawing.Point(53, 56);
            this.PicBoxComRequest.Name = "PicBoxComRequest";
            this.PicBoxComRequest.Size = new System.Drawing.Size(179, 151);
            this.PicBoxComRequest.TabIndex = 71;
            this.PicBoxComRequest.TabStop = false;
            // 
            // CmbJobName
            // 
            this.CmbJobName.FormattingEnabled = true;
            this.CmbJobName.Location = new System.Drawing.Point(362, 109);
            this.CmbJobName.Name = "CmbJobName";
            this.CmbJobName.Size = new System.Drawing.Size(208, 28);
            this.CmbJobName.TabIndex = 70;
            // 
            // TxtMinEducationDegree
            // 
            this.TxtMinEducationDegree.Location = new System.Drawing.Point(362, 370);
            this.TxtMinEducationDegree.Name = "TxtMinEducationDegree";
            this.TxtMinEducationDegree.Size = new System.Drawing.Size(208, 27);
            this.TxtMinEducationDegree.TabIndex = 69;
            // 
            // CmbTypeOfCooperation
            // 
            this.CmbTypeOfCooperation.FormattingEnabled = true;
            this.CmbTypeOfCooperation.Location = new System.Drawing.Point(362, 314);
            this.CmbTypeOfCooperation.Name = "CmbTypeOfCooperation";
            this.CmbTypeOfCooperation.Size = new System.Drawing.Size(208, 28);
            this.CmbTypeOfCooperation.TabIndex = 68;
            // 
            // TxtSalaryPropose
            // 
            this.TxtSalaryPropose.Location = new System.Drawing.Point(362, 158);
            this.TxtSalaryPropose.Name = "TxtSalaryPropose";
            this.TxtSalaryPropose.Size = new System.Drawing.Size(208, 27);
            this.TxtSalaryPropose.TabIndex = 66;
            // 
            // TxtLocation
            // 
            this.TxtLocation.Location = new System.Drawing.Point(362, 208);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(208, 27);
            this.TxtLocation.TabIndex = 65;
            // 
            // TxtMinWorkExperience
            // 
            this.TxtMinWorkExperience.Location = new System.Drawing.Point(362, 264);
            this.TxtMinWorkExperience.Name = "TxtMinWorkExperience";
            this.TxtMinWorkExperience.Size = new System.Drawing.Size(208, 27);
            this.TxtMinWorkExperience.TabIndex = 64;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(362, 56);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(208, 27);
            this.TxtCompanyName.TabIndex = 63;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(243, 427);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(327, 120);
            this.TxtDescription.TabIndex = 62;
            this.TxtDescription.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(672, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 55;
            this.label13.Text = "توضیحات";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(597, 377);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 20);
            this.label14.TabIndex = 54;
            this.label14.Text = "حداقل مدرک تحصیلی";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(659, 322);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 20);
            this.label15.TabIndex = 53;
            this.label15.Text = "نوع همکاری";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(619, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 20);
            this.label16.TabIndex = 52;
            this.label16.Text = "حداقل سابقه کاری";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "موقعیت مکانی";
            // 
            // SalaryPropose
            // 
            this.SalaryPropose.AutoSize = true;
            this.SalaryPropose.Location = new System.Drawing.Point(633, 165);
            this.SalaryPropose.Name = "SalaryPropose";
            this.SalaryPropose.Size = new System.Drawing.Size(108, 20);
            this.SalaryPropose.TabIndex = 50;
            this.SalaryPropose.Text = "حقوق پیشنهادی";
            // 
            // JobName
            // 
            this.JobName.AutoSize = true;
            this.JobName.Location = new System.Drawing.Point(678, 117);
            this.JobName.Name = "JobName";
            this.JobName.Size = new System.Drawing.Size(63, 20);
            this.JobName.TabIndex = 49;
            this.JobName.Text = "نام شغل";
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Location = new System.Drawing.Point(672, 59);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(69, 20);
            this.CompanyName.TabIndex = 48;
            this.CompanyName.Text = "نام شرکت";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // CompanyRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 699);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCompanyReq);
            this.Name = "CompanyRequestForm";
            this.Text = "CompanyRequest";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxComRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCompanyReq;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label SalaryPropose;
        public System.Windows.Forms.Label JobName;
        public System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.TextBox TxtMinEducationDegree;
        private System.Windows.Forms.ComboBox CmbTypeOfCooperation;
        private System.Windows.Forms.TextBox TxtSalaryPropose;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.TextBox TxtMinWorkExperience;
        private System.Windows.Forms.TextBox TxtCompanyName;
        public System.Windows.Forms.RichTextBox TxtDescription;
        private System.Windows.Forms.ComboBox CmbJobName;
        private System.Windows.Forms.PictureBox PicBoxComRequest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}