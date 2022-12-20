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
            this.panelMenu = new System.Windows.Forms.MenuStrip();
            this.tsmRecruitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTrainingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProfileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEditResumeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRecruitItem,
            this.tsmTrainingItem,
            this.tsmProfileItem,
            this.tsmEditResumeItem,
            this.tsmExitItem});
            this.panelMenu.Location = new System.Drawing.Point(9, 9);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(500, 24);
            this.panelMenu.TabIndex = 4;
            this.panelMenu.Text = "menuStrip1";
            // 
            // tsmRecruitItem
            // 
            this.tsmRecruitItem.Name = "tsmRecruitItem";
            this.tsmRecruitItem.Size = new System.Drawing.Size(89, 20);
            this.tsmRecruitItem.Text = "فرایند استخدام";
            this.tsmRecruitItem.Click += new System.EventHandler(this.tsmRecruitItem_Click);
            // 
            // tsmTrainingItem
            // 
            this.tsmTrainingItem.Name = "tsmTrainingItem";
            this.tsmTrainingItem.Size = new System.Drawing.Size(53, 20);
            this.tsmTrainingItem.Text = "آموزش";
            this.tsmTrainingItem.Click += new System.EventHandler(this.tsmTrainingItem_Click);
            // 
            // tsmProfileItem
            // 
            this.tsmProfileItem.Name = "tsmProfileItem";
            this.tsmProfileItem.Size = new System.Drawing.Size(101, 20);
            this.tsmProfileItem.Text = "تکمیل مشخصات";
            this.tsmProfileItem.Click += new System.EventHandler(this.tsmProfileItem_Click);
            // 
            // tsmEditResumeItem
            // 
            this.tsmEditResumeItem.Name = "tsmEditResumeItem";
            this.tsmEditResumeItem.Size = new System.Drawing.Size(85, 20);
            this.tsmEditResumeItem.Text = "ویرایش رزومه";
            this.tsmEditResumeItem.Click += new System.EventHandler(this.tsmEditResumeItem_Click);
            // 
            // tsmExitItem
            // 
            this.tsmExitItem.Name = "tsmExitItem";
            this.tsmExitItem.Size = new System.Drawing.Size(44, 20);
            this.tsmExitItem.Text = "خروج";
            this.tsmExitItem.Click += new System.EventHandler(this.tsmExitItem_Click);
            // 
            // ApplicantPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 338);
            this.Controls.Add(this.panelMenu);
            this.MainMenuStrip = this.panelMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ApplicantPanelForm";
            this.Text = "UserPanelForm";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip panelMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmRecruitItem;
        private System.Windows.Forms.ToolStripMenuItem tsmTrainingItem;
        private System.Windows.Forms.ToolStripMenuItem tsmProfileItem;
        private System.Windows.Forms.ToolStripMenuItem tsmEditResumeItem;
        private System.Windows.Forms.ToolStripMenuItem tsmExitItem;
    }
}