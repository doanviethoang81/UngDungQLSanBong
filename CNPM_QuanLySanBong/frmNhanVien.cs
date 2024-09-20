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
    public partial class frmNhanVien : Form
    {
        string user, pass, quyen;
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-0RBSB93E\\SQLEXPRESS01;Initial Catalog=QLSB;Integrated Security=True";

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from NhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvQuanLyNhanVien.DataSource = table;
        }
        public frmNhanVien(string User, string pass, string quyen)
        {
            this.user = User;
            this.pass = pass;
            this.quyen = quyen;
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            string sql = "select * from NhanVien where TaiKhoan ='" + User + "' and MatKhau  ='" + pass + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtIDNhanVien.Text = reader["ID_NV"].ToString();
                txtTenNhanV.Text = reader["TenNV"].ToString();
                txtGioiTinh.Text = reader["GioiTinh"].ToString();
                dtpNgayS.Text = reader["NgaySinh"].ToString();
                txtChucV.Text = reader["ChucVu"].ToString();
                txtCMND.Text = reader["CCCD"].ToString();
                txtSDT.Text = reader["DienThoai"].ToString();
                txtEmal.Text = reader["email"].ToString();
                txtDiaC.Text = reader["DiaChi"].ToString();
            }
            else
            {
                MessageBox.Show("không tìm thấy thông tin nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();

        }

        public frmNhanVien(string User, string pass)
        {
            this.user = User;
            this.pass = pass;
            InitializeComponent();
            MessageBox.Show("chỉ admin được quyền xem quản lý nhân viên.");
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
            dgvQuanLyNhanVien.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            txtID.Visible = false;
            txthoten.Visible = false;
            txtdiachi.Visible = false;
            txtchucvu.Visible = false;
            txtdienthoai.Visible = false;
            txtCCCD.Visible = false;
            txttaikhoan.Visible = false;
            cbogioitinh.Visible = false;
            txtmatkhau.Visible = false;
            txtemail.Visible = false;
            dtpngaysinh.Visible = false;
            btnClear.Visible = false;
            connection = new SqlConnection(str);
            connection.Open();
            string sql = "select * from NhanVien where TaiKhoan ='" + User + "' and MatKhau  ='" + pass + "'";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtIDNhanVien.Text = reader["ID_NV"].ToString();
                txtTenNhanV.Text = reader["TenNV"].ToString();
                txtGioiTinh.Text = reader["GioiTinh"].ToString();
                dtpNgayS.Text = reader["NgaySinh"].ToString();
                txtChucV.Text = reader["ChucVu"].ToString();
                txtCMND.Text = reader["CCCD"].ToString();
                txtSDT.Text = reader["DienThoai"].ToString();
                txtEmal.Text = reader["email"].ToString();
                txtDiaC.Text = reader["DiaChi"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvQuanLyNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQuanLyNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtID.ReadOnly = true;
            int i;
            i = dgvQuanLyNhanVien.CurrentRow.Index;
            txtID.Text = dgvQuanLyNhanVien.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dgvQuanLyNhanVien.Rows[i].Cells[1].Value.ToString();
            cbogioitinh.Text = dgvQuanLyNhanVien.Rows[i].Cells[2].Value.ToString();
            dtpngaysinh.Text = dgvQuanLyNhanVien.Rows[i].Cells[3].Value.ToString();
            txtchucvu.Text = dgvQuanLyNhanVien.Rows[i].Cells[4].Value.ToString();
            txtCCCD.Text = dgvQuanLyNhanVien    .Rows[i].Cells[5].Value.ToString();
            txtdienthoai.Text = dgvQuanLyNhanVien.Rows[i].Cells[6].Value.ToString();
            txtemail.Text = dgvQuanLyNhanVien   .Rows[i].Cells[7].Value.ToString();
            txtdiachi.Text = dgvQuanLyNhanVien.Rows[i].Cells[8].Value.ToString();
            txttaikhoan.Text = dgvQuanLyNhanVien.Rows[i].Cells[9].Value.ToString();
            txtmatkhau.Text = dgvQuanLyNhanVien.Rows[i].Cells[10].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into NhanVien values('" + txtID.Text + "',N'" + txthoten.Text + "',N'" + cbogioitinh.Text + "','" + dtpngaysinh.Text + "', N'" + txtchucvu.Text + "','" + txtCCCD.Text + "','" + txtdienthoai.Text + "',N'" + txtemail.Text + "',N'" + txtdiachi.Text + "','" + txttaikhoan.Text + "','" + txtmatkhau.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from NhanVien where ID_NV= '" + txtID.Text + "'" ;
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txthoten.Text = "";
            cbogioitinh.Text = "";
            dtpngaysinh.Text = "";
            txtchucvu.Text = "";
            txtCCCD.Text = "";
            txtdienthoai.Text = "";
            txtemail.Text = "";
            txtdiachi.Text = "";
            txttaikhoan.Text = "";
            txtmatkhau.Text = "";
        }
        private bool checkMatKhau()// kiểm tra id và mật khẩu đúng chưa
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM NhanVien WHERE ID_NV = '" + txtIDNhanVien.Text+ "' and MatKhau ='"+txtMatKhauCu.Text +"'";

                // Thực hiện truy vấn và lấy kết quả
                SqlCommand command = new SqlCommand(sql, connection);

                int count = (int)command.ExecuteScalar();

                if (count > 0) // khớp
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void btnLuuLaiMK_Click(object sender, EventArgs e)
        {
            if((txtMatKhauCu.Text=="")||(txtMatKhauMoi.Text=="")|| (txtXacNhanMatKhauMoi.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if((txtMatKhauMoi.Text)!= (txtXacNhanMatKhauMoi.Text)) // nhập lại mật khẩu mới không khớp với nhau
                {
                    MessageBox.Show("Nhập mật khẩu mới không trùng nhau !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (checkMatKhau() == true)
                    {
                        command = connection.CreateCommand();
                        command.CommandText = "UPDATE NhanVien set MatKhau ='" + txtMatKhauMoi.Text + "' where ID_NV ='" + txtIDNhanVien.Text + "'";
                        command.ExecuteNonQuery();
                        loaddata();
                        MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatKhauCu.Text = "";
                        txtMatKhauMoi.Text = "";
                        txtXacNhanMatKhauMoi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu cũ sai !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update NhanVien set TenNV=N'" + txthoten.Text
                + "',GioiTinh=N'" + cbogioitinh.Text + "',NgaySinh='" + dtpngaysinh.Text +
                "',ChucVu=N'" + txtchucvu.Text + "',CCCD='" + txtCCCD.Text + "',DienThoai='"
                + txtdienthoai.Text + "',email='" + txtemail.Text + "',DiaChi=N'" + txtdiachi.Text
                + "',TaiKhoan='" + txttaikhoan.Text + "',MatKhau='" + txtmatkhau.Text
                + "'  where ID_NV='" + txtID.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void TabQLNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
