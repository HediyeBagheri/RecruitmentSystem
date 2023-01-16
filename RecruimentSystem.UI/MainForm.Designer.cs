namespace RecruitmentSystem.UI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSignUser = new System.Windows.Forms.Button();
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rec";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable2.Location = new System.Drawing.Point(264, 104);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(100, 67);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "Sys";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(195, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "ruitment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(337, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "tem";
            // 
            // BtnSignUser
            // 
            this.BtnSignUser.Location = new System.Drawing.Point(179, 285);
            this.BtnSignUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSignUser.Name = "BtnSignUser";
            this.BtnSignUser.Size = new System.Drawing.Size(126, 59);
            this.BtnSignUser.TabIndex = 0;
            this.BtnSignUser.Text = "Sign In As User";
            this.BtnSignUser.UseVisualStyleBackColor = true;
            this.BtnSignUser.Click += new System.EventHandler(this.BtnSignUser_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Location = new System.Drawing.Point(179, 367);
            this.BtnAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(126, 59);
            this.BtnAdmin.TabIndex = 1;
            this.BtnAdmin.Text = "Sign In As Admin";
            this.BtnAdmin.UseVisualStyleBackColor = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Location = new System.Drawing.Point(179, 480);
            this.BtnSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(126, 59);
            this.BtnSignUp.TabIndex = 2;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Don\'t Have An Account Yet? ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.BtnSignUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSignUser;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Label label2;
    }
}