namespace GUI
{
    partial class frmThanhToanHDTP
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
            this.dgvHDTP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDHoaDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayMua = new System.Windows.Forms.DateTimePicker();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.cbbIDKhachHang = new System.Windows.Forms.ComboBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDTP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHDTP
            // 
            this.dgvHDTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDTP.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvHDTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDTP.Location = new System.Drawing.Point(12, 247);
            this.dgvHDTP.Name = "dgvHDTP";
            this.dgvHDTP.RowHeadersVisible = false;
            this.dgvHDTP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDTP.Size = new System.Drawing.Size(668, 150);
            this.dgvHDTP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã HD: ";
            // 
            // txtIDHoaDon
            // 
            this.txtIDHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIDHoaDon.Location = new System.Drawing.Point(118, 44);
            this.txtIDHoaDon.Name = "txtIDHoaDon";
            this.txtIDHoaDon.ReadOnly = true;
            this.txtIDHoaDon.Size = new System.Drawing.Size(216, 26);
            this.txtIDHoaDon.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã KH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã NV: ";
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIDNhanVien.Location = new System.Drawing.Point(117, 110);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.ReadOnly = true;
            this.txtIDNhanVien.Size = new System.Drawing.Size(217, 26);
            this.txtIDNhanVien.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày mua: ";
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMua.Location = new System.Drawing.Point(117, 142);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(217, 26);
            this.dtpNgayMua.TabIndex = 3;
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTongTien.Location = new System.Drawing.Point(461, 157);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(209, 29);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng tiền:";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(459, 198);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(128, 46);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cbbIDKhachHang
            // 
            this.cbbIDKhachHang.FormattingEnabled = true;
            this.cbbIDKhachHang.Location = new System.Drawing.Point(117, 76);
            this.cbbIDKhachHang.Name = "cbbIDKhachHang";
            this.cbbIDKhachHang.Size = new System.Drawing.Size(217, 28);
            this.cbbIDKhachHang.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(599, 198);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(70, 45);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayMua);
            this.groupBox1.Controls.Add(this.txtIDNhanVien);
            this.groupBox1.Controls.Add(this.txtIDHoaDon);
            this.groupBox1.Controls.Add(this.cbbIDKhachHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 184);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimKiem.Location = new System.Drawing.Point(114, 218);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(242, 26);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // frmThanhToanHDTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(692, 403);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvHDTP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(708, 441);
            this.Name = "frmThanhToanHDTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán hóa đơn thực phẩm";
            this.Load += new System.EventHandler(this.ThanhToanHDTP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDTP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayMua;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.ComboBox cbbIDKhachHang;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}