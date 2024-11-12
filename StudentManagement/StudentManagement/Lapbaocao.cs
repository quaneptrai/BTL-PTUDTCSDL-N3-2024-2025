using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Lapbaocao : Form
    {
        int SySoCuoiNam;
        string LopHoc;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-EDAASRI2\\SQLEXPRESS;Initial Catalog=BTL;User ID=sa;Password=585810Qu@n");

        public Lapbaocao(string username)
        {
            InitializeComponent();
            TXTten.Text = username;
        }

        private void Lapbaocao_Load(object sender, EventArgs e)
        {
            try
            {
                // Correct the SQL query syntax, adding spaces between clauses
                SqlCommand cmd = new SqlCommand("SELECT TenLop FROM LopHoc lh " +
                                                 "INNER JOIN GiaoVien gv " +
                                                 "ON gv.MaLop = lh.MaLop " +
                                                 "WHERE gv.TenGiaoVien = @username", con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", TXTten.Text);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CBBLopHoc.Items.Add(reader["TenLop"].ToString());
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void CBBLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LopHoc = CBBLopHoc.SelectedItem.ToString();
        }

        private void Bxuat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LopHoc))
            {
                MessageBox.Show("Please select a TenLop from the ComboBox.");
                return;
            }

            // Fix SQL syntax by adding space before 'FROM' and 'WHERE'
            SqlCommand cmd1 = new SqlCommand("SELECT SySoLopDauNam - SySoLopCuoiNam AS SySoCuoiNam " +
                                             "FROM LopHoc " +
                                             "WHERE TenLop = @TenLop", con);
            cmd1.Parameters.AddWithValue("@TenLop", LopHoc);

            try
            {
                con.Open();
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.Read())
                {
                    SySoCuoiNam = Convert.ToInt32(reader["SySoCuoiNam"]);
                    MessageBox.Show("SySoLop thay doi =" + SySoCuoiNam);
                }
                else
                {
                    MessageBox.Show("No data found for the selected LopHoc.");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving SySoCuoiNam: " + ex.Message);
            }
        }
    }
}
