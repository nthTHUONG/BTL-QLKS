namespace GUI
{
    partial class frmDatPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            this.txtMaDP = new System.Windows.Forms.TextBox();
            this.txtTenLP = new System.Windows.Forms.TextBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTraTruoc = new System.Windows.Forms.TextBox();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.cbbMaNV = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnThemKH);
            this.groupBox1.Controls.Add(this.cbbMaPhong);
            this.groupBox1.Controls.Add(this.cbbMaKH);
            this.groupBox1.Controls.Add(this.dtpNgayNhan);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.txtNgayDat);
            this.groupBox1.Controls.Add(this.txtMaDP);
            this.groupBox1.Controls.Add(this.txtTenLP);
            this.groupBox1.Controls.Add(this.dtpNgayTra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTraTruoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 260);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đặt Phòng:";
            // 
            // btnThemKH
            // 
            this.btnThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.Location = new System.Drawing.Point(351, 54);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(29, 29);
            this.btnThemKH.TabIndex = 81;
            this.btnThemKH.Text = "+";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(155, 94);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(224, 28);
            this.cbbMaPhong.TabIndex = 1;
            this.cbbMaPhong.SelectedIndexChanged += new System.EventHandler(this.cbbMaPhong_SelectedIndexChanged);
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(155, 54);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(181, 28);
            this.cbbMaKH.TabIndex = 0;
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.Checked = false;
            this.dtpNgayNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhan.Location = new System.Drawing.Point(535, 133);
            this.dtpNgayNhan.MinDate = new System.DateTime(2016, 12, 16, 0, 0, 0, 0);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(225, 26);
            this.dtpNgayNhan.TabIndex = 7;
            this.dtpNgayNhan.ValueChanged += new System.EventHandler(this.dtpNgayTra_ValueChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.SystemColors.Window;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(535, 174);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(225, 26);
            this.txtThanhTien.TabIndex = 8;
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.BackColor = System.Drawing.SystemColors.Window;
            this.txtNgayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDat.Location = new System.Drawing.Point(155, 133);
            this.txtNgayDat.Multiline = true;
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.ReadOnly = true;
            this.txtNgayDat.Size = new System.Drawing.Size(225, 26);
            this.txtNgayDat.TabIndex = 2;
            // 
            // txtMaDP
            // 
            this.txtMaDP.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDP.Location = new System.Drawing.Point(536, 54);
            this.txtMaDP.Multiline = true;
            this.txtMaDP.Name = "txtMaDP";
            this.txtMaDP.ReadOnly = true;
            this.txtMaDP.Size = new System.Drawing.Size(225, 26);
            this.txtMaDP.TabIndex = 5;
            // 
            // txtTenLP
            // 
            this.txtTenLP.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLP.Location = new System.Drawing.Point(536, 94);
            this.txtTenLP.Multiline = true;
            this.txtTenLP.Name = "txtTenLP";
            this.txtTenLP.ReadOnly = true;
            this.txtTenLP.Size = new System.Drawing.Size(225, 26);
            this.txtTenLP.TabIndex = 6;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(155, 171);
            this.dtpNgayTra.MinDate = new System.DateTime(2016, 12, 16, 0, 0, 0, 0);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(225, 26);
            this.dtpNgayTra.TabIndex = 3;
            this.dtpNgayTra.ValueChanged += new System.EventHandler(this.dtpNgayTra_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 77;
            this.label3.Text = "Mã KH:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(438, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 26);
            this.label9.TabIndex = 74;
            this.label9.Text = "Ghi chú:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 71;
            this.label1.Text = "Mã ĐP:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(438, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 26);
            this.label12.TabIndex = 77;
            this.label12.Text = "Loại phòng:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 77;
            this.label2.Text = "Mã phòng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 26);
            this.label5.TabIndex = 74;
            this.label5.Text = "Ngày đặt:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 26);
            this.label11.TabIndex = 74;
            this.label11.Text = "Trả trước:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(535, 214);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(225, 26);
            this.txtGhiChu.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 26);
            this.label10.TabIndex = 74;
            this.label10.Text = "Thành tiền";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 74;
            this.label4.Text = "Ngày nhận:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 26);
            this.label8.TabIndex = 74;
            this.label8.Text = "Ngày trả:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTraTruoc
            // 
            this.txtTraTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraTruoc.Location = new System.Drawing.Point(155, 214);
            this.txtTraTruoc.Multiline = true;
            this.txtTraTruoc.Name = "txtTraTruoc";
            this.txtTraTruoc.Size = new System.Drawing.Size(225, 26);
            this.txtTraTruoc.TabIndex = 4;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatPhong.BackColor = System.Drawing.Color.Gray;
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.Maroon;
            this.btnDatPhong.Location = new System.Drawing.Point(737, 421);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(101, 38);
            this.btnDatPhong.TabIndex = 0;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 105;
            this.label7.Text = "Nhân Viên:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTittle
            // 
            this.lbTittle.BackColor = System.Drawing.Color.Gray;
            this.lbTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Maroon;
            this.lbTittle.Location = new System.Drawing.Point(0, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(859, 65);
            this.lbTittle.TabIndex = 104;
            this.lbTittle.Text = "Đặt Phòng";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.AutoSize = true;
            this.cbbMaNV.Location = new System.Drawing.Point(125, 84);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(0, 20);
            this.cbbMaNV.TabIndex = 108;
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(859, 471);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Phòng";
            this.Load += new System.EventHandler(this.frmDatPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTraTruoc;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.TextBox txtTenLP;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtMaDP;
        private System.Windows.Forms.TextBox txtNgayDat;
        private System.Windows.Forms.Label cbbMaNV;
    }
}