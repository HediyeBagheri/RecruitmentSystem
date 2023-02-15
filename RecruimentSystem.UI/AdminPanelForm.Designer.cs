namespace RecruitmentSystem.UI
{
    partial class AdminPanelForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.TabPApplicantList = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DgvApplicant = new System.Windows.Forms.DataGridView();
            this.btnClick = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPEmployeeOffer = new System.Windows.Forms.TabPage();
            this.DvgEmpReq = new System.Windows.Forms.DataGridView();
            this.tabPCompanyList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabRecProcess = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.BtnHome = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.TabPApplicantList.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApplicant)).BeginInit();
            this.tabPEmployeeOffer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DvgEmpReq)).BeginInit();
            this.tabPCompanyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabRecProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TabPApplicantList);
            this.tabControl.Controls.Add(this.tabPEmployeeOffer);
            this.tabControl.Controls.Add(this.tabPCompanyList);
            this.tabControl.Controls.Add(this.tabRecProcess);
            this.tabControl.Location = new System.Drawing.Point(11, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(889, 349);
            this.tabControl.TabIndex = 4;
            // 
            // TabPApplicantList
            // 
            this.TabPApplicantList.Controls.Add(this.flowLayoutPanel1);
            this.TabPApplicantList.Location = new System.Drawing.Point(4, 29);
            this.TabPApplicantList.Name = "TabPApplicantList";
            this.TabPApplicantList.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.TabPApplicantList.Size = new System.Drawing.Size(881, 316);
            this.TabPApplicantList.TabIndex = 0;
            this.TabPApplicantList.Text = "لیست کاربران";
            this.TabPApplicantList.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView2);
            this.flowLayoutPanel1.Controls.Add(this.DgvApplicant);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(875, 310);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(299, 0);
            this.dataGridView2.TabIndex = 0;
            // 
            // DgvApplicant
            // 
            this.DgvApplicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvApplicant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnClick});
            this.DgvApplicant.Location = new System.Drawing.Point(3, 9);
            this.DgvApplicant.Name = "DgvApplicant";
            this.DgvApplicant.RowHeadersWidth = 20;
            this.DgvApplicant.RowTemplate.Height = 29;
            this.DgvApplicant.Size = new System.Drawing.Size(878, 299);
            this.DgvApplicant.TabIndex = 1;
            // 
            // btnClick
            // 
            this.btnClick.Frozen = true;
            this.btnClick.HeaderText = "Choose";
            this.btnClick.MinimumWidth = 6;
            this.btnClick.Name = "btnClick";
            this.btnClick.Text = "Choose";
            this.btnClick.Width = 125;
            // 
            // tabPEmployeeOffer
            // 
            this.tabPEmployeeOffer.Controls.Add(this.DvgEmpReq);
            this.tabPEmployeeOffer.Location = new System.Drawing.Point(4, 29);
            this.tabPEmployeeOffer.Name = "tabPEmployeeOffer";
            this.tabPEmployeeOffer.Size = new System.Drawing.Size(881, 316);
            this.tabPEmployeeOffer.TabIndex = 3;
            this.tabPEmployeeOffer.Text = "درخواست های نیرو";
            this.tabPEmployeeOffer.UseVisualStyleBackColor = true;
            // 
            // DvgEmpReq
            // 
            this.DvgEmpReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgEmpReq.Location = new System.Drawing.Point(0, 0);
            this.DvgEmpReq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DvgEmpReq.Name = "DvgEmpReq";
            this.DvgEmpReq.RowHeadersWidth = 51;
            this.DvgEmpReq.RowTemplate.Height = 25;
            this.DvgEmpReq.Size = new System.Drawing.Size(885, 312);
            this.DvgEmpReq.TabIndex = 0;
            // 
            // tabPCompanyList
            // 
            this.tabPCompanyList.Controls.Add(this.dataGridView1);
            this.tabPCompanyList.Location = new System.Drawing.Point(4, 29);
            this.tabPCompanyList.Name = "tabPCompanyList";
            this.tabPCompanyList.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPCompanyList.Size = new System.Drawing.Size(881, 316);
            this.tabPCompanyList.TabIndex = 1;
            this.tabPCompanyList.Text = "لیست شرکت ها";
            this.tabPCompanyList.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(875, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabRecProcess
            // 
            this.tabRecProcess.Controls.Add(this.dataGridView3);
            this.tabRecProcess.Location = new System.Drawing.Point(4, 29);
            this.tabRecProcess.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRecProcess.Name = "tabRecProcess";
            this.tabRecProcess.Size = new System.Drawing.Size(881, 316);
            this.tabRecProcess.TabIndex = 4;
            this.tabRecProcess.Text = "فرایندهای استخدامی";
            this.tabRecProcess.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 4);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(873, 304);
            this.dataGridView3.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Location = new System.Drawing.Point(21, 445);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(94, 29);
            this.BtnHome.TabIndex = 5;
            this.BtnHome.Text = "home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 543);
            this.Controls.Add(this.BtnHome);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl.ResumeLayout(false);
            this.TabPApplicantList.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApplicant)).EndInit();
            this.tabPEmployeeOffer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DvgEmpReq)).EndInit();
            this.tabPCompanyList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabRecProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TabPApplicantList;
        private System.Windows.Forms.TabPage tabPCompanyList;
        private System.Windows.Forms.TabPage tabPEmployeeOffer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView DgvApplicant;
        private System.Windows.Forms.TabPage tabRecProcess;
        private System.Windows.Forms.DataGridView DvgEmpReq;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewButtonColumn btnClick;
        private System.Windows.Forms.Button BtnHome;
    }
}