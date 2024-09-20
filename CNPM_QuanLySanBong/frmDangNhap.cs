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
    public partial class frmDangNhap : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-0RBSB93E\\SQLEXPRESS01;Initial Catalog=QLSB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public frmDangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;// hiện thị giao diện ở giữa
        }
        private bool timKhachHangDatSan(string a, string b)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                string sql = "select COUNT(*) from NhanVien where taikhoan = '" + a + "' and MatKhau ='" + b + "' and ChucVu =N'Quản lý'";

                SqlCommand command = new SqlCommand(sql, connection);

                int count = (int)command.ExecuteScalar();

                if (count > 0) // tìm thấy 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {

            if ((txtTenDN.Text == "") || (txtMatK.Text == ""))
            {
                labChuThich.Text = "vui lòng nhập đủ thông tin ";
            }
            else
            {
                SqlConnection conn = new SqlConnection(str);
                try
                {
                    conn.Open();
                    string tk = txtTenDN.Text;
                    string mk = txtMatK.Text;
                    string sql = "select * from NhanVien where TaiKhoan ='" + tk + "' and MatKhau  ='" + mk + "'";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader data = cmd.ExecuteReader();
                    if (data.Read() == true)
                    {
                        if (timKhachHangDatSan(tk, mk) == true)//nếu là quản lý
                        {
                            frmGiaoDien giaoDien = new frmGiaoDien(tk, mk, "Quản Lý", "cc");
                            this.Hide();// ẩn giao diện trước đó
                            giaoDien.ShowDialog();
                            this.Show();// hiện lại giao diện đăng nhập
                            checkBoxHienMatKhau.Checked = false;//bỏ dấu click trước đó
                            labChuThich.Text = "";
                            txtTenDN.Text = "";
                            txtMatK.Text = "";

                        }
                        else
                        {
                            frmGiaoDien giaoDien = new frmGiaoDien(tk, mk, "Nhân Viên");
                            this.Hide();// ẩn giao diện trước đó
                            giaoDien.ShowDialog();
                            this.Show();// hiện lại giao diện đăng nhập
                            checkBoxHienMatKhau.Checked = false;//bỏ dấu click trước đó
                            labChuThich.Text = "";
                            txtTenDN.Text = "";
                            txtMatK.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoảng hoặc mật khẩu sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        checkBoxHienMatKhau.Checked = false;//bỏ dấu click trước đó
                        labChuThich.Text = "";
                        txtTenDN.Text = "";
                        txtMatK.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHienMatKhau.Checked)// hiện mật khẩu
            {
                txtMatK.UseSystemPasswordChar = false;
            }
            else // ẩn
            {
                txtMatK.UseSystemPasswordChar = true;
            }
        }
    }
}
