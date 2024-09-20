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
    public partial class frmDoanhThu : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-0RBSB93E\\SQLEXPRESS01;Initial Catalog=QLSB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select ID_HD,HoaDon.ID_DS,DatSan.ID_SB,DatSan.ID_KH,TenKH,DienThoai,DatSan.NgayDa,CONVERT(VARCHAR(8), CONVERT(DATETIME, GioKT, 10) - CONVERT(DATETIME, GioBD, 10), 108) AS SoGio,TongTien from HoaDon join DatSan on HoaDon.ID_DS =DatSan.ID_DS join KhachHang on DatSan.ID_KH =KhachHang.ID_KH where HoaDon.TrangThai =N'Đã thanh toán'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDoanhThu.DataSource = table;
        }
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            labTongTien.Text = tinhTongTien().ToString("#,### VNĐ"); // tính tổng tiền trong dgvDoanhThu

        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            // thống kê theo ngày 
            command = connection.CreateCommand();
            command.CommandText = "select ID_HD,HoaDon.ID_DS,DatSan.ID_SB,DatSan.ID_KH,TenKH,DienThoai,DatSan.NgayDa,CONVERT(VARCHAR(8), CONVERT(DATETIME, GioKT, 10) - CONVERT(DATETIME, GioBD, 10), 108) AS SoGio,TongTien from HoaDon join DatSan on HoaDon.ID_DS =DatSan.ID_DS join KhachHang on DatSan.ID_KH =KhachHang.ID_KH where HoaDon.TrangThai =N'Đã thanh toán' and NgayDa >='"+dtpTuNg.Text+"' and NgayDa <= '"+ dtpDenNg.Text + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);           dgvDoanhThu.DataSource = table;
            labTongTien.Text = tinhTongTien().ToString("#,### VNĐ");// gọi lại hàm tính tiền 
        }
        int soDong = 0;
        private void dgvDoanhThu_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            soDong = dgvDoanhThu.Rows.Count -1;
            labSoHoaDon.Text = soDong.ToString();
        }

        private float tinhTongTien()
        {
            float tongTien = 0;
            foreach (DataGridViewRow row in dgvDoanhThu.Rows)
            {
                // Kiểm tra giá trị null
                if (row.Cells[8].Value == null)
                {
                    continue;
                }

                try
                {
                    // Lấy giá trị trong cột "Tiền" và chuyển đổi sang kiểu float
                    float tienSan = float.Parse(row.Cells[8].Value.ToString());
                    tongTien += tienSan;
                }
                catch (FormatException ex)
                {
                    // Xử lý lỗi định dạng
                    MessageBox.Show("Lỗi định dạng dữ liệu trong cột Tiền: " + ex.Message);
                    continue;
                }
            }

            return tongTien;
        }
    }
}
