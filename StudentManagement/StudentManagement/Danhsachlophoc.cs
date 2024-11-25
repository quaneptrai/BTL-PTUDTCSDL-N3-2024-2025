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
using Excel = Microsoft.Office.Interop.Excel;

namespace StudentManagement
{
    public partial class Danhsachlophoc : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-EDAASRI2\\SQLEXPRESS;Initial Catalog=BTL;User ID=sa;Password=585810Qu@n");
        string tdn;
        public Danhsachlophoc(string username)
        {
            InitializeComponent();
            tdn = username;
            TXTten.Text = tdn;
        }

        private void Danhsachlophoc_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select lh.TenLop from LopHoc lh " +
                                            "Inner join GiaoVien_LopHoc gvlh on gvlh.MaLop = lh.MaLop " +
                                            "Inner join GiaoVien gv on gv.MaGiaoVien = gvlh.MaGiaoVien " +
                                            "where gv.TenGiaoVien = @username ", con);
            com.Parameters.AddWithValue("@username", tdn);
            con.Open();
            using (SqlDataReader reader = com.ExecuteReader())
            {
                CBBlop.Items.Clear();
                while (reader.Read())
                {
                    CBBlop.Items.Add(reader["TenLop"].ToString());
                }
            }
            con.Close();
        }

        private void Bxacnhan_Click(object sender, EventArgs e)
        {
            if (DGVdanhsachlop.Rows.Count > 0)
            {
                try
                {
                    Excel.Application App = new Excel.Application();
                    App.Visible = true;
                    Excel.Workbook workbook = App.Workbooks.Add();
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
                    for (int col = 0; col < DGVdanhsachlop.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1] = DGVdanhsachlop.Columns[col].HeaderText;
                    }
                    for (int row = 0; row < DGVdanhsachlop.Rows.Count; row++)
                    {
                        for (int col = 0; col < DGVdanhsachlop.Columns.Count; col++)
                        {
                            var cellValue = DGVdanhsachlop.Rows[row].Cells[col].Value.ToString();
                            worksheet.Cells[row + 2, col + 1] = cellValue;
                            if (DGVdanhsachlop.Columns[col].HeaderText == "NgaySinh")
                            {
                                worksheet.Cells[row + 2, col + 1].NumberFormat = "mm/dd/yyyy";
                            }
                        }
                    }
                    worksheet.Columns.AutoFit();
                    worksheet.Rows.AutoFit();
                    worksheet.Columns.Font.Size = 13;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CBBlop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string TenLop = CBBlop.SelectedItem.ToString();
                SqlCommand com = new SqlCommand("Select ROW_NUMBER() OVER (ORDER BY hs.TenHocSinh) AS [Số thứ tự] , hs.TenHocSinh, hs.NgaySinh, hs.GioiTinh, hs.SoDienThoai, hs.GhiChu from HocSinh hs " +
                                                "inner join LopHoc lh on lh.MaLop = hs.MaLop " +
                                                "where lh.TenLop = @class", con);
                com.Parameters.AddWithValue("@class", TenLop);
                con.Open();
                SqlDataAdapter sd = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                DGVdanhsachlop.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
