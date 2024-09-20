namespace CNPM_QuanLySanBong
{
    partial class frmQuanLyKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groDanhSachKhachHang = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachKhachHang = new System.Windows.Forms.DataGridView();
            this.groChucNang = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.cboQuocTich = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblQuocTich = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.groTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiemTheo = new System.Windows.Forms.Label();
            this.groDanhSachKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).BeginInit();
            this.groChucNang.SuspendLayout();
            this.groThongTinKhachHang.SuspendLayout();
            this.groTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groDanhSachKhachHang
            // 
            this.groDanhSachKhachHang.Controls.Add(this.dgvDanhSachKhachHang);
            this.groDanhSachKhachHang.Location = new System.Drawing.Point(657, 25);
            this.groDanhSachKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.groDanhSachKhachHang.Name = "groDanhSachKhachHang";
            this.groDanhSachKhachHang.Padding = new System.Windows.Forms.Padding(2);
            this.groDanhSachKhachHang.Size = new System.Drawing.Size(927, 931);
            this.groDanhSachKhachHang.TabIndex = 7;
            this.groDanhSachKhachHang.TabStop = false;
            this.groDanhSachKhachHang.Text = "Danh Sách Khách Hàng";
            // 
            // dgvDanhSachKhachHang
            // 
            this.dgvDanhSachKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhachHang.Location = new System.Drawing.Point(26, 35);
            this.dgvDanhSachKhachHang.Name = "dgvDanhSachKhachHang";
            this.dgvDanhSachKhachHang.RowHeadersWidth = 25;
            this.dgvDanhSachKhachHang.RowTemplate.Height = 28;
            this.dgvDanhSachKhachHang.Size = new System.Drawing.Size(876, 646);
            this.dgvDanhSachKhachHang.TabIndex = 0;
            this.dgvDanhSachKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachKhachHang_CellClick);
            // 
            // groChucNang
            // 
            this.groChucNang.Controls.Add(this.btnSua);
            this.groChucNang.Controls.Add(this.btnXoa);
            this.groChucNang.Controls.Add(this.btnThem);
            this.groChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groChucNang.Location = new System.Drawing.Point(34, 778);
            this.groChucNang.Margin = new System.Windows.Forms.Padding(2);
            this.groChucNang.Name = "groChucNang";
            this.groChucNang.Padding = new System.Windows.Forms.Padding(2);
            this.groChucNang.Size = new System.Drawing.Size(608, 145);
            this.groChucNang.TabIndex = 6;
            this.groChucNang.TabStop = false;
            this.groChucNang.Text = "Chức Năng";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(429, 52);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 45);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(214, 52);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 45);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(20, 52);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groThongTinKhachHang
            // 
            this.groThongTinKhachHang.Controls.Add(this.lblMa);
            this.groThongTinKhachHang.Controls.Add(this.cboQuocTich);
            this.groThongTinKhachHang.Controls.Add(this.dtpNgaySinh);
            this.groThongTinKhachHang.Controls.Add(this.txtMa);
            this.groThongTinKhachHang.Controls.Add(this.txtHoVaTen);
            this.groThongTinKhachHang.Controls.Add(this.txtCMND);
            this.groThongTinKhachHang.Controls.Add(this.txtSDT);
            this.groThongTinKhachHang.Controls.Add(this.lblQuocTich);
            this.groThongTinKhachHang.Controls.Add(this.lblSDT);
            this.groThongTinKhachHang.Controls.Add(this.lblNgaySinh);
            this.groThongTinKhachHang.Controls.Add(this.lblGioiTinh);
            this.groThongTinKhachHang.Controls.Add(this.cboGioiTinh);
            this.groThongTinKhachHang.Controls.Add(this.lblCMND);
            this.groThongTinKhachHang.Controls.Add(this.lblHoVaTen);
            this.groThongTinKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groThongTinKhachHang.Location = new System.Drawing.Point(34, 256);
            this.groThongTinKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.groThongTinKhachHang.Name = "groThongTinKhachHang";
            this.groThongTinKhachHang.Padding = new System.Windows.Forms.Padding(2);
            this.groThongTinKhachHang.Size = new System.Drawing.Size(608, 498);
            this.groThongTinKhachHang.TabIndex = 5;
            this.groThongTinKhachHang.TabStop = false;
            this.groThongTinKhachHang.Text = "Thông Tin Khách Hàng";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMa.Location = new System.Drawing.Point(20, 38);
            this.lblMa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(46, 25);
            this.lblMa.TabIndex = 17;
            this.lblMa.Text = "Mã:";
            // 
            // cboQuocTich
            // 
            this.cboQuocTich.FormattingEnabled = true;
            this.cboQuocTich.Items.AddRange(new object[] {
            "Việt Nam",
            "Nước Ngoài"});
            this.cboQuocTich.Location = new System.Drawing.Point(296, 251);
            this.cboQuocTich.Margin = new System.Windows.Forms.Padding(2);
            this.cboQuocTich.Name = "cboQuocTich";
            this.cboQuocTich.Size = new System.Drawing.Size(275, 33);
            this.cboQuocTich.TabIndex = 16;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpNgaySinh.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(302, 70);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(270, 30);
            this.dtpNgaySinh.TabIndex = 15;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(20, 64);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(155, 30);
            this.txtMa.TabIndex = 14;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(20, 158);
            this.txtHoVaTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(155, 30);
            this.txtHoVaTen.TabIndex = 14;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(20, 251);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(155, 30);
            this.txtCMND.TabIndex = 13;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(302, 159);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(270, 30);
            this.txtSDT.TabIndex = 12;
            // 
            // lblQuocTich
            // 
            this.lblQuocTich.AutoSize = true;
            this.lblQuocTich.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuocTich.Location = new System.Drawing.Point(296, 221);
            this.lblQuocTich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuocTich.Name = "lblQuocTich";
            this.lblQuocTich.Size = new System.Drawing.Size(109, 25);
            this.lblQuocTich.TabIndex = 10;
            this.lblQuocTich.Text = "Quốc Tịch:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSDT.Location = new System.Drawing.Point(302, 131);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(148, 25);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = " Số Điện Thoại:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNgaySinh.Location = new System.Drawing.Point(302, 39);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(109, 25);
            this.lblNgaySinh.TabIndex = 7;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 318);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(96, 25);
            this.lblGioiTinh.TabIndex = 6;
            this.lblGioiTinh.Text = "Giới Tính:";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(20, 348);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(155, 33);
            this.cboGioiTinh.TabIndex = 4;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCMND.Location = new System.Drawing.Point(20, 221);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(108, 25);
            this.lblCMND.TabIndex = 2;
            this.lblCMND.Text = "Số CMND:";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHoVaTen.Location = new System.Drawing.Point(20, 129);
            this.lblHoVaTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(109, 25);
            this.lblHoVaTen.TabIndex = 1;
            this.lblHoVaTen.Text = "Họ và Tên:";
            // 
            // groTimKiem
            // 
            this.groTimKiem.Controls.Add(this.btnTimKiem);
            this.groTimKiem.Controls.Add(this.txtTimKiem);
            this.groTimKiem.Controls.Add(this.lblTimKiemTheo);
            this.groTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groTimKiem.Location = new System.Drawing.Point(34, 25);
            this.groTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.groTimKiem.Name = "groTimKiem";
            this.groTimKiem.Padding = new System.Windows.Forms.Padding(2);
            this.groTimKiem.Size = new System.Drawing.Size(608, 196);
            this.groTimKiem.TabIndex = 4;
            this.groTimKiem.TabStop = false;
            this.groTimKiem.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTimKiem.Location = new System.Drawing.Point(192, 111);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(156, 44);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(260, 49);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(280, 30);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiemTheo
            // 
            this.lblTimKiemTheo.AutoSize = true;
            this.lblTimKiemTheo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTimKiemTheo.Location = new System.Drawing.Point(50, 52);
            this.lblTimKiemTheo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimKiemTheo.Name = "lblTimKiemTheo";
            this.lblTimKiemTheo.Size = new System.Drawing.Size(198, 25);
            this.lblTimKiemTheo.TabIndex = 0;
            this.lblTimKiemTheo.Text = "Tìm Kiếm Theo SĐT:";
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1627, 968);
            this.Controls.Add(this.groDanhSachKhachHang);
            this.Controls.Add(this.groChucNang);
            this.Controls.Add(this.groThongTinKhachHang);
            this.Controls.Add(this.groTimKiem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyKhachHang";
            this.Text = "frmQuanLyKhachHang";
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load_1);
            this.groDanhSachKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhachHang)).EndInit();
            this.groChucNang.ResumeLayout(false);
            this.groThongTinKhachHang.ResumeLayout(false);
            this.groThongTinKhachHang.PerformLayout();
            this.groTimKiem.ResumeLayout(false);
            this.groTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groDanhSachKhachHang;
        private System.Windows.Forms.GroupBox groChucNang;
        private System.Windows.Forms.GroupBox groThongTinKhachHang;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.ComboBox cboQuocTich;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblQuocTich;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.GroupBox groTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiemTheo;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.DataGridView dgvDanhSachKhachHang;
    }
}