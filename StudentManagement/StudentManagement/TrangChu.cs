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
    public partial class TrangChu : Form
    {
        public TrangChu(string username)
        {
            InitializeComponent();
            TXTusername.Text = username;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Thoat);
        }
        private Form curentformchild;
        private void OpenChildForm(Form childform)
        {
            if (curentformchild != null)
            {
                curentformchild.Close();
            }
            curentformchild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            Phienthi.Controls.Add(childform);
            Phienthi.BringToFront();
            childform.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            string username = TXTusername.Text;
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-EDAASRI2\\SQLEXPRESS;Initial Catalog=BTL;User ID=sa;Password=585810Qu@n");
            con.Open();
            string querry = "SELECT Chucvu FROM Taikhoan where Tendangnhap=@username";
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.Parameters.AddWithValue("@username", username);
            object result = cmd.ExecuteScalar();
            if (result != null && result.ToString() == "manager")
            {
                Bdstaikhoan.Enabled = true;
                Bcshocsinh.Enabled = true;
                Bcstaikhoan.Enabled = true;
            }
            else
            {
                Bdstaikhoan.Enabled = false;
                Bdstaikhoan.ForeColor = Color.Gray;
                Bdstaikhoan.Enabled = false;
                Bcstaikhoan.ForeColor = Color.Gray;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LBsignout_Click(object sender, EventArgs e)
        {
            Login form1 = new Login();
            form1.Show();
            this.Close();
        }
        private void Thoat(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Login form1 = new Login();
                form1.Show();
            }
        }

        private void Bdshocsinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Danhsachhocsinh());
        }

        private void Bdstaikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Danhsachtaikhoan());
        }

        private void Bcshocsinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChinhSuahocsinh());
        }

        private void Bcstaikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Chinhsuataikhoan());
        }

        private void Blbaocao_Click(object sender, EventArgs e)
        {
            string username = TXTusername.Text;
            Lapbaocao form5 = new Lapbaocao(username);
            OpenChildForm(new Lapbaocao(username));
        }
    }
}
