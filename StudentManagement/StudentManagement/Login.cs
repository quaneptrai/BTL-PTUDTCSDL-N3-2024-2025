using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer;
namespace StudentManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Thoat);

        }

        private void Blogin_Click(object sender, EventArgs e)
        {
            if (TXTusername.Text == String.Empty)
            {
                TXTusername.Focus();
                LoiKhongNhapTenNguoiDung.SetError(TXTusername, "Tên đăng nhập không được để trống!");
            }
            if (TXTpassword.Text == String.Empty)
            {
                TXTusername.Focus();
                LoiKhongNhapMatKhau.SetError(TXTpassword, "Mật khẩu không được để trống!");
            }
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-EDAASRI2\\SQLEXPRESS;Initial Catalog=BTL;User ID=sa;Password=585810Qu@n");
            con.Open();
            string querry = ("SELECT COUNT(*) FROM Taikhoan WHERE TenDangNhap=@username AND MatKhau=@password");
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@username", TXTusername.Text);
            cmd.Parameters.AddWithValue("@password", TXTpassword.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                string username = TXTusername.Text;
                TrangChu form1 = new TrangChu(username);
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!","Tài khoản không tồn tại",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void Thoat(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

