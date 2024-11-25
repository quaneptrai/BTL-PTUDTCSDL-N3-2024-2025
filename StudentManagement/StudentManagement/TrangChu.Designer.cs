namespace StudentManagement
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
            this.PMain = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PTrangChu = new System.Windows.Forms.PictureBox();
            this.Blbaocao = new System.Windows.Forms.Button();
            this.Bdstaikhoan = new System.Windows.Forms.Button();
            this.Bdshocsinh = new System.Windows.Forms.Button();
            this.TXTusername = new System.Windows.Forms.TextBox();
            this.LBsignout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Phienthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PMain)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTrangChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Phienthi
            // 
            this.Phienthi.Controls.Add(this.PMain);
            this.Phienthi.Location = new System.Drawing.Point(214, 72);
            this.Phienthi.Name = "Phienthi";
            this.Phienthi.Size = new System.Drawing.Size(943, 548);
            this.Phienthi.TabIndex = 0;
            this.Phienthi.Paint += new System.Windows.Forms.PaintEventHandler(this.Phienthi_Paint);
            // 
            // PMain
            // 
            this.PMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PMain.Image = ((System.Drawing.Image)(resources.GetObject("PMain.Image")));
            this.PMain.Location = new System.Drawing.Point(0, 0);
            this.PMain.Name = "PMain";
            this.PMain.Size = new System.Drawing.Size(943, 548);
            this.PMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PMain.TabIndex = 0;
            this.PMain.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PTrangChu);
            this.panel2.Controls.Add(this.Blbaocao);
            this.panel2.Controls.Add(this.Bdstaikhoan);
            this.panel2.Controls.Add(this.Bdshocsinh);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 620);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PTrangChu
            // 
            this.PTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("PTrangChu.Image")));
            this.PTrangChu.Location = new System.Drawing.Point(24, 6);
            this.PTrangChu.Name = "PTrangChu";
            this.PTrangChu.Size = new System.Drawing.Size(154, 129);
            this.PTrangChu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PTrangChu.TabIndex = 0;
            this.PTrangChu.TabStop = false;
            this.PTrangChu.Click += new System.EventHandler(this.PTrangChu_Click);
            // 
            // Blbaocao
            // 
            this.Blbaocao.FlatAppearance.BorderSize = 0;
            this.Blbaocao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blbaocao.Image = ((System.Drawing.Image)(resources.GetObject("Blbaocao.Image")));
            this.Blbaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Blbaocao.Location = new System.Drawing.Point(1, 405);
            this.Blbaocao.Name = "Blbaocao";
            this.Blbaocao.Size = new System.Drawing.Size(206, 48);
            this.Blbaocao.TabIndex = 4;
            this.Blbaocao.Text = "           Lập báo cáo";
            this.Blbaocao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Blbaocao.UseVisualStyleBackColor = true;
            this.Blbaocao.Click += new System.EventHandler(this.Blbaocao_Click);
            // 
            // Bdstaikhoan
            // 
            this.Bdstaikhoan.FlatAppearance.BorderSize = 0;
            this.Bdstaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bdstaikhoan.Image = ((System.Drawing.Image)(resources.GetObject("Bdstaikhoan.Image")));
            this.Bdstaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bdstaikhoan.Location = new System.Drawing.Point(-1, 300);
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
            this.Bdshocsinh.Location = new System.Drawing.Point(3, 186);
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
            this.TXTusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTusername.Location = new System.Drawing.Point(800, 6);
            this.TXTusername.Name = "TXTusername";
            this.TXTusername.Size = new System.Drawing.Size(111, 17);
            this.TXTusername.TabIndex = 0;
            this.TXTusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXTusername.TextChanged += new System.EventHandler(this.TXTusername_TextChanged);
            // 
            // LBsignout
            // 
            this.LBsignout.AutoSize = true;
            this.LBsignout.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LBsignout.Location = new System.Drawing.Point(821, 26);
            this.LBsignout.Name = "LBsignout";
            this.LBsignout.Size = new System.Drawing.Size(72, 17);
            this.LBsignout.TabIndex = 0;
            this.LBsignout.Text = "Đăng xuất";
            this.LBsignout.Click += new System.EventHandler(this.LBsignout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(736, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TXTusername);
            this.panel1.Controls.Add(this.LBsignout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(210, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 71);
            this.panel1.TabIndex = 1;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Phienthi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChu";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.Phienthi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PMain)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PTrangChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Phienthi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bdstaikhoan;
        private System.Windows.Forms.Button Bdshocsinh;
        private System.Windows.Forms.TextBox TXTusername;
        private System.Windows.Forms.Label LBsignout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Blbaocao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PTrangChu;
        private System.Windows.Forms.PictureBox PMain;
    }
}