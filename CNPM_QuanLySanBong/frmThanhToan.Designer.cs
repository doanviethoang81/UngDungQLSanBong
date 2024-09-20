namespace CNPM_QuanLySanBong
{
    partial class frmThanhToan
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btThanhToanTongTien = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDSSanChuaThanhToan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKHThanhToan = new System.Windows.Forms.Button();
            this.txtTimKHThanhToan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanChuaThanhToan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btThanhToanTongTien);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 828);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1563, 130);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh Toán";
            // 
            // btThanhToanTongTien
            // 
            this.btThanhToanTongTien.BackColor = System.Drawing.Color.SteelBlue;
            this.btThanhToanTongTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThanhToanTongTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThanhToanTongTien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btThanhToanTongTien.Location = new System.Drawing.Point(411, 49);
            this.btThanhToanTongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btThanhToanTongTien.Name = "btThanhToanTongTien";
            this.btThanhToanTongTien.Size = new System.Drawing.Size(742, 45);
            this.btThanhToanTongTien.TabIndex = 32;
            this.btThanhToanTongTien.Text = "Thanh Toán ";
            this.btThanhToanTongTien.UseVisualStyleBackColor = false;
            this.btThanhToanTongTien.Click += new System.EventHandler(this.btThanhToanTongTien_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDSSanChuaThanhToan);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1563, 672);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sân bóng chưa thanh toán";
            // 
            // dgvDSSanChuaThanhToan
            // 
            this.dgvDSSanChuaThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSanChuaThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSanChuaThanhToan.Location = new System.Drawing.Point(22, 39);
            this.dgvDSSanChuaThanhToan.Name = "dgvDSSanChuaThanhToan";
            this.dgvDSSanChuaThanhToan.RowHeadersWidth = 25;
            this.dgvDSSanChuaThanhToan.RowTemplate.Height = 28;
            this.dgvDSSanChuaThanhToan.Size = new System.Drawing.Size(1526, 615);
            this.dgvDSSanChuaThanhToan.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKHThanhToan);
            this.groupBox1.Controls.Add(this.txtTimKHThanhToan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1538, 104);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm khách hàng";
            // 
            // btnTimKHThanhToan
            // 
            this.btnTimKHThanhToan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTimKHThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKHThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKHThanhToan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKHThanhToan.Location = new System.Drawing.Point(874, 35);
            this.btnTimKHThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKHThanhToan.Name = "btnTimKHThanhToan";
            this.btnTimKHThanhToan.Size = new System.Drawing.Size(199, 44);
            this.btnTimKHThanhToan.TabIndex = 17;
            this.btnTimKHThanhToan.Text = "Tìm";
            this.btnTimKHThanhToan.UseVisualStyleBackColor = false;
            this.btnTimKHThanhToan.Click += new System.EventHandler(this.btnTimKHThanhToan_Click);
            // 
            // txtTimKHThanhToan
            // 
            this.txtTimKHThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKHThanhToan.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTimKHThanhToan.Location = new System.Drawing.Point(421, 42);
            this.txtTimKHThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKHThanhToan.Name = "txtTimKHThanhToan";
            this.txtTimKHThanhToan.Size = new System.Drawing.Size(412, 30);
            this.txtTimKHThanhToan.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(198, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tìm Kiếm theo SĐT";
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1605, 993);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmThanhToan";
            this.Text = "frmThanhToan";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanChuaThanhToan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btThanhToanTongTien;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDSSanChuaThanhToan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKHThanhToan;
        private System.Windows.Forms.TextBox txtTimKHThanhToan;
        private System.Windows.Forms.Label label2;
    }
}