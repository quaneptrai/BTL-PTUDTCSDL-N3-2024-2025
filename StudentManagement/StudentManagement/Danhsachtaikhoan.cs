using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;

namespace StudentManagement
{
    public partial class Danhsachtaikhoan : Form
    {
        public Danhsachtaikhoan()
        {
            InitializeComponent();
        }
        String connectionString = @"Data Source=LAPTOP-EDAASRI2\\SQLEXPRESS;Initial Catalog=BTL;User ID=sa;Password=585810Qu@n";
        private DataTable getData(String query)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();
                var dt = new DataTable();
                var da = new SqlDataAdapter(com);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
        }
        private bool excute(String query)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var com = new SqlCommand(query, conn);
                com.ExecuteNonQuery();
                conn.Close();
                return true;
            }
        }
        private void Danhsachtaikhoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getData("SELECT TenDangNhap,TenUser,ChucDanh FROM TaiKhoan");
        }
    }
}
