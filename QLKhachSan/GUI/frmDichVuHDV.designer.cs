namespace GUI
{
    partial class frmDichVuHDV
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btReset = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbMaHDV = new System.Windows.Forms.ComboBox();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtIDDVhdv = new System.Windows.Forms.TextBox();
            this.txtSoNgayThue = new System.Windows.Forms.TextBox();
            this.txtTraTruoc = new System.Windows.Forms.TextBox();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDVhdv = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVhdv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tìm kiếm:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btReset);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 326);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sử dụng dịch vụ";
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btReset.Location = new System.Drawing.Point(523, 227);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(94, 44);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btXoa.Location = new System.Drawing.Point(523, 171);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(94, 44);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSua.Location = new System.Drawing.Point(523, 115);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(94, 44);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThem.Location = new System.Drawing.Point(523, 59);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(94, 44);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbMaHDV);
            this.panel1.Controls.Add(this.cbbMaKH);
            this.panel1.Controls.Add(this.dtpNgayThue);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.txtIDDVhdv);
            this.panel1.Controls.Add(this.txtSoNgayThue);
            this.panel1.Controls.Add(this.txtTraTruoc);
            this.panel1.Controls.Add(this.txtGiaThue);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(36, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 275);
            this.panel1.TabIndex = 26;
            // 
            // cbbMaHDV
            // 
            this.cbbMaHDV.FormattingEnabled = true;
            this.cbbMaHDV.Location = new System.Drawing.Point(132, 75);
            this.cbbMaHDV.Name = "cbbMaHDV";
            this.cbbMaHDV.Size = new System.Drawing.Size(292, 28);
            this.cbbMaHDV.TabIndex = 2;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(132, 42);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(292, 28);
            this.cbbMaKH.TabIndex = 1;
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThue.Location = new System.Drawing.Point(132, 108);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(293, 27);
            this.dtpNgayThue.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 27);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ghi chú:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(132, 236);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(293, 27);
            this.txtGhiChu.TabIndex = 7;
            // 
            // txtIDDVhdv
            // 
            this.txtIDDVhdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDVhdv.Location = new System.Drawing.Point(133, 10);
            this.txtIDDVhdv.Name = "txtIDDVhdv";
            this.txtIDDVhdv.Size = new System.Drawing.Size(291, 27);
            this.txtIDDVhdv.TabIndex = 0;
            // 
            // txtSoNgayThue
            // 
            this.txtSoNgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayThue.Location = new System.Drawing.Point(132, 140);
            this.txtSoNgayThue.Name = "txtSoNgayThue";
            this.txtSoNgayThue.Size = new System.Drawing.Size(293, 27);
            this.txtSoNgayThue.TabIndex = 4;
            // 
            // txtTraTruoc
            // 
            this.txtTraTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraTruoc.Location = new System.Drawing.Point(132, 204);
            this.txtTraTruoc.Name = "txtTraTruoc";
            this.txtTraTruoc.Size = new System.Drawing.Size(293, 27);
            this.txtTraTruoc.TabIndex = 6;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaThue.Location = new System.Drawing.Point(132, 172);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(293, 27);
            this.txtGiaThue.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 27);
            this.label9.TabIndex = 23;
            this.label9.Text = "Số ngày thuê:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 27);
            this.label10.TabIndex = 23;
            this.label10.Text = "Trả trước:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "Giá thuê:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày thuê:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã HDV:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 27);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã KH:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "IDDvHDV:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(110, 415);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(292, 27);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(656, 67);
            this.label8.TabIndex = 23;
            this.label8.Text = "Dịch Vụ HDV";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDVhdv
            // 
            this.dgvDVhdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDVhdv.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDVhdv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDVhdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVhdv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDVhdv.GridColor = System.Drawing.Color.LightGreen;
            this.dgvDVhdv.Location = new System.Drawing.Point(0, 448);
            this.dgvDVhdv.Name = "dgvDVhdv";
            this.dgvDVhdv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDVhdv.Size = new System.Drawing.Size(656, 139);
            this.dgvDVhdv.TabIndex = 26;
            this.dgvDVhdv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVhdv_CellClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(514, 402);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(117, 40);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // frmDichVuHDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 587);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dgvDVhdv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "frmDichVuHDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch vụ hướng dẫn viên";
            this.Load += new System.EventHandler(this.frmDichVuHDV_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVhdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtIDDVhdv;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDVhdv;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.ComboBox cbbMaHDV;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.TextBox txtSoNgayThue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTraTruoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnThanhToan;
    }
}