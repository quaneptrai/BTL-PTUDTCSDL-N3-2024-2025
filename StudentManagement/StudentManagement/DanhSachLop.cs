using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace StudentManagement
{
    public partial class DanhSachLop : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-EDAASRI2\\SQLEXPRESS;Initial Catalog=BTL;User ID=sa;Password=585810Qu@n");
        string tdn;
        private void DanhSachLop_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT lh.MaLop, lh.TenLop FROM GiaoVien_LopHoc gvlh " +
                                                "INNER JOIN GiaoVien gv " +
                                                "ON gv.MaGiaoVien = gvlh.MaGiaoVien " +
                                                "INNER JOIN LopHoc lh " +
                                                "ON lh.MaLop = gvlh.MaLop " +
                                                "WHERE gv.TenGiaoVien = @username",con);

                cmd.Parameters.AddWithValue("@username", tdn);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Add KeyValuePair<int, string> to the ComboBox
                        CBBlop.Items.Add(new KeyValuePair<int, string>(
                            Convert.ToInt32(reader["MaLop"]),
                            reader["TenLop"].ToString()));
                    }
                }

                con.Close();

                // Ensure the ComboBox shows the `Value` (TenLop) to the user
                CBBlop.DisplayMember = "Value"; // `Value` is the TenLop
                CBBlop.ValueMember = "Key";    // `Key` is the MaLop
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public DanhSachLop(string username)
        {
            InitializeComponent();
            tdn = username;
            TXTusername.Text = tdn;
        }

        private void CBBlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBBlop.SelectedItem != null)
            {
                int malop = ((KeyValuePair<int, string>)CBBlop.SelectedItem).Key;
                SqlCommand com = new SqlCommand("SELECT hs.TenHocSinh AS HoTen, hs.GioiTinh, hs.NgaySinh, lh.TenLop " +
                                                "FROM HocSinh hs " +
                                                "INNER JOIN LopHoc lh " +
                                                "ON hs.MaLop = lh.MaLop " +
                                                "WHERE hs.MaLop = @malop", con);
                com.Parameters.AddWithValue("@malop", malop);

                SqlDataAdapter sda = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DGVdanhsachlop.DataSource = dt;
            }
        }

        private void Bxacnhan_Click(object sender, EventArgs e)
        {
            if (DGVdanhsachlop.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu về lớp.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i <= DGVdanhsachlop.Columns.Count; i++)
                {
                    excelApp.Cells[1, i] = DGVdanhsachlop.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < DGVdanhsachlop.Rows.Count; i++)
                {
                    for (int j = 0; j < DGVdanhsachlop.Columns.Count; j++)
                    {
                        var cellValue = DGVdanhsachlop.Rows[i].Cells[j].Value;
                        excelApp.Cells[i + 2, j + 1] = cellValue == null ? "" : cellValue.ToString();
                    }
                }

                excelApp.Columns.AutoFit();
                excelApp.Visible = true;
                MessageBox.Show("Xuất file thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xuất file gặp lỗisss: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
 }
