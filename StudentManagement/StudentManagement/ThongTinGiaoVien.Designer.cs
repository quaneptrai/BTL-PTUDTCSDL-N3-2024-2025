﻿namespace StudentManagement
{
    partial class ThongTinGiaoVien
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
            this.TXTGiaoVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CCBlop = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giáo Viên";
            // 
            // TXTGiaoVien
            // 
            this.TXTGiaoVien.Location = new System.Drawing.Point(347, 145);
            this.TXTGiaoVien.Name = "TXTGiaoVien";
            this.TXTGiaoVien.Size = new System.Drawing.Size(197, 22);
            this.TXTGiaoVien.TabIndex = 1;
            this.TXTGiaoVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp";
            // 
            // CCBlop
            // 
            this.CCBlop.FormattingEnabled = true;
            this.CCBlop.Location = new System.Drawing.Point(347, 221);
            this.CCBlop.Name = "CCBlop";
            this.CCBlop.Size = new System.Drawing.Size(197, 24);
            this.CCBlop.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ThongTinGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CCBlop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTGiaoVien);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinGiaoVien";
            this.Text = "Lớp";
            this.Load += new System.EventHandler(this.ThongTinGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTGiaoVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CCBlop;
        private System.Windows.Forms.Button button1;
    }
}