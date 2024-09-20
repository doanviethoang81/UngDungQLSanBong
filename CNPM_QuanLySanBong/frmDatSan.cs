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
using System.Globalization;

namespace CNPM_QuanLySanBong
{
    public partial class frmDatSan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-0RBSB93E\\SQLEXPRESS01;Initial Catalog=QLSB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select ID_DS,DatSan.ID_SB,KhachHang.ID_KH,TenSan,NgayDa,GioBD,GioKT,TenKH,GioiTinh,NgaySinh,DienThoai,CCCD,DatSan.Trangthai from KhachHang join DatSan on KhachHang.ID_KH=DatSan.ID_KH join SanBong on DatSan.ID_SB=SanBong.ID_SB where DatSan.Trangthai= N'Chưa vào sân' and NgayDa >= getdate() -1";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDSDatSan.DataSource = table;
        }
        void clear()
        {
            cboIDSB.Text = "";
            cboLoaiSan.Text = "";
            txtCCCD.Text = "";
            txtSDT.Text = "";
            txtTenKH.Text = "";
            cboGioiTinh.Text = "";
            cboLoaiSan.Text = "";
            txtIDDatSan.Text = "";
            cboQuocTich.Text = "";
            txtMaKH.Text = "";
        }

        public void ShowCbo_IDSB()
        {
            var cmd = new SqlCommand("select *from SanBong", connection);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cboIDSB.DisplayMember = "ID_SB";
            cboIDSB.DataSource = dt;
        }

        public frmDatSan()
        {
            InitializeComponent();
        }

        private void frmDatSan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            ShowCbo_IDSB();

          
        }

        private void dgvDSDatSan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDSDatSan.CurrentRow.Index;
            txtIDDatSan.Text = dgvDSDatSan.Rows[i].Cells[0].Value.ToString();
            cboIDSB.Text = dgvDSDatSan.Rows[i].Cells[1].Value.ToString();
            txtMaKH.Text = dgvDSDatSan.Rows[i].Cells[2].Value.ToString();
            cboLoaiSan.Text = dgvDSDatSan.Rows[i].Cells[3].Value.ToString();
            dtNgayDa.Text = dgvDSDatSan.Rows[i].Cells[4].Value.ToString();
            dtpGBD.Text = dgvDSDatSan.Rows[i].Cells[5].Value.ToString();
            dtpGKT.Text = dgvDSDatSan.Rows[i].Cells[6].Value.ToString();
            txtTenKH.Text = dgvDSDatSan.Rows[i].Cells[7].Value.ToString();
            cboGioiTinh.Text = dgvDSDatSan.Rows[i].Cells[8].Value.ToString();
            dtNgaySinh.Text = dgvDSDatSan.Rows[i].Cells[9].Value.ToString();
            txtSDT.Text = dgvDSDatSan.Rows[i].Cells[10].Value.ToString();
            txtCCCD.Text = dgvDSDatSan.Rows[i].Cells[11].Value.ToString();
            cboTrangThai.Text= dgvDSDatSan.Rows[i].Cells[12].Value.ToString();
        }
        private bool kiemTraIDDatSan() // kiểm tra xem có trùng id k
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                string sql = "select COUNT(*) from DatSan where ID_DS= '" + txtIDDatSan.Text + "'";

                SqlCommand command = new SqlCommand(sql, connection);

                int count = (int)command.ExecuteScalar();

                if (count > 0) // trùng id
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private bool kiemTraThongTinKhachHang()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                string sql = "select COUNT(*) from KhachHang where ID_KH= '" + txtMaKH.Text + "' or DienThoai = '" + txtSDT.Text + "'";

                // Thực hiện truy vấn và lấy kết quả
                SqlCommand command = new SqlCommand(sql, connection);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    // đã có thông tin khách hàng
                    return true;
                }
                else
                {
                    //khách hàng mới 
                    return false;
                }
            }
        }
        private bool kiemTraThoiGianDatSan()// kiểm tra xem thời gian đặt sân có hợp lệ k (xem khoảng thời gian của id sân đó có ai đá chưa)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM DatSan WHERE ID_SB = '" + cboIDSB.Text + "' AND NgayDa = '" + dtNgayDa.Text + "' and GioBD >= '" + dtpGBD.Text + "' and GioKT <='" + dtpGKT.Text + "'";

                // Thực hiện truy vấn và lấy kết quả
                SqlCommand command = new SqlCommand(sql, connection);

                int count = (int)command.ExecuteScalar();

                if (count > 0) // đã có người đặt khoảng tg này
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private bool kiemTraIDKhachHang()// kiểm tra id khách hàng có bị trùng k
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM KhachHang WHERE ID_KH = '" + txtMaKH.Text + "'";

                // Thực hiện truy vấn và lấy kết quả
                SqlCommand command = new SqlCommand(sql, connection);

                int count = (int)command.ExecuteScalar();

                if (count > 0) // đã có id khách hàng này rồi
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private bool kiemTraNgayDatSan() // ngày đá phải lớn hơn hoặc bằng ngày hiện tại 
        {
            //lấy ngày hiện tại
            DateTime ngayHienTai = DateTime.Now;

            // chuyển đổi ngày đá sang định dạng DateTime
            DateTime ngayDa = DateTime.ParseExact(dtNgayDa.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);

            // so sánh ngày đặt sân với ngày hiện tại (bỏ quan thời gian )
            if (ngayDa.Date >= ngayHienTai.Date ) // hợp lệ
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool kiemTraThoiGianBatDauDa() // xét thời gian đá nếu chọn ngày hiện tại
        {
            //lấy ngày hiện tại
            DateTime ngayHienTai = DateTime.Now;

            // chuyển đổi ngày đá sang định dạng DateTime
            DateTime ngayDa = DateTime.ParseExact(dtNgayDa.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);

            // so sánh ngày đặt sân với ngày hiện tại (bỏ quan thời gian )
            if (ngayDa.Date == ngayHienTai.Date) // hợp lệ
            {
                //lấy thời gian hiện tại
                DateTime now = DateTime.Now;

                //lấy thời gian bắt đầu đá
                DateTime gioBatDauDa = DateTime.ParseExact(dtpGBD.Text, "HH:mm", CultureInfo.InvariantCulture);

                //so sánh thời gian bắt đầu đá với thời gian hiện tại
                if (gioBatDauDa > now) // hợp lệ
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        private void btnDatSan_Click(object sender, EventArgs e)
        {
            if ( (txtIDDatSan.Text =="" ) || (cboLoaiSan.Text=="") || (cboIDSB.Text == "")|| (cboTrangThai.Text == "")||(txtMaKH.Text == "") 
                || (txtTenKH.Text == "") || (txtCCCD.Text == "") || (txtSDT.Text == "") || (cboGioiTinh.Text == ""))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if(kiemTraIDDatSan()== true)
                {
                    MessageBox.Show("ID Đặt sân bị trùng, Vui lòng đổi ID khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (kiemTraNgayDatSan() == false)
                    {
                        MessageBox.Show("Ngày đá không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (dtpGBD.Value >= dtpGKT.Value)
                        {
                            MessageBox.Show("Giờ bắt đầu không thể lớn hơn hoặc bằng giờ kết thúc!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (kiemTraThoiGianBatDauDa() == false ) //kiểm tra xem thời gian bắt đầu đá đã trôi qua chưa
                            {
                                MessageBox.Show("Thời gian đá bắt đầu đá không hợp lệ !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else // hợp lệ
                            {
                                if (kiemTraThoiGianDatSan() == true)// đã có người đặt khoảng tg này 
                                {
                                    MessageBox.Show("Thời gian ở Mã sân này đã có người đặt !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else //chưa có ng đặt
                                {
                                    if (kiemTraThongTinKhachHang() == true) // kiểm tra xem đã có thông tin của khách hàng chưa 
                                    {
                                        command = connection.CreateCommand();
                                        command.CommandText = "insert into DatSan values('" + txtIDDatSan.Text + "',N'" + txtMaKH.Text + "',N'" + cboIDSB.Text + "','" + dtNgayDa.Text + "', N'" + dtpGBD.Text + "','" + dtpGKT.Text + "',N'" + cboTrangThai.Text + "')";
                                        command.ExecuteNonQuery();
                                        loaddata();
                                        MessageBox.Show("Đặt sân thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else// khách hàng mới thêm thông tin khách hàng
                                    {
                                        if (kiemTraIDKhachHang() == true)
                                        {
                                            MessageBox.Show("ID Khách Hàng đã tồn tại. Vui lòng nhập ID Khách Hàng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                        {
                                            command = connection.CreateCommand();
                                            command.CommandText = "insert into KhachHang values('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + cboGioiTinh.Text + "','" + txtSDT.Text + "', N'" + txtCCCD.Text + "',N'" + cboQuocTich.Text + "','" + dtNgaySinh.Text + "')";
                                            command.ExecuteNonQuery();
                                            command.CommandText = "insert into DatSan values('" + txtIDDatSan.Text + "',N'" + txtMaKH.Text + "',N'" + cboIDSB.Text + "','" + dtNgayDa.Text + "', N'" + dtpGBD.Text + "','" + dtpGKT.Text + "',N'" + cboTrangThai.Text + "')";
                                            command.ExecuteNonQuery();
                                            loaddata();
                                            MessageBox.Show("Đặt sân thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void cboIDSB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            cboGioiTinh.Text = "";
            cboQuocTich.Text = "";
            dtNgaySinh.Text = "";
            if (txtTimKH.Text == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Tạo kết nối database
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Tạo câu lệnh truy vấn
                    string sql = "SELECT * FROM KhachHang WHERE DienThoai = '" + txtTimKH.Text + "'";

                    // Thực hiện truy vấn và lấy kết quả
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Xử lý kết quả
                    if (reader.Read()) // Kiểm tra xem có bản ghi nào được trả về hay không
                    {
                        // Hiển thị mã khách hàng và tên khách hàng
                        txtMaKH.Text = reader["ID_KH"].ToString();
                        txtTenKH.Text = reader["TenKH"].ToString();
                        txtCCCD.Text = reader["CCCD"].ToString();
                        txtSDT.Text = reader["DienThoai"].ToString();
                        cboGioiTinh.Text = reader["GioiTinh"].ToString();
                        cboQuocTich.Text = reader["QuocTich"].ToString();
                        dtNgaySinh.Text = reader["NgaySinh"].ToString();

                        MessageBox.Show("Đã tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTimKH.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng với số điện thoại đã nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTimKH.Text = "";
                    }

                    reader.Close(); // Đóng kết nối reader
                }
            }
        }
        
    }
}