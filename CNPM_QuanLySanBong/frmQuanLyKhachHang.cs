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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CNPM_QuanLySanBong
{
    public partial class frmQuanLyKhachHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-0RBSB93E\\SQLEXPRESS01;Initial Catalog=QLSB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from KhachHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDanhSachKhachHang.DataSource = table;
        }
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường thông tin đã được nhập đầy đủ hay không
                if (string.IsNullOrWhiteSpace(txtMa.Text) ||
                    string.IsNullOrWhiteSpace(txtHoVaTen.Text) ||
                    string.IsNullOrWhiteSpace(cboGioiTinh.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtCMND.Text) ||
                    string.IsNullOrWhiteSpace(cboQuocTich.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                // Lấy ngày sinh từ DateTimePicker
                DateTime ngaySinh = dtpNgaySinh.Value;

                // Kiểm tra nếu ngày sinh lớn hơn ngày hiện tại
                if (ngaySinh > DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không hợp lệ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

                // Tạo câu lệnh SQL sử dụng tham số để tránh SQL Injection
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO KhachHang (ID_KH, TenKH, GioiTinh, DienThoai, CCCD, QuocTich, NgaySinh) VALUES (@ID_KH, @TenKH, @GioiTinh, @DienThoai, @CCCD, @QuocTich, @NgaySinh)";

                // Thêm các tham số vào câu lệnh SQL
                command.Parameters.AddWithValue("@ID_KH", txtMa.Text);
                command.Parameters.AddWithValue("@TenKH", txtHoVaTen.Text);
                command.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                command.Parameters.AddWithValue("@DienThoai", txtSDT.Text);
                command.Parameters.AddWithValue("@CCCD", txtCMND.Text);
                command.Parameters.AddWithValue("@QuocTich", cboQuocTich.Text);
                command.Parameters.AddWithValue("@NgaySinh", ngaySinh.Date); // Chỉ lấy phần ngày

                // Thực thi câu lệnh SQL
                command.ExecuteNonQuery();

                // Tải lại dữ liệu
                loaddata();

                MessageBox.Show("Thêm khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = "DELETE FROM KhachHang WHERE ID_KH ='" + txtMa.Text + "'";
                command.ExecuteNonQuery();
                loaddata();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu tất cả các TextBox không được để trống
                if (string.IsNullOrWhiteSpace(txtMa.Text))
                {
                    MessageBox.Show("ID không được để trống.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                {
                    MessageBox.Show("Họ và tên không được để trống.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cboGioiTinh.Text))
                {
                    MessageBox.Show("Giới tính không được để trống.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không được để trống.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCMND.Text))
                {
                    MessageBox.Show("CMND không được để trống.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cboQuocTich.Text))
                {
                    MessageBox.Show("Quốc tịch không được để trống.");
                    return;
                }
                // Lấy ngày sinh từ DateTimePicker
                DateTime ngaySinh = dtpNgaySinh.Value;

                // Kiểm tra nếu ngày sinh lớn hơn ngày hiện tại
                if (ngaySinh > DateTime.Now)
                {
                    MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại.");
                    return;
                }
                // Kiểm tra nếu ID_KH không được thay đổi
                if (txtMa.Tag != null && txtMa.Text != txtMa.Tag.ToString())
                {
                    MessageBox.Show("Không được sửa ID khách hàng.");
                    return;
                }
                // Tạo câu lệnh SQL sử dụng tham số để tránh SQL Injection
                string queryString = "UPDATE KhachHang SET TenKH=@TenKH, GioiTinh=@GioiTinh, DienThoai=@DienThoai, NgaySinh=@NgaySinh, QuocTich=@QuocTich, CCCD=@CCCD WHERE ID_KH=@ID_KH";
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    // Thêm các tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@TenKH", txtHoVaTen.Text);
                    command.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);
                    command.Parameters.AddWithValue("@DienThoai", txtSDT.Text);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh.Date); // Chỉ lấy phần ngày
                    command.Parameters.AddWithValue("@QuocTich", cboQuocTich.Text);
                    command.Parameters.AddWithValue("@CCCD", txtCMND.Text);
                    command.Parameters.AddWithValue("@ID_KH", txtMa.Text);
                    // Thực thi câu lệnh SQL
                    command.ExecuteNonQuery();

                    // Tải lại dữ liệu
                    loaddata();
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin khách hàng: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy số điện thoại cần tìm kiếm từ TextBox
                string soDienThoaiCanTim = txtTimKiem.Text.Trim();

                // Kiểm tra xem người dùng đã nhập số điện thoại hay chưa
                if (string.IsNullOrEmpty(soDienThoaiCanTim))
                {
                    // Nếu không nhập số điện thoại, load lại toàn bộ dữ liệu khách hàng
                    loaddata();
                    return;
                }

                // Tạo câu lệnh SQL để tìm kiếm khách hàng theo số điện thoại
                string queryString = "SELECT * FROM KhachHang WHERE DienThoai LIKE @SoDienThoai";

                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    // Thêm tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@SoDienThoai", "%" + soDienThoaiCanTim + "%"); // Sử dụng toán tử LIKE để tìm kiếm một phần của số điện thoại

                    // Sử dụng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Tạo DataTable để lưu trữ kết quả
                    DataTable table = new DataTable();

                    // Đổ dữ liệu vào DataTable
                    adapter.Fill(table);

                    // Kiểm tra xem có dữ liệu được tìm thấy không
                    if (table.Rows.Count > 0)
                    {
                        // Hiển thị dữ liệu tìm thấy trên DataGridView
                        dgvDanhSachKhachHang.DataSource = table;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với số điện thoại đã nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Nếu không có dữ liệu được tìm thấy, load lại dữ liệu gốc từ cơ sở dữ liệu và hiển thị nó trên DataGridView
                        loaddata();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm khách hàng: " + ex.Message);
            }
        }

        private void frmQuanLyKhachHang_Load_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvDanhSachKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDanhSachKhachHang.Rows[e.RowIndex];

                // Hiển thị dữ liệu trong GroupBox và gán ID vào Tag
                txtMa.Text = selectedRow.Cells[0].Value.ToString();
                txtMa.Tag = selectedRow.Cells[0].Value.ToString(); // Gán ID vào Tag để so sánh sau này
                txtHoVaTen.Text = selectedRow.Cells[1].Value.ToString();
                cboGioiTinh.Text = selectedRow.Cells[2].Value.ToString();
                txtSDT.Text = selectedRow.Cells[3].Value.ToString();
                txtCMND.Text = selectedRow.Cells[4].Value.ToString();
                cboQuocTich.Text = selectedRow.Cells[5].Value.ToString();

                // Kiểm tra nếu ngày sinh là hợp lệ
                if (selectedRow.Cells[6].Value != DBNull.Value && DateTime.TryParse(selectedRow.Cells[6].Value.ToString(), out DateTime ngaySinh))
                {
                    if (ngaySinh >= dtpNgaySinh.MinDate && ngaySinh <= dtpNgaySinh.MaxDate)
                    {
                        dtpNgaySinh.Value = ngaySinh;
                    }
                    else
                    {
                        dtpNgaySinh.Value = dtpNgaySinh.MinDate;
                    }
                }
                else
                {
                    dtpNgaySinh.Value = dtpNgaySinh.MinDate;
                }
            }
        }
    }
}
