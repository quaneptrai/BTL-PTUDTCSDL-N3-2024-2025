namespace StudentManagement
{
    partial class DanhSachLop
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
            this.DGVdanhsachlop = new System.Windows.Forms.DataGridView();
            this.CBBlop = new System.Windows.Forms.ComboBox();
            this.Llop = new System.Windows.Forms.Label();
            this.Bthem = new System.Windows.Forms.Button();
            this.Bxoa = new System.Windows.Forms.Button();
            this.Bsua = new System.Windows.Forms.Button();
            this.Bxacnhan = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.TXTusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdanhsachlop)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVdanhsachlop
            // 
            this.DGVdanhsachlop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVdanhsachlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdanhsachlop.Location = new System.Drawing.Point(1, -2);
            this.DGVdanhsachlop.Name = "DGVdanhsachlop";
            this.DGVdanhsachlop.RowTemplate.Height = 24;
            this.DGVdanhsachlop.Size = new System.Drawing.Size(883, 271);
            this.DGVdanhsachlop.TabIndex = 0;
            // 
            // CBBlop
            // 
            this.CBBlop.FormattingEnabled = true;
            this.CBBlop.Location = new System.Drawing.Point(123, 375);
            this.CBBlop.Name = "CBBlop";
            this.CBBlop.Size = new System.Drawing.Size(238, 24);
            this.CBBlop.TabIndex = 1;
            this.CBBlop.SelectedIndexChanged += new System.EventHandler(this.CBBlop_SelectedIndexChanged);
            // 
            // Llop
            // 
            this.Llop.AutoSize = true;
            this.Llop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llop.Location = new System.Drawing.Point(12, 371);
            this.Llop.Name = "Llop";
            this.Llop.Size = new System.Drawing.Size(48, 25);
            this.Llop.TabIndex = 3;
            this.Llop.Text = "Lớp";
            // 
            // Bthem
            // 
            this.Bthem.Location = new System.Drawing.Point(378, 335);
            this.Bthem.Name = "Bthem";
            this.Bthem.Size = new System.Drawing.Size(75, 23);
            this.Bthem.TabIndex = 5;
            this.Bthem.Text = "Thêm";
            this.Bthem.UseVisualStyleBackColor = true;
            // 
            // Bxoa
            // 
            this.Bxoa.Location = new System.Drawing.Point(482, 335);
            this.Bxoa.Name = "Bxoa";
            this.Bxoa.Size = new System.Drawing.Size(75, 23);
            this.Bxoa.TabIndex = 6;
            this.Bxoa.Text = "Xóa";
            this.Bxoa.UseVisualStyleBackColor = true;
            // 
            // Bsua
            // 
            this.Bsua.Location = new System.Drawing.Point(378, 379);
            this.Bsua.Name = "Bsua";
            this.Bsua.Size = new System.Drawing.Size(75, 23);
            this.Bsua.TabIndex = 7;
            this.Bsua.Text = "Sửa";
            this.Bsua.UseVisualStyleBackColor = true;
            // 
            // Bxacnhan
            // 
            this.Bxacnhan.Location = new System.Drawing.Point(120, 428);
            this.Bxacnhan.Name = "Bxacnhan";
            this.Bxacnhan.Size = new System.Drawing.Size(88, 31);
            this.Bxacnhan.TabIndex = 8;
            this.Bxacnhan.Text = "Xác Nhận";
            this.Bxacnhan.UseVisualStyleBackColor = true;
            this.Bxacnhan.Click += new System.EventHandler(this.Bxacnhan_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 428);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "Hủy";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // TXTusername
            // 
            this.TXTusername.Location = new System.Drawing.Point(123, 335);
            this.TXTusername.Name = "TXTusername";
            this.TXTusername.Size = new System.Drawing.Size(241, 22);
            this.TXTusername.TabIndex = 10;
            this.TXTusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giáo Viên";
            // 
            // DanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTusername);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Bxacnhan);
            this.Controls.Add(this.Bsua);
            this.Controls.Add(this.Bxoa);
            this.Controls.Add(this.Bthem);
            this.Controls.Add(this.Llop);
            this.Controls.Add(this.CBBlop);
            this.Controls.Add(this.DGVdanhsachlop);
            this.Name = "DanhSachLop";
            this.Text = "DanhSachLop";
            this.Load += new System.EventHandler(this.DanhSachLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdanhsachlop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVdanhsachlop;
        private System.Windows.Forms.ComboBox CBBlop;
        private System.Windows.Forms.Label Llop;
        private System.Windows.Forms.Button Bthem;
        private System.Windows.Forms.Button Bxoa;
        private System.Windows.Forms.Button Bsua;
        private System.Windows.Forms.Button Bxacnhan;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox TXTusername;
        private System.Windows.Forms.Label label1;
    }
}