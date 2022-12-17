namespace RecruitmentSystem.UI
{
    partial class ResumeForm
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
            this.saveResumeBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Description = new System.Windows.Forms.Label();
            this.jobNameLbl = new System.Windows.Forms.Label();
            this.salaryRequestLbl = new System.Windows.Forms.Label();
            this.JobCmbBox = new System.Windows.Forms.ComboBox();
            this.workExperienceLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveResumeBtn
            // 
            this.saveResumeBtn.Location = new System.Drawing.Point(34, 365);
            this.saveResumeBtn.Name = "saveResumeBtn";
            this.saveResumeBtn.Size = new System.Drawing.Size(94, 29);
            this.saveResumeBtn.TabIndex = 26;
            this.saveResumeBtn.Text = "ثبت";
            this.saveResumeBtn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(372, 274);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(256, 120);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(652, 262);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(69, 20);
            this.Description.TabIndex = 24;
            this.Description.Text = "توضیحات";
            // 
            // jobNameLbl
            // 
            this.jobNameLbl.AutoSize = true;
            this.jobNameLbl.Location = new System.Drawing.Point(652, 195);
            this.jobNameLbl.Name = "jobNameLbl";
            this.jobNameLbl.Size = new System.Drawing.Size(111, 20);
            this.jobNameLbl.TabIndex = 23;
            this.jobNameLbl.Text = "شغل درخواستی";
            // 
            // salaryRequestLbl
            // 
            this.salaryRequestLbl.AutoSize = true;
            this.salaryRequestLbl.Location = new System.Drawing.Point(652, 126);
            this.salaryRequestLbl.Name = "salaryRequestLbl";
            this.salaryRequestLbl.Size = new System.Drawing.Size(115, 20);
            this.salaryRequestLbl.TabIndex = 22;
            this.salaryRequestLbl.Text = "حقوق درخواستی";
            // 
            // JobCmbBox
            // 
            this.JobCmbBox.FormattingEnabled = true;
            this.JobCmbBox.Location = new System.Drawing.Point(477, 192);
            this.JobCmbBox.Name = "JobCmbBox";
            this.JobCmbBox.Size = new System.Drawing.Size(151, 28);
            this.JobCmbBox.TabIndex = 21;
            // 
            // workExperienceLbl
            // 
            this.workExperienceLbl.AutoSize = true;
            this.workExperienceLbl.Location = new System.Drawing.Point(652, 65);
            this.workExperienceLbl.Name = "workExperienceLbl";
            this.workExperienceLbl.Size = new System.Drawing.Size(79, 20);
            this.workExperienceLbl.TabIndex = 18;
            this.workExperienceLbl.Text = "سابقه کاری";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(477, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 27);
            this.textBox2.TabIndex = 28;
            // 
            // ResumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.saveResumeBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.jobNameLbl);
            this.Controls.Add(this.salaryRequestLbl);
            this.Controls.Add(this.JobCmbBox);
            this.Controls.Add(this.workExperienceLbl);
            this.Name = "ResumeForm";
            this.Text = "ResumeForm";
            this.Load += new System.EventHandler(this.ResumeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveResumeBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label jobNameLbl;
        private System.Windows.Forms.Label salaryRequestLbl;
        private System.Windows.Forms.ComboBox JobCmbBox;
        private System.Windows.Forms.Label workExperienceLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}