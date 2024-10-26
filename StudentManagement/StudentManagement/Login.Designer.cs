namespace StudentManagement
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TXTusername = new System.Windows.Forms.TextBox();
            this.LBusername = new System.Windows.Forms.Label();
            this.LBpassword = new System.Windows.Forms.Label();
            this.TXTpassword = new System.Windows.Forms.TextBox();
            this.Blogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBfpass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTusername
            // 
            this.TXTusername.Location = new System.Drawing.Point(390, 253);
            this.TXTusername.Name = "TXTusername";
            this.TXTusername.Size = new System.Drawing.Size(185, 22);
            this.TXTusername.TabIndex = 0;
            // 
            // LBusername
            // 
            this.LBusername.AutoSize = true;
            this.LBusername.BackColor = System.Drawing.Color.White;
            this.LBusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBusername.Location = new System.Drawing.Point(293, 258);
            this.LBusername.Name = "LBusername";
            this.LBusername.Size = new System.Drawing.Size(91, 17);
            this.LBusername.TabIndex = 1;
            this.LBusername.Text = "Người dùng";
            // 
            // LBpassword
            // 
            this.LBpassword.AutoSize = true;
            this.LBpassword.BackColor = System.Drawing.Color.White;
            this.LBpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBpassword.Location = new System.Drawing.Point(293, 303);
            this.LBpassword.Name = "LBpassword";
            this.LBpassword.Size = new System.Drawing.Size(74, 17);
            this.LBpassword.TabIndex = 2;
            this.LBpassword.Text = "Mật khẩu";
            // 
            // TXTpassword
            // 
            this.TXTpassword.Location = new System.Drawing.Point(390, 298);
            this.TXTpassword.Name = "TXTpassword";
            this.TXTpassword.Size = new System.Drawing.Size(185, 22);
            this.TXTpassword.TabIndex = 3;
            // 
            // Blogin
            // 
            this.Blogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blogin.Location = new System.Drawing.Point(418, 340);
            this.Blogin.Name = "Blogin";
            this.Blogin.Size = new System.Drawing.Size(109, 27);
            this.Blogin.TabIndex = 4;
            this.Blogin.Text = "Đăng Nhập";
            this.Blogin.UseVisualStyleBackColor = true;
            this.Blogin.Click += new System.EventHandler(this.Blogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(922, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LBfpass
            // 
            this.LBfpass.AutoSize = true;
            this.LBfpass.BackColor = System.Drawing.Color.White;
            this.LBfpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBfpass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LBfpass.Location = new System.Drawing.Point(403, 389);
            this.LBfpass.Name = "LBfpass";
            this.LBfpass.Size = new System.Drawing.Size(136, 20);
            this.LBfpass.TabIndex = 6;
            this.LBfpass.Text = "Quên mật khẩu ?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 495);
            this.Controls.Add(this.LBfpass);
            this.Controls.Add(this.Blogin);
            this.Controls.Add(this.TXTpassword);
            this.Controls.Add(this.LBpassword);
            this.Controls.Add(this.LBusername);
            this.Controls.Add(this.TXTusername);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTusername;
        private System.Windows.Forms.Label LBusername;
        private System.Windows.Forms.Label LBpassword;
        private System.Windows.Forms.TextBox TXTpassword;
        private System.Windows.Forms.Button Blogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBfpass;
    }
}

