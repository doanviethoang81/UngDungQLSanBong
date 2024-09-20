namespace CNPM_QuanLySanBong
{
    partial class frmNhanSan
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnNhanSan = new System.Windows.Forms.Button();
            this.btnXoaSan = new System.Windows.Forms.Button();
            this.btnSuaSan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboTrangThaiSan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID_DS = new System.Windows.Forms.TextBox();
            this.dtpNgayDa = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dtGKT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtGBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboMaSan = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboLoaiSan = new System.Windows.Forms.ComboBox();
            this.btnTimKH1 = new System.Windows.Forms.Button();
            this.txtTimKHNhanSan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dtgv_dsnhansan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsnhansan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.btnNhanSan);
            this.groupBox3.Controls.Add(this.btnXoaSan);
            this.groupBox3.Controls.Add(this.btnSuaSan);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(28, 383);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1626, 131);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(1273, 52);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(191, 44);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnNhanSan
            // 
            this.btnNhanSan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNhanSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanSan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNhanSan.Location = new System.Drawing.Point(115, 52);
            this.btnNhanSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhanSan.Name = "btnNhanSan";
            this.btnNhanSan.Size = new System.Drawing.Size(235, 45);
            this.btnNhanSan.TabIndex = 5;
            this.btnNhanSan.Text = "Nhận Sân";
            this.btnNhanSan.UseVisualStyleBackColor = false;
            this.btnNhanSan.Click += new System.EventHandler(this.btnNhanSan_Click);
            // 
            // btnXoaSan
            // 
            this.btnXoaSan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoaSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoaSan.Location = new System.Drawing.Point(871, 52);
            this.btnXoaSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaSan.Name = "btnXoaSan";
            this.btnXoaSan.Size = new System.Drawing.Size(238, 45);
            this.btnXoaSan.TabIndex = 4;
            this.btnXoaSan.Text = "Xóa sân đã đặt";
            this.btnXoaSan.UseVisualStyleBackColor = false;
            this.btnXoaSan.Click += new System.EventHandler(this.btnXoaSan_Click);
            // 
            // btnSuaSan
            // 
            this.btnSuaSan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSuaSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSuaSan.Location = new System.Drawing.Point(488, 52);
            this.btnSuaSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaSan.Name = "btnSuaSan";
            this.btnSuaSan.Size = new System.Drawing.Size(238, 45);
            this.btnSuaSan.TabIndex = 3;
            this.btnSuaSan.Text = "Sửa sân";
            this.btnSuaSan.UseVisualStyleBackColor = false;
            this.btnSuaSan.Click += new System.EventHandler(this.btnSuaSan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.cboTrangThaiSan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtID_DS);
            this.groupBox2.Controls.Add(this.dtpNgayDa);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dtGKT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtGBD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cboMaSan);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cboLoaiSan);
            this.groupBox2.Controls.Add(this.btnTimKH1);
            this.groupBox2.Controls.Add(this.txtTimKHNhanSan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTenKH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1632, 351);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhận Sân";
            // 
            // cboTrangThaiSan
            // 
            this.cboTrangThaiSan.FormattingEnabled = true;
            this.cboTrangThaiSan.Items.AddRange(new object[] {
            "Chưa vào sân",
            "Đã vào sân"});
            this.cboTrangThaiSan.Location = new System.Drawing.Point(962, 278);
            this.cboTrangThaiSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTrangThaiSan.Name = "cboTrangThaiSan";
            this.cboTrangThaiSan.Size = new System.Drawing.Size(317, 33);
            this.cboTrangThaiSan.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mã Đặt Sân";
            // 
            // txtID_DS
            // 
            this.txtID_DS.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtID_DS.Location = new System.Drawing.Point(32, 170);
            this.txtID_DS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID_DS.Name = "txtID_DS";
            this.txtID_DS.Size = new System.Drawing.Size(218, 30);
            this.txtID_DS.TabIndex = 31;
            // 
            // dtpNgayDa
            // 
            this.dtpNgayDa.CustomFormat = "yyyy/MM/dd";
            this.dtpNgayDa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDa.Location = new System.Drawing.Point(26, 276);
            this.dtpNgayDa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayDa.Name = "dtpNgayDa";
            this.dtpNgayDa.Size = new System.Drawing.Size(224, 30);
            this.dtpNgayDa.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label14.Location = new System.Drawing.Point(657, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 25);
            this.label14.TabIndex = 27;
            this.label14.Text = "Giờ kết thúc";
            // 
            // dtGKT
            // 
            this.dtGKT.CustomFormat = "HH:mm";
            this.dtGKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGKT.Location = new System.Drawing.Point(653, 279);
            this.dtGKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGKT.Name = "dtGKT";
            this.dtGKT.Size = new System.Drawing.Size(224, 30);
            this.dtGKT.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(345, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Giờ bắt đầu";
            // 
            // dtGBD
            // 
            this.dtGBD.CustomFormat = "HH:mm";
            this.dtGBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtGBD.Location = new System.Drawing.Point(341, 277);
            this.dtGBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGBD.Name = "dtGBD";
            this.dtGBD.Size = new System.Drawing.Size(224, 30);
            this.dtGBD.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(963, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Trạng thái sân";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(30, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ngày đá";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label16.Location = new System.Drawing.Point(345, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 25);
            this.label16.TabIndex = 20;
            this.label16.Text = "Mã Sân Bóng";
            // 
            // cboMaSan
            // 
            this.cboMaSan.FormattingEnabled = true;
            this.cboMaSan.Location = new System.Drawing.Point(341, 168);
            this.cboMaSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboMaSan.Name = "cboMaSan";
            this.cboMaSan.Size = new System.Drawing.Size(221, 33);
            this.cboMaSan.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Location = new System.Drawing.Point(657, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 25);
            this.label17.TabIndex = 18;
            this.label17.Text = "Loại Sân";
            // 
            // cboLoaiSan
            // 
            this.cboLoaiSan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboLoaiSan.FormattingEnabled = true;
            this.cboLoaiSan.Items.AddRange(new object[] {
            "Sân 5",
            "Sân 7",
            "Sân 11"});
            this.cboLoaiSan.Location = new System.Drawing.Point(653, 171);
            this.cboLoaiSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLoaiSan.Name = "cboLoaiSan";
            this.cboLoaiSan.Size = new System.Drawing.Size(224, 33);
            this.cboLoaiSan.TabIndex = 17;
            // 
            // btnTimKH1
            // 
            this.btnTimKH1.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTimKH1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKH1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKH1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKH1.Location = new System.Drawing.Point(1001, 48);
            this.btnTimKH1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKH1.Name = "btnTimKH1";
            this.btnTimKH1.Size = new System.Drawing.Size(178, 44);
            this.btnTimKH1.TabIndex = 3;
            this.btnTimKH1.Text = "Tìm";
            this.btnTimKH1.UseVisualStyleBackColor = false;
            this.btnTimKH1.Click += new System.EventHandler(this.btnTimKH1_Click);
            // 
            // txtTimKHNhanSan
            // 
            this.txtTimKHNhanSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKHNhanSan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTimKHNhanSan.Location = new System.Drawing.Point(516, 56);
            this.txtTimKHNhanSan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKHNhanSan.Name = "txtTimKHNhanSan";
            this.txtTimKHNhanSan.Size = new System.Drawing.Size(460, 30);
            this.txtTimKHNhanSan.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(273, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tìm Kiếm theo SĐT";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(961, 169);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(218, 30);
            this.txtTenKH.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(1274, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(963, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(1277, 171);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(218, 30);
            this.txtSDT.TabIndex = 0;
            // 
            // dtgv_dsnhansan
            // 
            this.dtgv_dsnhansan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_dsnhansan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dsnhansan.Location = new System.Drawing.Point(6, 41);
            this.dtgv_dsnhansan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_dsnhansan.Name = "dtgv_dsnhansan";
            this.dtgv_dsnhansan.RowHeadersWidth = 5;
            this.dtgv_dsnhansan.RowTemplate.Height = 24;
            this.dtgv_dsnhansan.Size = new System.Drawing.Size(1585, 377);
            this.dtgv_dsnhansan.TabIndex = 20;
            this.dtgv_dsnhansan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_dsnhansan_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_dsnhansan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 544);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1626, 436);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đặt sân";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmNhanSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1705, 1011);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhanSan";
            this.Text = "frmNhanSan";
            this.Load += new System.EventHandler(this.frmNhanSan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsnhansan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNhanSan;
        private System.Windows.Forms.Button btnXoaSan;
        private System.Windows.Forms.Button btnSuaSan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboMaSan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboLoaiSan;
        private System.Windows.Forms.Button btnTimKH1;
        private System.Windows.Forms.TextBox txtTimKHNhanSan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridView dtgv_dsnhansan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtGKT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtGBD;
        private System.Windows.Forms.DateTimePicker dtpNgayDa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID_DS;
        private System.Windows.Forms.ComboBox cboTrangThaiSan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCapNhat;
    }
}