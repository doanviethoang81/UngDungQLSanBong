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
    public partial class frmThanhToan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-0RBSB93E\\SQLEXPRESS01;Initial Catalog=QLSB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT  DatSan.ID_DS,DatSan.ID_SB,TenSan,TenKH,DienThoai,NgayDa,DatSan.GioBD,DatSan.GioKT,DatSan.TrangThai,  CONVERT(VARCHAR(8), CONVERT(DATETIME, GioKT, 10) - CONVERT(DATETIME, GioBD, 10), 108) AS SoGio, CEILING(DATEDIFF(MINUTE, CONVERT(DATETIME, GioBD, 10), CONVERT(DATETIME, GioKT, 10)) / 30.0) * CASE WHEN TenSan = 'Sân 5' THEN 130000 WHEN TenSan = 'Sân 7' THEN 200000 WHEN TenSan = 'Sân 11' THEN 500000 ELSE 0 END AS TongTien from SanBong join DatSan on SanBong.ID_SB=DatSan.ID_SB join KhachHang on DatSan.ID_KH=KhachHang.ID_KH  where DatSan.Trangthai = N'Hết giờ, chưa thanh toán' and NgayDa <= getdate() ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDSSanChuaThanhToan.DataSource = table;
        }

        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
        private bool timKhachHang()
        {
            using (SqlConnection connection = new SqlConnection(str))
            {
                connection.Open();

                string sql = "select COUNT(*) from KhachHang where DienThoai = '" + txtTimKHThanhToan.Text + "'";

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
        private void btnTimKHThanhToan_Click(object sender, EventArgs e)
        {
            if (txtTimKHThanhToan.Text == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (timKhachHang() == false) //khong tìm thấy
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else// tìm thấy 
                {
                    command = connection.CreateCommand();
                    command.CommandText = "SELECT  DatSan.ID_DS,DatSan.ID_SB,TenSan,TenKH,DienThoai,NgayDa,DatSan.GioBD,DatSan.GioKT,DatSan.TrangThai,  CONVERT(VARCHAR(8), CONVERT(DATETIME, GioKT, 10) - CONVERT(DATETIME, GioBD, 10), 108) AS SoGio, CEILING(DATEDIFF(MINUTE, CONVERT(DATETIME, GioBD, 10), CONVERT(DATETIME, GioKT, 10)) / 30.0) * CASE WHEN TenSan = 'Sân 5' THEN 130000 WHEN TenSan = 'Sân 7' THEN 200000 WHEN TenSan = 'Sân 11' THEN 500000 ELSE 0 END AS TongTien from SanBong join DatSan on SanBong.ID_SB=DatSan.ID_SB join KhachHang on DatSan.ID_KH=KhachHang.ID_KH where DienThoai ='"+ txtTimKHThanhToan.Text+"'and Trangthai =N'Hết giờ, chưa thanh toán'";
                    adapter.SelectCommand = command;
                    table.Clear();
                    adapter.Fill(table);
                    dgvDSSanChuaThanhToan.DataSource = table;
                }
            }
        }

        private void btThanhToanTongTien_Click(object sender, EventArgs e)
        {
            int i;
            i = dgvDSSanChuaThanhToan.CurrentRow.Index;
            // Lấy dòng được chọn trong DataGridView
            if (i >= 0)
            {
                //id đặt sân id sb  tên sân tên khách hagnf  đinệ thoai ngaydat gio bt gio kt sogio tongtin
                string iD_DS = dgvDSSanChuaThanhToan.Rows[i].Cells[0].Value.ToString();
                string iD_SB = dgvDSSanChuaThanhToan.Rows[i].Cells[1].Value.ToString();
                string loaiSan = dgvDSSanChuaThanhToan.Rows[i].Cells[2].Value.ToString();
                string tenKhach = dgvDSSanChuaThanhToan.Rows[i].Cells[3].Value.ToString();
                string dienThoai = dgvDSSanChuaThanhToan.Rows[i].Cells[4].Value.ToString();
                string ngayDa = dgvDSSanChuaThanhToan.Rows[i].Cells[5].Value.ToString();
                string gioBd = dgvDSSanChuaThanhToan.Rows[i].Cells[6].Value.ToString();
                string gioKT = dgvDSSanChuaThanhToan.Rows[i].Cells[7].Value.ToString();
                string soGio = dgvDSSanChuaThanhToan.Rows[i].Cells[9].Value.ToString();
                string tongTien = dgvDSSanChuaThanhToan.Rows[i].Cells[10].Value.ToString();

                //cập nhật thanh toán cho bảng đặt sân
                command = connection.CreateCommand();
                command.CommandText = "update DatSan set Trangthai= N'Đã thanh toán' where ID_DS=('" + iD_DS + "')";
                command.ExecuteNonQuery();
                loaddata();

                // Tạo instance của form hóa đơn
                frmHoaDon hoaDon = new frmHoaDon();

                // Truyền dữ liệu sang form hóa đơn
                hoaDon.ID_DS = iD_DS;
                hoaDon.ID_SB = iD_SB;
                hoaDon.LoaiSan = loaiSan;
                hoaDon.TenKhach = tenKhach;
                hoaDon.DienThoai = dienThoai;
                hoaDon.NgayDa = ngayDa;
                hoaDon.gioBD = gioBd;
                hoaDon.gioKT = gioKT;
                hoaDon.SoGio = soGio;
                hoaDon.TongTien = tongTien;

                // Hiển thị form hóa đơn
                this.Hide();// ẩn giao diện trước đó
                hoaDon.ShowDialog();
                loaddata();
                this.Show();// hiện lại giao diện trước
            }
            else
            {
                // Hiển thị thông báo lỗi nếu không có dòng nào được chọn
                MessageBox.Show("Vui lòng chọn một dòng để tạo hóa đơn!");
            }
        }

    }
}
