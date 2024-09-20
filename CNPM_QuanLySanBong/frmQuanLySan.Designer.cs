namespace CNPM_QuanLySanBong
{
    partial class frmQuanLySan
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
            this.groTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groThongTinPhong = new System.Windows.Forms.GroupBox();
            this.txtSoNguoiToiDa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiSan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groChucNang = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSan = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groDanhSachSan = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachSan = new System.Windows.Forms.DataGridView();
            this.txtTenSan = new System.Windows.Forms.ComboBox();
            this.groTimKiem.SuspendLayout();
            this.groThongTinPhong.SuspendLayout();
            this.groChucNang.SuspendLayout();
            this.groDanhSachSan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSan)).BeginInit();
            this.SuspendLayout();
            // 
            // groTimKiem
            // 
            this.groTimKiem.Controls.Add(this.btnTimKiem);
            this.groTimKiem.Controls.Add(this.txtTimKiem);
            this.groTimKiem.Controls.Add(this.label1);
            this.groTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groTimKiem.Location = new System.Drawing.Point(28, 31);
            this.groTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groTimKiem.Name = "groTimKiem";
            this.groTimKiem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groTimKiem.Size = new System.Drawing.Size(565, 126);
            this.groTimKiem.TabIndex = 1;
            this.groTimKiem.TabStop = false;
            this.groTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSize = true;
            this.btnTimKiem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTimKiem.Location = new System.Drawing.Point(404, 38);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(145, 51);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(170, 46);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(212, 31);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sân";
            // 
            // groThongTinPhong
            // 
            this.groThongTinPhong.Controls.Add(this.txtTenSan);
            this.groThongTinPhong.Controls.Add(this.txtSoNguoiToiDa);
            this.groThongTinPhong.Controls.Add(this.label7);
            this.groThongTinPhong.Controls.Add(this.txtMaSan);
            this.groThongTinPhong.Controls.Add(this.label4);
            this.groThongTinPhong.Controls.Add(this.cboLoaiSan);
            this.groThongTinPhong.Controls.Add(this.label3);
            this.groThongTinPhong.Controls.Add(this.label2);
            this.groThongTinPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groThongTinPhong.Location = new System.Drawing.Point(28, 185);
            this.groThongTinPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groThongTinPhong.Name = "groThongTinPhong";
            this.groThongTinPhong.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groThongTinPhong.Size = new System.Drawing.Size(565, 454);
            this.groThongTinPhong.TabIndex = 2;
            this.groThongTinPhong.TabStop = false;
            this.groThongTinPhong.Text = "Thông tin phòng";
            // 
            // txtSoNguoiToiDa
            // 
            this.txtSoNguoiToiDa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoNguoiToiDa.Location = new System.Drawing.Point(343, 206);
            this.txtSoNguoiToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoNguoiToiDa.Name = "txtSoNguoiToiDa";
            this.txtSoNguoiToiDa.Size = new System.Drawing.Size(189, 30);
            this.txtSoNguoiToiDa.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(349, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Số người tối đa";
            // 
            // txtMaSan
            // 
            this.txtMaSan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaSan.Location = new System.Drawing.Point(26, 110);
            this.txtMaSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSan.Name = "txtMaSan";
            this.txtMaSan.Size = new System.Drawing.Size(182, 30);
            this.txtMaSan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(29, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên sân";
            // 
            // cboLoaiSan
            // 
            this.cboLoaiSan.FormattingEnabled = true;
            this.cboLoaiSan.Location = new System.Drawing.Point(343, 109);
            this.cboLoaiSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLoaiSan.Name = "cboLoaiSan";
            this.cboLoaiSan.Size = new System.Drawing.Size(188, 33);
            this.cboLoaiSan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(349, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại sân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sân";
            // 
            // groChucNang
            // 
            this.groChucNang.Controls.Add(this.btnXoa);
            this.groChucNang.Controls.Add(this.btnThemSan);
            this.groChucNang.Controls.Add(this.btnSua);
            this.groChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groChucNang.Location = new System.Drawing.Point(36, 672);
            this.groChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groChucNang.Name = "groChucNang";
            this.groChucNang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groChucNang.Size = new System.Drawing.Size(565, 189);
            this.groChucNang.TabIndex = 13;
            this.groChucNang.TabStop = false;
            this.groChucNang.Text = "Chức năng";
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnXoa.Location = new System.Drawing.Point(48, 104);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(195, 51);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThemSan
            // 
            this.btnThemSan.AutoSize = true;
            this.btnThemSan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThemSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnThemSan.Location = new System.Drawing.Point(48, 49);
            this.btnThemSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemSan.Name = "btnThemSan";
            this.btnThemSan.Size = new System.Drawing.Size(197, 51);
            this.btnThemSan.TabIndex = 13;
            this.btnThemSan.Text = "Thêm Sân";
            this.btnThemSan.UseVisualStyleBackColor = false;
            this.btnThemSan.Click += new System.EventHandler(this.btnThemSan_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSua.Location = new System.Drawing.Point(297, 49);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(188, 51);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // groDanhSachSan
            // 
            this.groDanhSachSan.Controls.Add(this.dgvDanhSachSan);
            this.groDanhSachSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groDanhSachSan.Location = new System.Drawing.Point(630, 13);
            this.groDanhSachSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groDanhSachSan.Name = "groDanhSachSan";
            this.groDanhSachSan.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groDanhSachSan.Size = new System.Drawing.Size(912, 893);
            this.groDanhSachSan.TabIndex = 14;
            this.groDanhSachSan.TabStop = false;
            this.groDanhSachSan.Text = "Danh sách sân";
            // 
            // dgvDanhSachSan
            // 
            this.dgvDanhSachSan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSan.Location = new System.Drawing.Point(34, 50);
            this.dgvDanhSachSan.Name = "dgvDanhSachSan";
            this.dgvDanhSachSan.RowHeadersWidth = 30;
            this.dgvDanhSachSan.RowTemplate.Height = 28;
            this.dgvDanhSachSan.Size = new System.Drawing.Size(853, 638);
            this.dgvDanhSachSan.TabIndex = 0;
            this.dgvDanhSachSan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSan_CellClick_1);
            // 
            // txtTenSan
            // 
            this.txtTenSan.FormattingEnabled = true;
            this.txtTenSan.Items.AddRange(new object[] {
            "Sân 5",
            "Sân 7",
            "Sân 11"});
            this.txtTenSan.Location = new System.Drawing.Point(26, 206);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.Size = new System.Drawing.Size(182, 33);
            this.txtTenSan.TabIndex = 12;
            // 
            // frmQuanLySan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1581, 919);
            this.Controls.Add(this.groDanhSachSan);
            this.Controls.Add(this.groChucNang);
            this.Controls.Add(this.groThongTinPhong);
            this.Controls.Add(this.groTimKiem);
            this.Name = "frmQuanLySan";
            this.Text = "frmQuanLySan";
            this.Load += new System.EventHandler(this.frmQuanLySan_Load);
            this.groTimKiem.ResumeLayout(false);
            this.groTimKiem.PerformLayout();
            this.groThongTinPhong.ResumeLayout(false);
            this.groThongTinPhong.PerformLayout();
            this.groChucNang.ResumeLayout(false);
            this.groChucNang.PerformLayout();
            this.groDanhSachSan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groThongTinPhong;
        private System.Windows.Forms.TextBox txtSoNguoiToiDa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoaiSan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groChucNang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemSan;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groDanhSachSan;
        private System.Windows.Forms.TextBox txtMaSan;
        private System.Windows.Forms.DataGridView dgvDanhSachSan;
        private System.Windows.Forms.ComboBox txtTenSan;
    }
}