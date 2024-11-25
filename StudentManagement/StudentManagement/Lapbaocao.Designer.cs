namespace StudentManagement
{
    partial class v
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
            this.LBgreetin = new System.Windows.Forms.Label();
            this.Bxacnhan = new System.Windows.Forms.Button();
            this.LBgreeitng = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RBdslop = new System.Windows.Forms.RadioButton();
            this.RBhocsinh = new System.Windows.Forms.RadioButton();
            this.RBbctk = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LBgreetin
            // 
            this.LBgreetin.AutoSize = true;
            this.LBgreetin.Location = new System.Drawing.Point(227, 69);
            this.LBgreetin.Name = "LBgreetin";
            this.LBgreetin.Size = new System.Drawing.Size(0, 17);
            this.LBgreetin.TabIndex = 0;
            // 
            // Bxacnhan
            // 
            this.Bxacnhan.Location = new System.Drawing.Point(414, 364);
            this.Bxacnhan.Name = "Bxacnhan";
            this.Bxacnhan.Size = new System.Drawing.Size(84, 32);
            this.Bxacnhan.TabIndex = 2;
            this.Bxacnhan.Text = "Xác nhận";
            this.Bxacnhan.UseVisualStyleBackColor = true;
            this.Bxacnhan.Click += new System.EventHandler(this.Bxacnhan_Click);
            // 
            // LBgreeitng
            // 
            this.LBgreeitng.AutoSize = true;
            this.LBgreeitng.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBgreeitng.Location = new System.Drawing.Point(284, 96);
            this.LBgreeitng.Name = "LBgreeitng";
            this.LBgreeitng.Size = new System.Drawing.Size(377, 46);
            this.LBgreeitng.TabIndex = 3;
            this.LBgreeitng.Text = "XIN CHÀO QUAN !";
            this.LBgreeitng.Click += new System.EventHandler(this.LBgreeitng_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mời chọn loại báo cáo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RBdslop
            // 
            this.RBdslop.AutoSize = true;
            this.RBdslop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBdslop.Location = new System.Drawing.Point(370, 207);
            this.RBdslop.Name = "RBdslop";
            this.RBdslop.Size = new System.Drawing.Size(171, 29);
            this.RBdslop.TabIndex = 5;
            this.RBdslop.TabStop = true;
            this.RBdslop.Text = "Danh sách lớp";
            this.RBdslop.UseVisualStyleBackColor = true;
            this.RBdslop.CheckedChanged += new System.EventHandler(this.RBdslop_CheckedChanged);
            // 
            // RBhocsinh
            // 
            this.RBhocsinh.AutoSize = true;
            this.RBhocsinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBhocsinh.Location = new System.Drawing.Point(369, 320);
            this.RBhocsinh.Name = "RBhocsinh";
            this.RBhocsinh.Size = new System.Drawing.Size(211, 29);
            this.RBhocsinh.TabIndex = 6;
            this.RBhocsinh.TabStop = true;
            this.RBhocsinh.Text = "Thông tin học sinh";
            this.RBhocsinh.UseVisualStyleBackColor = true;
            this.RBhocsinh.CheckedChanged += new System.EventHandler(this.RBhocsinh_CheckedChanged);
            // 
            // RBbctk
            // 
            this.RBbctk.AutoSize = true;
            this.RBbctk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBbctk.Location = new System.Drawing.Point(370, 261);
            this.RBbctk.Name = "RBbctk";
            this.RBbctk.Size = new System.Drawing.Size(212, 30);
            this.RBbctk.TabIndex = 7;
            this.RBbctk.TabStop = true;
            this.RBbctk.Text = "Báo cáo tổng kết";
            this.RBbctk.UseVisualStyleBackColor = true;
            this.RBbctk.CheckedChanged += new System.EventHandler(this.RBbctk_CheckedChanged);
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 486);
            this.Controls.Add(this.RBbctk);
            this.Controls.Add(this.RBhocsinh);
            this.Controls.Add(this.RBdslop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBgreeitng);
            this.Controls.Add(this.Bxacnhan);
            this.Controls.Add(this.LBgreetin);
            this.Name = "v";
            this.Text = "Lapbaocao";
            this.Load += new System.EventHandler(this.v_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBgreetin;
        private System.Windows.Forms.Button Bxacnhan;
        private System.Windows.Forms.Label LBgreeitng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBdslop;
        private System.Windows.Forms.RadioButton RBhocsinh;
        private System.Windows.Forms.RadioButton RBbctk;
    }
}