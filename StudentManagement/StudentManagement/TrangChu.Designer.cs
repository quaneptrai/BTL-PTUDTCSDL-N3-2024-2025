﻿namespace StudentManagement
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.Phienthi = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bcstaikhoan = new System.Windows.Forms.Button();
            this.Bcshocsinh = new System.Windows.Forms.Button();
            this.Bdstaikhoan = new System.Windows.Forms.Button();
            this.Bdshocsinh = new System.Windows.Forms.Button();
            this.TXTusername = new System.Windows.Forms.TextBox();
            this.LBsignout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Blbaocao = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Phienthi
            // 
            this.Phienthi.Location = new System.Drawing.Point(210, 1);
            this.Phienthi.Name = "Phienthi";
            this.Phienthi.Size = new System.Drawing.Size(916, 583);
            this.Phienthi.TabIndex = 0;
            this.Phienthi.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Blbaocao);
            this.panel2.Controls.Add(this.Bcstaikhoan);
            this.panel2.Controls.Add(this.Bcshocsinh);
            this.panel2.Controls.Add(this.Bdstaikhoan);
            this.panel2.Controls.Add(this.Bdshocsinh);
            this.panel2.Controls.Add(this.TXTusername);
            this.panel2.Controls.Add(this.LBsignout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 584);
            this.panel2.TabIndex = 0;
            // 
            // Bcstaikhoan
            // 
            this.Bcstaikhoan.FlatAppearance.BorderSize = 0;
            this.Bcstaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcstaikhoan.Image = ((System.Drawing.Image)(resources.GetObject("Bcstaikhoan.Image")));
            this.Bcstaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcstaikhoan.Location = new System.Drawing.Point(1, 376);
            this.Bcstaikhoan.Name = "Bcstaikhoan";
            this.Bcstaikhoan.Size = new System.Drawing.Size(206, 48);
            this.Bcstaikhoan.TabIndex = 3;
            this.Bcstaikhoan.Text = "           Chỉnh sửa tài khoản";
            this.Bcstaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcstaikhoan.UseVisualStyleBackColor = true;
            this.Bcstaikhoan.Click += new System.EventHandler(this.Bcstaikhoan_Click);
            // 
            // Bcshocsinh
            // 
            this.Bcshocsinh.FlatAppearance.BorderSize = 0;
            this.Bcshocsinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcshocsinh.Image = ((System.Drawing.Image)(resources.GetObject("Bcshocsinh.Image")));
            this.Bcshocsinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcshocsinh.Location = new System.Drawing.Point(0, 304);
            this.Bcshocsinh.Name = "Bcshocsinh";
            this.Bcshocsinh.Size = new System.Drawing.Size(206, 48);
            this.Bcshocsinh.TabIndex = 2;
            this.Bcshocsinh.Text = "           Chỉnh sửa học sinh";
            this.Bcshocsinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcshocsinh.UseVisualStyleBackColor = true;
            this.Bcshocsinh.Click += new System.EventHandler(this.Bcshocsinh_Click);
            // 
            // Bdstaikhoan
            // 
            this.Bdstaikhoan.FlatAppearance.BorderSize = 0;
            this.Bdstaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bdstaikhoan.Image = ((System.Drawing.Image)(resources.GetObject("Bdstaikhoan.Image")));
            this.Bdstaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bdstaikhoan.Location = new System.Drawing.Point(0, 233);
            this.Bdstaikhoan.Name = "Bdstaikhoan";
            this.Bdstaikhoan.Size = new System.Drawing.Size(206, 48);
            this.Bdstaikhoan.TabIndex = 1;
            this.Bdstaikhoan.Text = "           Danh sách tài khoản";
            this.Bdstaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bdstaikhoan.UseVisualStyleBackColor = true;
            this.Bdstaikhoan.Click += new System.EventHandler(this.Bdstaikhoan_Click);
            // 
            // Bdshocsinh
            // 
            this.Bdshocsinh.FlatAppearance.BorderSize = 0;
            this.Bdshocsinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bdshocsinh.Image = ((System.Drawing.Image)(resources.GetObject("Bdshocsinh.Image")));
            this.Bdshocsinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bdshocsinh.Location = new System.Drawing.Point(3, 166);
            this.Bdshocsinh.Name = "Bdshocsinh";
            this.Bdshocsinh.Size = new System.Drawing.Size(206, 48);
            this.Bdshocsinh.TabIndex = 0;
            this.Bdshocsinh.Text = "           Danh sách học sinh";
            this.Bdshocsinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bdshocsinh.UseVisualStyleBackColor = true;
            this.Bdshocsinh.Click += new System.EventHandler(this.Bdshocsinh_Click);
            // 
            // TXTusername
            // 
            this.TXTusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXTusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTusername.Location = new System.Drawing.Point(93, 27);
            this.TXTusername.Name = "TXTusername";
            this.TXTusername.Size = new System.Drawing.Size(111, 17);
            this.TXTusername.TabIndex = 0;
            this.TXTusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBsignout
            // 
            this.LBsignout.AutoSize = true;
            this.LBsignout.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBsignout.Location = new System.Drawing.Point(111, 63);
            this.LBsignout.Name = "LBsignout";
            this.LBsignout.Size = new System.Drawing.Size(72, 17);
            this.LBsignout.TabIndex = 0;
            this.LBsignout.Text = "Đăng xuất";
            this.LBsignout.Click += new System.EventHandler(this.LBsignout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Blbaocao
            // 
            this.Blbaocao.FlatAppearance.BorderSize = 0;
            this.Blbaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blbaocao.Image = ((System.Drawing.Image)(resources.GetObject("Blbaocao.Image")));
            this.Blbaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Blbaocao.Location = new System.Drawing.Point(1, 452);
            this.Blbaocao.Name = "Blbaocao";
            this.Blbaocao.Size = new System.Drawing.Size(206, 48);
            this.Blbaocao.TabIndex = 4;
            this.Blbaocao.Text = "           Lập báo cáo";
            this.Blbaocao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Blbaocao.UseVisualStyleBackColor = true;
            this.Blbaocao.Click += new System.EventHandler(this.Blbaocao_Click);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Phienthi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Phienthi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bcstaikhoan;
        private System.Windows.Forms.Button Bcshocsinh;
        private System.Windows.Forms.Button Bdstaikhoan;
        private System.Windows.Forms.Button Bdshocsinh;
        private System.Windows.Forms.TextBox TXTusername;
        private System.Windows.Forms.Label LBsignout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Blbaocao;
    }
}