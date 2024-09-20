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

namespace CNPM_QuanLySanBong
{
    public partial class frmQuanLySan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-0RBSB93E\\SQLEXPRESS01;Initial Catalog=QLSB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SanBong";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDanhSachSan.DataSource = table;
        }
        private void AddDataToComboLoaiSan()
        {
            if (connection == null)
            {
                // Khởi tạo kết nối nếu chưa có
                connection = new SqlConnection(str);
                connection.Open();
            }
            // Đảm bảo kết nối đang mở
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            // Tạo HashSet để lưu trữ các loại sân đã thêm
            HashSet<string> loaiSanSet = new HashSet<string>();
            using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT LoaiSan FROM SanBong", connection))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string loaiSan = dr["LoaiSan"].ToString();
                        // Chỉ thêm loại sân nếu chưa tồn tại trong HashSet
                        if (!loaiSanSet.Contains(loaiSan))
                        {
                            loaiSanSet.Add(loaiSan);
                        }
                    }
                }
            }
            // Cập nhật ComboBox
            cboLoaiSan.Items.Clear();
            foreach (var loaiSan in loaiSanSet)
            {
                cboLoaiSan.Items.Add(loaiSan);
            }
        }
        public frmQuanLySan()
        {
            InitializeComponent();
            AddDataToComboLoaiSan();
        }

        private void frmQuanLySan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ textbox tìm kiếm
                string tuKhoa = txtTimKiem.Text.Trim();

                string query;
                SqlCommand cmd;

                if (string.IsNullOrWhiteSpace(tuKhoa))
                {
                    // Nếu từ khóa tìm kiếm là khoảng trắng hoặc rỗng, hiển thị tất cả dữ liệu
                    query = "SELECT * FROM SanBong";
                    cmd = new SqlCommand(query, connection);
                }
                else
                {
                    // Tạo câu lệnh truy vấn SQL để tìm kiếm các dịch vụ có mã sân chứa từ khóa
                    query = "SELECT * FROM SanBong WHERE ID_SB LIKE @TuKhoa";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                }

                // Chuẩn bị và thực thi câu lệnh truy vấn SQL
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // Hiển thị kết quả trên DataGridView
                    dgvDanhSachSan.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnThemSan_Click_1(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO SanBong (ID_SB, TenSan, LoaiSan, SLToiDa) VALUES (@ID_SB, @TenSan, @LoaiSan, @SLToiDa)";

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ID_SB", txtMaSan.Text);
                command.Parameters.AddWithValue("@TenSan", txtTenSan.Text);
                command.Parameters.AddWithValue("@LoaiSan", cboLoaiSan.Text);
                command.Parameters.AddWithValue("@SLToiDa", txtSoNguoiToiDa.Text);

                command.ExecuteNonQuery();
                loaddata();

                // Hiển thị thông báo thành công
                MessageBox.Show(" Thêm sân bóng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sân bóng: " + ex.Message);
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSan.Text))
            {
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "UPDATE SanBong SET TenSan = @TenSan, LoaiSan = @LoaiSan, SLToiDa = @SLToiDa WHERE ID_SB = @ID_SB";

                    // Thêm các tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@TenSan", txtTenSan.Text);
                    command.Parameters.AddWithValue("@LoaiSan", cboLoaiSan.Text);
                    command.Parameters.AddWithValue("@SLToiDa", txtSoNguoiToiDa.Text);
                    command.Parameters.AddWithValue("@ID_SB", txtMaSan.Text);

                    command.ExecuteNonQuery();
                    loaddata();

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Cập nhật sân bóng thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật sân bóng: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sân bóng cần sửa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Xóa các bản ghi trong bảng DatSan
                        command.CommandText = "DELETE FROM DatSan WHERE ID_SB = @ID_SB";
                        command.ExecuteNonQuery();

                        // Xóa bản ghi từ bảng SanBong sau khi đã xóa các bản ghi liên quan từ bảng DatSan, ChiTietDatSan và ChiTietNhanSan
                        command.CommandText = "DELETE FROM SanBong WHERE ID_SB = @ID_SB";
                        command.ExecuteNonQuery();

                        // Commit giao dịch nếu không có lỗi
                        transaction.Commit();
                        MessageBox.Show("Xóa sân bóng thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddata();
                    }
                    catch (SqlException sqlEx)
                    {
                        // Rollback giao dịch nếu có lỗi
                        transaction.Rollback();
                        MessageBox.Show("Lỗi khi xóa sân bóng: " + sqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        // Rollback giao dịch nếu có lỗi
                        transaction.Rollback();
                        MessageBox.Show("Lỗi không xác định khi xóa sân bóng: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void dgvDanhSachSan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDanhSachSan.Rows[e.RowIndex];
                // Kiểm tra giá trị của ô trước khi chuyển đổi
                txtMaSan.Text = selectedRow.Cells[0].Value.ToString();
                txtTenSan.Text = selectedRow.Cells[1].Value.ToString();
                cboLoaiSan.Text = selectedRow.Cells[2].Value.ToString();
                txtSoNguoiToiDa.Text = selectedRow.Cells[3].Value.ToString();
               
            }
        }
    }
}
