using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class v : Form
    {
        int luachon=0;
        string tdn;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-EDAASRI2\\SQLEXPRESS;Initial Catalog=BTL;User ID=sa;Password=585810Qu@n");

        public v(string username)
        {
            InitializeComponent();
            tdn = username;
            LBgreeitng.Text = "Xin chào" + " " + username + " " + "!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LBgreeitng_Click(object sender, EventArgs e)
        {

        }

        private void RBdslop_CheckedChanged(object sender, EventArgs e)
        {
            luachon = 1;
        }

      

        private void Bxacnhan_Click(object sender, EventArgs e)
        {
            if(luachon == 0)
            {
                MessageBox.Show("Xin mời chọn loại báo cáo cần lập !", "Xin hãy chọn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(luachon == 1)
            {
                Form form1 = new Danhsachlophoc(tdn);
                form1.Show();
;           }
            if(luachon == 3)
            {
                Form form3 = new ThongTinGiaoVien(tdn);
                form3.Show();
            }
                
        }

        private void v_Load(object sender, EventArgs e)
        {

        }

        private void RBbctk_CheckedChanged(object sender, EventArgs e)
        {
            luachon = 2;
        }

        private void RBhocsinh_CheckedChanged(object sender, EventArgs e)
        {
            luachon = 3;
        }
    }
}