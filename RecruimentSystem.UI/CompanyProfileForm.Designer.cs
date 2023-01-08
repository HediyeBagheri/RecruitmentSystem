namespace RecruitmentSystem.UI
{
    partial class CompanyProfileForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtAddress = new System.Windows.Forms.RichTextBox();
            this.TxtBusiness = new System.Windows.Forms.TextBox();
            this.TxtManagerName = new System.Windows.Forms.TextBox();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.LblManagerName = new System.Windows.Forms.Label();
            this.LblBusiness = new System.Windows.Forms.Label();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.TxtBusiness);
            this.groupBox1.Controls.Add(this.TxtManagerName);
            this.groupBox1.Controls.Add(this.TxtCompanyName);
            this.groupBox1.Controls.Add(this.LblManagerName);
            this.groupBox1.Controls.Add(this.LblBusiness);
            this.groupBox1.Controls.Add(this.LblAddress);
            this.groupBox1.Controls.Add(this.LblCompanyName);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(265, 221);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(270, 120);
            this.TxtAddress.TabIndex = 7;
            this.TxtAddress.Text = "";
            // 
            // TxtBusiness
            // 
            this.TxtBusiness.Location = new System.Drawing.Point(310, 155);
            this.TxtBusiness.Name = "TxtBusiness";
            this.TxtBusiness.Size = new System.Drawing.Size(225, 27);
            this.TxtBusiness.TabIndex = 6;
            // 
            // TxtManagerName
            // 
            this.TxtManagerName.Location = new System.Drawing.Point(310, 99);
            this.TxtManagerName.Name = "TxtManagerName";
            this.TxtManagerName.Size = new System.Drawing.Size(225, 27);
            this.TxtManagerName.TabIndex = 5;
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(310, 41);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(225, 27);
            this.TxtCompanyName.TabIndex = 4;
            // 
            // LblManagerName
            // 
            this.LblManagerName.AutoSize = true;
            this.LblManagerName.Location = new System.Drawing.Point(637, 106);
            this.LblManagerName.Name = "LblManagerName";
            this.LblManagerName.Size = new System.Drawing.Size(101, 20);
            this.LblManagerName.TabIndex = 3;
            this.LblManagerName.Text = "نام مدیر شرکت";
            // 
            // LblBusiness
            // 
            this.LblBusiness.AutoSize = true;
            this.LblBusiness.Location = new System.Drawing.Point(637, 162);
            this.LblBusiness.Name = "LblBusiness";
            this.LblBusiness.Size = new System.Drawing.Size(71, 20);
            this.LblBusiness.TabIndex = 2;
            this.LblBusiness.Text = "حوزه کاری";
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(637, 221);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(44, 20);
            this.LblAddress.TabIndex = 1;
            this.LblAddress.Text = "ادرس";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(637, 48);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(69, 20);
            this.LblCompanyName.TabIndex = 0;
            this.LblCompanyName.Text = "نام شرکت";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(43, 392);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(125, 46);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "ثبت";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CompanyProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "CompanyProfileForm";
            this.Text = "CompanyProfileForm";
            this.Load += new System.EventHandler(this.Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBusiness;
        private System.Windows.Forms.TextBox TxtManagerName;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Label LblManagerName;
        private System.Windows.Forms.Label LblBusiness;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.RichTextBox TxtAddress;
        private System.Windows.Forms.Button BtnSave;
    }
}