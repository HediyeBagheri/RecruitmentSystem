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
            this.label1 = new System.Windows.Forms.Label();
            this.jobNameLbl = new System.Windows.Forms.Label();
            this.salaryRequestLbl = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.workExperienceLbl = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(652, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "سابقه کاری";
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(477, 192);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 28);
            this.comboBox3.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(477, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1-3",
            "3-6",
            "6-9",
            "9-12",
            "12-15",
            "15-18",
            "18-21",
            "21-24",
            "24-27",
            "27-30"});
            this.comboBox1.Location = new System.Drawing.Point(477, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 19;
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
            // ResumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveResumeBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobNameLbl);
            this.Controls.Add(this.salaryRequestLbl);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.workExperienceLbl);
            this.Name = "ResumeForm";
            this.Text = "ResumeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveResumeBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label jobNameLbl;
        private System.Windows.Forms.Label salaryRequestLbl;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label workExperienceLbl;
    }
}