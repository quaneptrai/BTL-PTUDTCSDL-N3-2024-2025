namespace StudentManagement
{
    partial class Danhsachlophoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTten = new System.Windows.Forms.TextBox();
            this.CBBlop = new System.Windows.Forms.ComboBox();
            this.Bxacnhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdanhsachlop)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVdanhsachlop
            // 
            this.DGVdanhsachlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdanhsachlop.Location = new System.Drawing.Point(-1, 1);
            this.DGVdanhsachlop.Name = "DGVdanhsachlop";
            this.DGVdanhsachlop.RowTemplate.Height = 24;
            this.DGVdanhsachlop.Size = new System.Drawing.Size(800, 240);
            this.DGVdanhsachlop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giáo Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lớp";
            // 
            // TXTten
            // 
            this.TXTten.Location = new System.Drawing.Point(349, 287);
            this.TXTten.Name = "TXTten";
            this.TXTten.Size = new System.Drawing.Size(198, 22);
            this.TXTten.TabIndex = 3;
            this.TXTten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CBBlop
            // 
            this.CBBlop.FormattingEnabled = true;
            this.CBBlop.Location = new System.Drawing.Point(349, 351);
            this.CBBlop.Name = "CBBlop";
            this.CBBlop.Size = new System.Drawing.Size(198, 24);
            this.CBBlop.TabIndex = 4;
            this.CBBlop.SelectedIndexChanged += new System.EventHandler(this.CBBlop_SelectedIndexChanged);
            // 
            // Bxacnhan
            // 
            this.Bxacnhan.Location = new System.Drawing.Point(384, 404);
            this.Bxacnhan.Name = "Bxacnhan";
            this.Bxacnhan.Size = new System.Drawing.Size(105, 23);
            this.Bxacnhan.TabIndex = 5;
            this.Bxacnhan.Text = "Xác Nhận";
            this.Bxacnhan.UseVisualStyleBackColor = true;
            this.Bxacnhan.Click += new System.EventHandler(this.Bxacnhan_Click);
            // 
            // Danhsachlophoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bxacnhan);
            this.Controls.Add(this.CBBlop);
            this.Controls.Add(this.TXTten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVdanhsachlop);
            this.Name = "Danhsachlophoc";
            this.Text = "Danhsachlophoc";
            this.Load += new System.EventHandler(this.Danhsachlophoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdanhsachlop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVdanhsachlop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTten;
        private System.Windows.Forms.ComboBox CBBlop;
        private System.Windows.Forms.Button Bxacnhan;
    }
}