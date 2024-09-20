using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_QuanLySanBong
{
    public partial class frmGiaoDien : Form
    {
        string user = "", pass = "", quyen = "", ten = "";
        public frmGiaoDien(string user, string pass, string quyen, string ten)// quản lý 
        {
            this.user = user;
            this.pass = pass;
            this.quyen = quyen;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;// mở form full màn hình
            this.FormBorderStyle = FormBorderStyle.None;// xóa viền
        }
        public frmGiaoDien(string user, string pass, string quyen)// nhân viên 
        {
            InitializeComponent();
            this.user = user;
            this.pass = pass;
            this.quyen = quyen;
            this.WindowState = FormWindowState.Maximized;// mở form full màn hình
            this.FormBorderStyle = FormBorderStyle.None;// xóa viền
            btnDoanhThu.Enabled = false;
            btnQuanLySan.Enabled = false;


        }
        private Form currentFromChild;
        private void OpenChildForm(Form childFrom)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = childFrom;
            childFrom.TopLevel = false;// thực hiện các form cha khác 
            childFrom.FormBorderStyle = FormBorderStyle.None;// đóng cái khung của form gọi ra
            childFrom.Dock = DockStyle.Fill;// lấp đầy panel
            panel_Body.Controls.Add(childFrom);
            panel_Body.Tag = childFrom;
            childFrom.BringToFront();// hiển thị lên trên
            childFrom.Show();// show form đó lên
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDatSan());
            labTieuDe.Text = "     Đặt Sân";
            btnDatSan.BackColor = Color.Green;
            btnNhanSan.BackColor = Color.SteelBlue;
            btnThanhToan.BackColor = Color.SteelBlue;
            btnQuanLySan.BackColor = Color.SteelBlue;
            btnQuanLyKhachHang.BackColor = Color.SteelBlue;
            btnDoanhThu.BackColor = Color.SteelBlue;
            btnThongTinNhanVien.BackColor = Color.SteelBlue;
            btnDangXuat.BackColor = Color.SteelBlue;
        }
        
        private void btnNhanSan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanSan());
            labTieuDe.Text = "     Nhận Sân";
            btnDatSan.BackColor = Color.SteelBlue;
            btnNhanSan.BackColor = Color.Green;
            btnThanhToan.BackColor = Color.SteelBlue;
            btnQuanLySan.BackColor = Color.SteelBlue;
            btnQuanLyKhachHang.BackColor = Color.SteelBlue;
            btnDoanhThu.BackColor = Color.SteelBlue;
            btnThongTinNhanVien.BackColor = Color.SteelBlue;
            btnDangXuat.BackColor = Color.SteelBlue;
        }

        private void btnDichVuThanhToan_Click(object sender, EventArgs e) // frm thanh toán
        {
            OpenChildForm(new frmThanhToan());
            labTieuDe.Text = "   Thanh Toán";
            btnDatSan.BackColor = Color.SteelBlue;
            btnNhanSan.BackColor = Color.SteelBlue;
            btnThanhToan.BackColor =  Color.Green;
            btnQuanLySan.BackColor = Color.SteelBlue;
            btnQuanLyKhachHang.BackColor = Color.SteelBlue;
            btnDoanhThu.BackColor = Color.SteelBlue;
            btnThongTinNhanVien.BackColor = Color.SteelBlue;
            btnDangXuat.BackColor = Color.SteelBlue;
        }

        private void btnQuanLySan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLySan());
            labTieuDe.Text = "Quản Lý Sân";
            btnDatSan.BackColor = Color.SteelBlue;
            btnNhanSan.BackColor = Color.SteelBlue;
            btnThanhToan.BackColor = Color.SteelBlue;
            btnQuanLySan.BackColor =  Color.Green;
            btnQuanLyKhachHang.BackColor = Color.SteelBlue;
            btnDoanhThu.BackColor = Color.SteelBlue;
            btnThongTinNhanVien.BackColor = Color.SteelBlue;
            btnDangXuat.BackColor = Color.SteelBlue;
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyKhachHang());
            labTieuDe.Text = "Quản Lý Khách Hàng";
            btnDatSan.BackColor = Color.SteelBlue;
            btnNhanSan.BackColor = Color.SteelBlue;
            btnThanhToan.BackColor = Color.SteelBlue;
            btnQuanLySan.BackColor = Color.SteelBlue;
            btnQuanLyKhachHang.BackColor =Color.Green; 
            btnDoanhThu.BackColor = Color.SteelBlue;
            btnThongTinNhanVien.BackColor = Color.SteelBlue;
            btnDangXuat.BackColor = Color.SteelBlue;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDoanhThu());
            labTieuDe.Text = "     Doanh Thu";
            btnDatSan.BackColor = Color.SteelBlue;
            btnNhanSan.BackColor = Color.SteelBlue;
            btnThanhToan.BackColor = Color.SteelBlue;
            btnQuanLySan.BackColor = Color.SteelBlue;
            btnQuanLyKhachHang.BackColor = Color.SteelBlue;
            btnDoanhThu.BackColor =  Color.Green;
            btnThongTinNhanVien.BackColor =Color.SteelBlue;
            btnDangXuat.BackColor = Color.SteelBlue;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            labTieuDe.Text = "            HOME";
            btnDatSan.BackColor = Color.SteelBlue;
            btnNhanSan.BackColor = Color.SteelBlue;
            btnThanhToan.BackColor = Color.SteelBlue;
            btnQuanLySan.BackColor = Color.SteelBlue;
            btnQuanLyKhachHang.BackColor = Color.SteelBlue;
            btnDoanhThu.BackColor = Color.SteelBlue;
            btnThongTinNhanVien.BackColor = Color.SteelBlue;
            btnDangXuat.BackColor = Color.SteelBlue;
        }

        private void btnThongTinNhanVien_Click(object sender, EventArgs e)
        {
            if (quyen == "Nhân Viên")
            {
                OpenChildForm(new frmNhanVien(user, pass));
                labTieuDe.Text = "Thông Tin Nhân Viên";
                btnDatSan.BackColor = Color.SteelBlue;
                btnNhanSan.BackColor = Color.SteelBlue;
                btnThanhToan.BackColor = Color.SteelBlue;
                btnQuanLySan.BackColor = Color.SteelBlue;
                btnQuanLyKhachHang.BackColor = Color.SteelBlue;
                btnDoanhThu.BackColor = Color.SteelBlue;
                btnThongTinNhanVien.BackColor = Color.Green;
                btnDangXuat.BackColor = Color.SteelBlue;
            }
            else
            {
                OpenChildForm(new frmNhanVien(user, pass, quyen));
                labTieuDe.Text = "Thông Tin Nhân Viên";
                btnDatSan.BackColor = Color.SteelBlue;
                btnNhanSan.BackColor = Color.SteelBlue;
                btnThanhToan.BackColor = Color.SteelBlue;
                btnQuanLySan.BackColor = Color.SteelBlue;
                btnQuanLyKhachHang.BackColor = Color.SteelBlue;
                btnDoanhThu.BackColor = Color.SteelBlue;
                btnThongTinNhanVien.BackColor = Color.Green;
                btnDangXuat.BackColor = Color.SteelBlue;
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
