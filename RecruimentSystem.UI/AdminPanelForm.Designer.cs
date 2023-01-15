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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPCompanyList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPJobOffer = new System.Windows.Forms.TabPage();
            this.tabPEmployeeOffer = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.TabPApplicantList.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPCompanyList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TabPApplicantList);
            this.tabControl.Controls.Add(this.tabPCompanyList);
            this.tabControl.Controls.Add(this.tabPJobOffer);
            this.tabControl.Controls.Add(this.tabPEmployeeOffer);
            this.tabControl.Location = new System.Drawing.Point(12, 34);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(495, 350);
            this.tabControl.TabIndex = 4;
            // 
            // TabPApplicantList
            // 
            this.TabPApplicantList.Controls.Add(this.flowLayoutPanel1);
            this.TabPApplicantList.Location = new System.Drawing.Point(4, 29);
            this.TabPApplicantList.Name = "TabPApplicantList";
            this.TabPApplicantList.Padding = new System.Windows.Forms.Padding(3);
            this.TabPApplicantList.Size = new System.Drawing.Size(487, 317);
            this.TabPApplicantList.TabIndex = 0;
            this.TabPApplicantList.Text = "لیست کاربران";
            this.TabPApplicantList.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView2);
            this.flowLayoutPanel1.Controls.Add(this.dataGridView3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(481, 311);
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
            this.dataGridView2.Size = new System.Drawing.Size(300, 0);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(3, 9);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(478, 299);
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPCompanyList
            // 
            this.tabPCompanyList.Controls.Add(this.dataGridView1);
            this.tabPCompanyList.Location = new System.Drawing.Point(4, 29);
            this.tabPCompanyList.Name = "tabPCompanyList";
            this.tabPCompanyList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPCompanyList.Size = new System.Drawing.Size(487, 317);
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
            this.dataGridView1.Size = new System.Drawing.Size(481, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPJobOffer
            // 
            this.tabPJobOffer.Location = new System.Drawing.Point(4, 29);
            this.tabPJobOffer.Name = "tabPJobOffer";
            this.tabPJobOffer.Size = new System.Drawing.Size(487, 317);
            this.tabPJobOffer.TabIndex = 2;
            this.tabPJobOffer.Text = "درخواست های شغل";
            this.tabPJobOffer.UseVisualStyleBackColor = true;
            // 
            // tabPEmployeeOffer
            // 
            this.tabPEmployeeOffer.Location = new System.Drawing.Point(4, 29);
            this.tabPEmployeeOffer.Name = "tabPEmployeeOffer";
            this.tabPEmployeeOffer.Size = new System.Drawing.Size(487, 317);
            this.tabPEmployeeOffer.TabIndex = 3;
            this.tabPEmployeeOffer.Text = "درخواست های کارمند";
            this.tabPEmployeeOffer.UseVisualStyleBackColor = true;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 543);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl.ResumeLayout(false);
            this.TabPApplicantList.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPCompanyList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage TabPApplicantList;
        private System.Windows.Forms.TabPage tabPCompanyList;
        private System.Windows.Forms.TabPage tabPJobOffer;
        private System.Windows.Forms.TabPage tabPEmployeeOffer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}