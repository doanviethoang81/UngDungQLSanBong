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
    public partial class frmNhanSan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-0RBSB93E\\SQLEXPRESS01;Initial Catalog=QLSB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select DatSan.ID_DS,DatSan.ID_SB,TenSan,TenKH,DienThoai,NgayDa,DatSan.GioBD,DatSan.GioKT,DatSan.TrangThai from SanBong join DatSan on SanBong.ID_SB=DatSan.ID_SB join KhachHang on DatSan.ID_KH=KhachHang.ID_KH where DatSan.Trangthai = N'Chưa vào sân' and NgayDa >= getdate() -1 or DatSan.Trangthai = N'Đã vào sân' and NgayDa >= getdate() -1";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgv_dsnhansan.DataSource = table;
        }
        void clear()
        {
            txtID_DS.Text = "";
            cboLoaiSan.Text = "";
            txtSDT.Text = "";
            txtTenKH.Text = "";
            cboTrangThaiSan.Text = "";
            cboMaSan.Text = "";
        }

        public void ShowCbo_IDSB() // show dữ liệu lên comboBox
        {
            var cmd = new SqlCommand("select *from SanBong", connection);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cboMaSan.DisplayMember = "ID_SB";
            cboMaSan.DataSource = dt;

        }

        public frmNhanSan()
        {
            InitializeComponent();
        }

        private void btnNhanSan_Click(object sender, EventArgs e)
        {
            command.CommandText = "update DatSan set Trangthai=N'Đã vào sân' where ID_DS=('" + txtID_DS.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
            clear();
        }
        private void frmNhanSan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            ShowCbo_IDSB();
            btnCapNhat_Click(sender, e); 
        }

        private void dtgv_dsnhansan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i;
            i = dtgv_dsnhansan.CurrentRow.Index;
            txtID_DS.Text = dtgv_dsnhansan.Rows[i].Cells[0].Value.ToString();
            cboMaSan.Text = dtgv_dsnhansan.Rows[i].Cells[1].Value.ToString();
            cboLoaiSan.Text = dtgv_dsnhansan.Rows[i].Cells[2].Value.ToString();
            txtTenKH.Text = dtgv_dsnhansan.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dtgv_dsnhansan.Rows[i].Cells[4].Value.ToString();
            dtpNgayDa.Text = dtgv_dsnhansan.Rows[i].Cells[5].Value.ToString();
            dtGBD.Text = dtgv_dsnhansan.Rows[i].Cells[6].Value.ToString();
            dtGKT.Text = dtgv_dsnhansan.Rows[i].Cells[7].Value.ToString();
            cboTrangThaiSan.Text = dtgv_dsnhansan.Rows[i].Cells[8].Value.ToString();
        }

        private void btnXoaSan_Click(object sender, EventArgs e)
        {
            if (cboTrangThaiSan.Text == "Chưa vào sân")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (result == DialogResult.OK)// xác nhận xóa 
                {
                    command.CommandText = "delete from DatSan where ID_DS =('" + txtID_DS.Text + "')";
                    command.ExecuteNonQuery();
                    loaddata();
                }
            }
            else
            {
                MessageBox.Show("Đã vào sân không được Xóa !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool timKhachHangDatSan()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                string sql = "select COUNT(*) from KhachHang where DienThoai = '" + txtTimKHNhanSan.Text + "'";

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
        private void btnTimKH1_Click(object sender, EventArgs e)
        {
            if (txtTimKHNhanSan.Text == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (timKhachHangDatSan() == false) //khong tìm thấy
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else// tìm thấy 
                {
                    command = connection.CreateCommand();
                    command.CommandText = "select DatSan.ID_DS,DatSan.ID_SB,TenSan,TenKH,DienThoai,NgayDa,DatSan.GioBD,DatSan.GioKT,DatSan.TrangThai from SanBong join DatSan on SanBong.ID_SB=DatSan.ID_SB join KhachHang on DatSan.ID_KH=KhachHang.ID_KH where DienThoai ='" + txtTimKHNhanSan.Text+ "' and Trangthai =N'Đã vào sân' or DienThoai ='" + txtTimKHNhanSan.Text+ "'and Trangthai =N'Chưa vào sân'";
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dtgv_dsnhansan.DataSource = table;
                }
            }
        }
        private bool kiemTraThoiGianDatSan()// kiểm tra xem thời gian đặt sân có hợp lệ k (xem khoảng thời gian của id sân đó có ai đá chưa)
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM DatSan WHERE ID_SB = '" + txtID_DS.Text + "' AND NgayDa = '" + dtpNgayDa.Text + "' and GioBD >= '" + dtGBD.Text + "' and GioKT <='" + dtGKT.Text + "'";

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
        private bool kiemTraNgayDatSan() // ngày đá phải lớn hơn hoặc bằng ngày hiện tại 
        {
            //lấy ngày hiện tại
            DateTime ngayHienTai = DateTime.Now;

            // chuyển đổi ngày đá sang định dạng DateTime
            DateTime ngayDa = DateTime.ParseExact(dtpNgayDa.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture);

            // so sánh ngày đặt sân với ngày hiện tại (bỏ quan thời gian )
            if (ngayDa.Date >= ngayHienTai.Date) // hợp lệ
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        private void btnSuaSan_Click(object sender, EventArgs e)
        {
            if(cboTrangThaiSan.Text=="Chưa vào sân")
            {
                if (kiemTraNgayDatSan() == false)
                {
                    MessageBox.Show("Ngày đá không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (kiemTraThoiGianDatSan() == true)
                    {
                        MessageBox.Show("Thời gian ở Mã sân này đã có người đặt !", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (dtGBD.Value >= dtGKT.Value)
                        {
                            MessageBox.Show("Giờ bắt đầu không thể lớn hơn hoặc bằng giờ kết thúc!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            command.CommandText = "update DatSan set NgayDa=('" + dtpNgayDa.Text + "'),GioBD=('" + dtGBD.Text + "'),GioKT=('" + dtGKT.Text + "')  where ID_DS=('" + txtID_DS.Text + "')";
                            command.ExecuteNonQuery();
                            MessageBox.Show("Sửa sân thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            loaddata();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã vào sân không được sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            command.CommandText = "update DatSan set Trangthai= N'Hết giờ, chưa thanh toán'  where NgayDa <= getdate() and GioKT < CONVERT(TIME, GETDATE()) and Trangthai = N'Đã vào sân' or NgayDa < getdate() and Trangthai =N'Đã vào sân'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
