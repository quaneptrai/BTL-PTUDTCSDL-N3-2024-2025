using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< Updated upstream
=======
using Microsoft.ReportingServices.Diagnostics.Internal;
using Microsoft.SqlServer;
>>>>>>> Stashed changes

namespace StudentManagement
{
    public partial class Danhsachtaikhoan : Form
    {
        public Danhsachtaikhoan()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======
        String connectionString = @"Data Source=DESKTOP-7RR07FC;Initial Catalog=BTL;User ID=sa;Password=123456;";
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
            dataGridView1.DataSource = getData("SELECT MaTaiKhoan, TenDangNhap, ChucDanh FROM TaiKhoan");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT * 
                FROM TaiKhoan
                WHERE 
                    (MaTaiKhoan = @MaTaiKhoan OR @MaTaiKhoan IS NULL) AND
                    (TenDangNhap LIKE '%' + @TenDangNhap + '%' OR @TenDangNhap IS NULL)  AND
                    (ChucDanh LIKE '%' + @ChucDanh + '%' OR @ChucDanh IS NULL);";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@MaTaiKhoan", string.IsNullOrWhiteSpace(txt_MaTaiKhoan.Text) ? (object)DBNull.Value : txt_MaTaiKhoan.Text);
                command.Parameters.AddWithValue("@TenDangNhap", string.IsNullOrWhiteSpace(txt_TenDangNhap.Text) ? (object)DBNull.Value : txt_TenDangNhap.Text);
                command.Parameters.AddWithValue("@ChucDanh", string.IsNullOrWhiteSpace(txt_ChucVu.Text) ? (object)DBNull.Value : txt_ChucVu.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private string selectedMaTaiKhoan = null;
        DataGridViewRow selectedRow;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dataGridView1.Rows[e.RowIndex];

            selectedMaTaiKhoan = Convert.ToString(selectedRow.Cells[0].Value);

            if(selectedRow!=null)
            {
                btn_Update.Enabled = true;
                btn_Delete.Enabled = true;
            }
            else
            {
                btn_Update.Enabled = false;
                btn_Delete.Enabled = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dataGridView1.Rows[e.RowIndex];

            selectedMaTaiKhoan = Convert.ToString(selectedRow.Cells[0].Value);

            if(selectedRow!=null)
            {
                btn_Update.Enabled = true;
                btn_Delete.Enabled = true;
            }
            else
            {
                btn_Update.Enabled = false;
                btn_Delete.Enabled = false;
            }
        }

        private string st = string.Empty;
        private void txt_TenDangNhap_TextChanged(object sender, EventArgs e)
        {
            st=txt_TenDangNhap.Text+txt_ChucVu.Text+txt_MaTaiKhoan.Text+txt_MatKhau.Text;
        }

        private void txt_MaTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            st = txt_TenDangNhap.Text + txt_ChucVu.Text + txt_MaTaiKhoan.Text + txt_MatKhau.Text;

        }

        private void txt_ChucVu_TextChanged(object sender, EventArgs e)
        {
            st = txt_TenDangNhap.Text + txt_ChucVu.Text + txt_MaTaiKhoan.Text + txt_MatKhau.Text;

        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            st = txt_TenDangNhap.Text + txt_ChucVu.Text + txt_MaTaiKhoan.Text + txt_MatKhau.Text;

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string maTaiKhoan = txt_MaTaiKhoan.Text.Trim();
            string tenDangNhap = txt_TenDangNhap.Text.Trim();
            string matKhau = txt_MatKhau.Text.Trim();
            string chucDanh = txt_ChucVu.Text.Trim();

            if (string.IsNullOrEmpty(maTaiKhoan) || string.IsNullOrEmpty(tenDangNhap) ||
                string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(chucDanh))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsMaTaiKhoanExists(maTaiKhoan))
            {
                MessageBox.Show("Mã tài khoản đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TaiKhoan (MaTaiKhoan, TenDangNhap, MatKhau, ChucDanh) " +
                               "VALUES (@MaTaiKhoan, @TenDangNhap, @MatKhau, @ChucDanh)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);
                command.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                command.Parameters.AddWithValue("@MatKhau", matKhau);
                command.Parameters.AddWithValue("@ChucDanh", chucDanh);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        dataGridView1.DataSource = getData("SELECT MaTaiKhoan, TenDangNhap, ChucDanh FROM TaiKhoan");

                        txt_MaTaiKhoan.Text = string.Empty;
                        txt_TenDangNhap.Text = string.Empty;
                        txt_ChucVu.Text = string.Empty;
                        txt_MatKhau.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsMaTaiKhoanExists(string maTaiKhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra mã tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void LoadPassword(string maTaiKhoan)
        {
            if (string.IsNullOrEmpty(maTaiKhoan)) return;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MatKhau FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar(); 

                    if (result != null)
                    {
                        txt_MatKhau.Text = result.ToString(); 
                    }
                    else
                    {
                        txt_MatKhau.Text = string.Empty; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải mật khẩu: " + ex.Message);
                }
            }
        }

        private bool isEditing = false;
        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            if (!isEditing)
            {
                isEditing = true;
                btn_Update.Text = "Lưu";
                txt_MaTaiKhoan.Text = selectedRow.Cells[0].Value?.ToString();
                txt_TenDangNhap.Text = selectedRow.Cells[1].Value?.ToString();
                LoadPassword(txt_MaTaiKhoan.Text);
                txt_ChucVu.Text = selectedRow.Cells[2].Value?.ToString();
                btn_Delete.Enabled = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(selectedMaTaiKhoan))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE TaiKhoan SET TenDangNhap = @TenDangNhap, ChucDanh = @ChucDanh, MatKhau=@MatKhau WHERE MaTaiKhoan = @MaTaiKhoan";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MaTaiKhoan", selectedMaTaiKhoan);
                        command.Parameters.AddWithValue("@TenDangNhap", txt_TenDangNhap.Text.Trim());
                        command.Parameters.AddWithValue("@ChucDanh", txt_ChucVu.Text.Trim());
                        command.Parameters.AddWithValue("@MatKhau", txt_MatKhau.Text.Trim());

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật tài khoản thành công!");


                                SqlDataAdapter adapter = new SqlDataAdapter(command);
                                DataTable dataTable = new DataTable();

                                dataGridView1.DataSource = getData("SELECT MaTaiKhoan, TenDangNhap, ChucDanh FROM TaiKhoan");

                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy tài khoản để cập nhật.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi cập nhật tài khoản: " + ex.Message);
                        }
                    }

                    isEditing = false;
                    btn_Update.Text = "Sửa";

                    txt_MaTaiKhoan.Text = string.Empty;
                    txt_TenDangNhap.Text = string.Empty;
                    txt_ChucVu.Text = string.Empty;
                    txt_MatKhau.Text= string.Empty;
                    btn_Delete.Enabled=true;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một tài khoản trước khi lưu.");
                }
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedMaTaiKhoan))
            {
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa tài khoản này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo
                );

                if (confirmResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MaTaiKhoan", selectedMaTaiKhoan);

                        try
                        {
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa tài khoản thành công!");


                                SqlDataAdapter adapter = new SqlDataAdapter(command);
                                DataTable dataTable = new DataTable();

                                dataGridView1.DataSource = getData("SELECT MaTaiKhoan, TenDangNhap, ChucDanh FROM TaiKhoan");

                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy tài khoản để xóa.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản trước khi xóa.");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        
>>>>>>> Stashed changes
    }
}
