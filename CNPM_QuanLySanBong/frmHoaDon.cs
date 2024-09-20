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
    public partial class frmHoaDon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-0RBSB93E\\SQLEXPRESS01;Initial Catalog=QLSB;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public string ID_DS { get; set; }
        public string ID_SB { get; set; }
        public string LoaiSan { get; set; }
        public string TenKhach { get; set; }
        public string DienThoai { get; set; }
        public string NgayDa { get; set; }
        public string gioBD { get; set; }
        public string gioKT { get; set; }
        public string SoGio { get; set; }
        public string TongTien { get; set; }
        public frmHoaDon()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            // Hiển thị dữ liệu lên các control trong form
            txtMaHoaDon.Text = RandomMaHoaDon().ToString();
            txtIDDatSan.Text= ID_DS.ToString();
            txtIDSB.Text= ID_SB.ToString();
            txtTenKH.Text= TenKhach.ToString();
            txtTuGio.Text= gioBD.ToString() ;
            txtDenGio.Text = gioKT.ToString();
            txtSoDienThoai.Text= DienThoai.ToString();
            txtLoaiSan.Text= LoaiSan.ToString();
            dtpNgayDa.Text = NgayDa.ToString();
            txtSoGioDa.Text = SoGio.ToString();
            txtTongTien.Text = TongTien.ToString();

        }
        public int RandomMaHoaDon()
        {
            // Sử dụng hàm Random để tạo số ngẫu nhiên
            Random random = new Random();
            // Tạo số nguyên ngẫu nhiên có 5 chữ số
            int minNumber = 10000;
            int maxNumber = 99999;
            int n = random.Next(minNumber, maxNumber + 1);
            return n;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HoaDon values('" + txtMaHoaDon.Text + "',N'" + txtIDDatSan.Text + "','" + dtpNgayLapHD.Text + "','" + txtTongTien.Text + "', N'Đã thanh toán')";
            command.ExecuteNonQuery();
            this.Close();
        }
    }
}
