﻿namespace RecruitmentSystem.UI
{
    partial class MyOfferInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.btnChoose = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "btnBack";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRequests
            // 
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnChoose});
            this.dgvRequests.Location = new System.Drawing.Point(27, 51);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.RowTemplate.Height = 25;
            this.dgvRequests.Size = new System.Drawing.Size(477, 234);
            this.dgvRequests.TabIndex = 1;
            // 
            // btnChoose
            // 
            this.btnChoose.HeaderText = "Choose";
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseColumnTextForButtonValue = true;
            // 
            // MyOfferInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 356);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.button1);
            this.Name = "MyOfferInfo";
            this.Text = "MyOfferInfo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.DataGridViewButtonColumn btnChoose;
    }
}