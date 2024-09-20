namespace CNPM_QuanLySanBong
{
    partial class frmDoanhThu
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
            this.groChucNang = new System.Windows.Forms.GroupBox();
            this.dtpTuNg = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNg = new System.Windows.Forms.DateTimePicker();
            this.btnXemKetQua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labTongTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labSoHoaDon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.groChucNang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groChucNang
            // 
            this.groChucNang.Controls.Add(this.dtpTuNg);
            this.groChucNang.Controls.Add(this.dtpDenNg);
            this.groChucNang.Controls.Add(this.btnXemKetQua);
            this.groChucNang.Controls.Add(this.label3);
            this.groChucNang.Controls.Add(this.label2);
            this.groChucNang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groChucNang.Location = new System.Drawing.Point(12, 24);
            this.groChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groChucNang.Name = "groChucNang";
            this.groChucNang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groChucNang.Size = new System.Drawing.Size(1558, 94);
            this.groChucNang.TabIndex = 1;
            this.groChucNang.TabStop = false;
            this.groChucNang.Text = "Chức năng";
            // 
            // dtpTuNg
            // 
            this.dtpTuNg.CustomFormat = "yyyy/MM/dd";
            this.dtpTuNg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNg.Location = new System.Drawing.Point(234, 47);
            this.dtpTuNg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTuNg.Name = "dtpTuNg";
            this.dtpTuNg.Size = new System.Drawing.Size(200, 31);
            this.dtpTuNg.TabIndex = 8;
            // 
            // dtpDenNg
            // 
            this.dtpDenNg.CustomFormat = "yyyy/MM/dd";
            this.dtpDenNg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNg.Location = new System.Drawing.Point(929, 41);
            this.dtpDenNg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDenNg.Name = "dtpDenNg";
            this.dtpDenNg.Size = new System.Drawing.Size(200, 31);
            this.dtpDenNg.TabIndex = 8;
            // 
            // btnXemKetQua
            // 
            this.btnXemKetQua.AutoSize = true;
            this.btnXemKetQua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXemKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKetQua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXemKetQua.Location = new System.Drawing.Point(1276, 30);
            this.btnXemKetQua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemKetQua.Name = "btnXemKetQua";
            this.btnXemKetQua.Size = new System.Drawing.Size(192, 50);
            this.btnXemKetQua.TabIndex = 3;
            this.btnXemKetQua.Text = "Xem kết quả";
            this.btnXemKetQua.UseVisualStyleBackColor = false;
            this.btnXemKetQua.Click += new System.EventHandler(this.btnXemKetQua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(766, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(104, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDoanhThu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1558, 766);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(20, 38);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 25;
            this.dgvDoanhThu.RowTemplate.Height = 28;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1516, 705);
            this.dgvDoanhThu.TabIndex = 0;
            this.dgvDoanhThu.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDoanhThu_RowsAdded);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labTongTien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labSoHoaDon);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(12, 897);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1558, 90);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng tiền";
            // 
            // labTongTien
            // 
            this.labTongTien.AutoSize = true;
            this.labTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labTongTien.ForeColor = System.Drawing.Color.Red;
            this.labTongTien.Location = new System.Drawing.Point(1052, 38);
            this.labTongTien.Name = "labTongTien";
            this.labTongTien.Size = new System.Drawing.Size(62, 29);
            this.labTongTien.TabIndex = 0;
            this.labTongTien.Text = "Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(911, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền";
            // 
            // labSoHoaDon
            // 
            this.labSoHoaDon.AutoSize = true;
            this.labSoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labSoHoaDon.ForeColor = System.Drawing.Color.Red;
            this.labSoHoaDon.Location = new System.Drawing.Point(351, 38);
            this.labSoHoaDon.Name = "labSoHoaDon";
            this.labSoHoaDon.Size = new System.Drawing.Size(47, 29);
            this.labSoHoaDon.TabIndex = 0;
            this.labSoHoaDon.Text = "HĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(189, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Hóa đơn";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "yyyy/MM/dd";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(257, 43);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(256, 26);
            this.dtpDenNgay.TabIndex = 5;
            this.dtpDenNgay.Value = new System.DateTime(2024, 5, 12, 12, 0, 0, 0);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 1008);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groChucNang);
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            this.groChucNang.ResumeLayout(false);
            this.groChucNang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groChucNang;
        private System.Windows.Forms.Button btnXemKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labSoHoaDon;
        private System.Windows.Forms.DateTimePicker dtpTuNg;
        private System.Windows.Forms.DateTimePicker dtpDenNg;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
    }
}