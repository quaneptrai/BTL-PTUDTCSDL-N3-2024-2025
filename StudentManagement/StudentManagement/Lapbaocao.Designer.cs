namespace StudentManagement
{
    partial class Lapbaocao
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
            this.TXTten = new System.Windows.Forms.TextBox();
            this.Bxuat = new System.Windows.Forms.Button();
            this.CBBLopHoc = new System.Windows.Forms.ComboBox();
            this.LBgiaovien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TXTten
            // 
            this.TXTten.Location = new System.Drawing.Point(396, 186);
            this.TXTten.Name = "TXTten";
            this.TXTten.Size = new System.Drawing.Size(207, 22);
            this.TXTten.TabIndex = 0;
            this.TXTten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bxuat
            // 
            this.Bxuat.Location = new System.Drawing.Point(445, 310);
            this.Bxuat.Name = "Bxuat";
            this.Bxuat.Size = new System.Drawing.Size(88, 23);
            this.Bxuat.TabIndex = 1;
            this.Bxuat.Text = "Xuất";
            this.Bxuat.UseVisualStyleBackColor = true;
            this.Bxuat.Click += new System.EventHandler(this.Bxuat_Click);
            // 
            // CBBLopHoc
            // 
            this.CBBLopHoc.FormattingEnabled = true;
            this.CBBLopHoc.Location = new System.Drawing.Point(396, 241);
            this.CBBLopHoc.Name = "CBBLopHoc";
            this.CBBLopHoc.Size = new System.Drawing.Size(207, 24);
            this.CBBLopHoc.TabIndex = 2;
            this.CBBLopHoc.SelectedIndexChanged += new System.EventHandler(this.CBBLopHoc_SelectedIndexChanged);
            // 
            // LBgiaovien
            // 
            this.LBgiaovien.AutoSize = true;
            this.LBgiaovien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBgiaovien.Location = new System.Drawing.Point(207, 121);
            this.LBgiaovien.Name = "LBgiaovien";
            this.LBgiaovien.Size = new System.Drawing.Size(77, 17);
            this.LBgiaovien.TabIndex = 4;
            this.LBgiaovien.Text = "Giáo viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lớp học";
            // 
            // Lapbaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBgiaovien);
            this.Controls.Add(this.CBBLopHoc);
            this.Controls.Add(this.Bxuat);
            this.Controls.Add(this.TXTten);
            this.Name = "Lapbaocao";
            this.Text = "Lapbaocao";
            this.Load += new System.EventHandler(this.Lapbaocao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTten;
        private System.Windows.Forms.Button Bxuat;
        private System.Windows.Forms.ComboBox CBBLopHoc;
        private System.Windows.Forms.Label LBgiaovien;
        private System.Windows.Forms.Label label2;
    }
}