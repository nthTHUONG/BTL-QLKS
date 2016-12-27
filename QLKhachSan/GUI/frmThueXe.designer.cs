namespace GUI
{
    partial class frmThueXe
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
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThueXe = new System.Windows.Forms.DataGridView();
            this.txtIDThueXe = new System.Windows.Forms.TextBox();
            this.txtIDKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.timerXe = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThueXe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.Gray;
            this.btnThanhToan.ForeColor = System.Drawing.Color.Maroon;
            this.btnThanhToan.Location = new System.Drawing.Point(622, 395);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(146, 30);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Gray;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Maroon;
            this.btnThem.Location = new System.Drawing.Point(644, 180);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 33);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.BackColor = System.Drawing.Color.Silver;
            this.lblTongTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(408, 395);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(149, 28);
            this.lblTongTien.TabIndex = 107;
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(8, 406);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(0, 18);
            this.lbTime.TabIndex = 109;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(296, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 110;
            this.label6.Text = "Tiền phải trả:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "Mã Thuê Xe:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 114;
            this.label3.Text = "Nhân Viên:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTittle
            // 
            this.lbTittle.BackColor = System.Drawing.Color.Gray;
            this.lbTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Maroon;
            this.lbTittle.Location = new System.Drawing.Point(0, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(814, 65);
            this.lbTittle.TabIndex = 105;
            this.lbTittle.Text = "Thông tin thuê xe";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 114;
            this.label1.Text = "Mã KH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvThueXe
            // 
            this.dgvThueXe.AllowUserToAddRows = false;
            this.dgvThueXe.AllowUserToDeleteRows = false;
            this.dgvThueXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThueXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThueXe.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvThueXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThueXe.Location = new System.Drawing.Point(8, 231);
            this.dgvThueXe.Name = "dgvThueXe";
            this.dgvThueXe.ReadOnly = true;
            this.dgvThueXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThueXe.Size = new System.Drawing.Size(794, 158);
            this.dgvThueXe.TabIndex = 106;
            this.dgvThueXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThueXe_CellClick);
            // 
            // txtIDThueXe
            // 
            this.txtIDThueXe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIDThueXe.Location = new System.Drawing.Point(119, 85);
            this.txtIDThueXe.Name = "txtIDThueXe";
            this.txtIDThueXe.ReadOnly = true;
            this.txtIDThueXe.Size = new System.Drawing.Size(120, 26);
            this.txtIDThueXe.TabIndex = 0;
            // 
            // txtIDKhachHang
            // 
            this.txtIDKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtIDKhachHang.Location = new System.Drawing.Point(119, 117);
            this.txtIDKhachHang.Name = "txtIDKhachHang";
            this.txtIDKhachHang.Size = new System.Drawing.Size(120, 26);
            this.txtIDKhachHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 113;
            this.label2.Text = "Mã Xe:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaXe
            // 
            this.txtMaXe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaXe.Location = new System.Drawing.Point(119, 149);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(120, 26);
            this.txtMaXe.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 113;
            this.label5.Text = "Giá Thuê:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGiaThue.Location = new System.Drawing.Point(398, 75);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(120, 26);
            this.txtGiaThue.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(289, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 113;
            this.label7.Text = "Tiền Cọc:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTienCoc.Location = new System.Drawing.Point(398, 107);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(120, 26);
            this.txtTienCoc.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 26);
            this.label10.TabIndex = 121;
            this.label10.Text = "Ngày mượn: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(115, 181);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(172, 26);
            this.dtpNgayMuon.TabIndex = 3;
            // 
            // timerXe
            // 
            this.timerXe.Enabled = true;
            this.timerXe.Interval = 1000;
            this.timerXe.Tick += new System.EventHandler(this.timerXe_Tick);
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTime.BackColor = System.Drawing.Color.Silver;
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Location = new System.Drawing.Point(8, 413);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(231, 19);
            this.txtTime.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(563, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 122;
            this.label8.Text = "VNĐ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.AutoSize = true;
            this.cbbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaNV.Location = new System.Drawing.Point(670, 75);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(0, 20);
            this.cbbMaNV.TabIndex = 114;
            this.cbbMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmThueXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(814, 451);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtIDKhachHang);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.txtGiaThue);
            this.Controls.Add(this.txtMaXe);
            this.Controls.Add(this.txtIDThueXe);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvThueXe);
            this.Controls.Add(this.lbTittle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThueXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê Xe";
            this.Load += new System.EventHandler(this.ThueXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThueXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThueXe;
        private System.Windows.Forms.TextBox txtIDThueXe;
        private System.Windows.Forms.TextBox txtIDKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Timer timerXe;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label cbbMaNV;
    }
}