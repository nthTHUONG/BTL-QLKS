using System.Windows.Forms;

namespace GUI
{
    partial class frmMain
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.rdDaDat = new System.Windows.Forms.RadioButton();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.lstLoaiPhong = new System.Windows.Forms.ComboBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnDisplay = new System.Windows.Forms.Panel();
            this.rdTatCa = new System.Windows.Forms.RadioButton();
            this.rdTrong = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thựcPhẩmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thuêXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cơSởVậtChấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánThựcPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánThuêXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánDVHướngDẫnViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đangPhátTriểnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMain.SuspendLayout();
            this.pnDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatPhong.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Location = new System.Drawing.Point(773, 0);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(96, 36);
            this.btnDatPhong.TabIndex = 0;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.DimGray;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(0, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(872, 79);
            this.lbTitle.TabIndex = 96;
            this.lbTitle.Text = "Quản Lý Đặt Phòng";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdDaDat
            // 
            this.rdDaDat.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdDaDat.AutoCheck = false;
            this.rdDaDat.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rdDaDat.Location = new System.Drawing.Point(96, 0);
            this.rdDaDat.Name = "rdDaDat";
            this.rdDaDat.Size = new System.Drawing.Size(96, 36);
            this.rdDaDat.TabIndex = 1;
            this.rdDaDat.TabStop = true;
            this.rdDaDat.Text = "Đã đặt";
            this.rdDaDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdDaDat.UseVisualStyleBackColor = false;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(435, 159);
            this.dtpNgayTra.MaxDate = new System.DateTime(6969, 9, 9, 0, 0, 0, 0);
            this.dtpNgayTra.MinDate = new System.DateTime(1999, 9, 9, 0, 0, 0, 0);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(173, 29);
            this.dtpNgayTra.TabIndex = 101;
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhan.Location = new System.Drawing.Point(221, 159);
            this.dtpNgayNhan.MaxDate = new System.DateTime(6969, 9, 9, 0, 0, 0, 0);
            this.dtpNgayNhan.MinDate = new System.DateTime(1999, 9, 9, 0, 0, 0, 0);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(173, 29);
            this.dtpNgayNhan.TabIndex = 102;
            // 
            // lstLoaiPhong
            // 
            this.lstLoaiPhong.FormattingEnabled = true;
            this.lstLoaiPhong.Location = new System.Drawing.Point(8, 159);
            this.lstLoaiPhong.Name = "lstLoaiPhong";
            this.lstLoaiPhong.Size = new System.Drawing.Size(173, 28);
            this.lstLoaiPhong.TabIndex = 100;
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMain.Controls.Add(this.pnDisplay);
            this.pnMain.Controls.Add(this.btnDatPhong);
            this.pnMain.Controls.Add(this.pictureBox);
            this.pnMain.Location = new System.Drawing.Point(0, 220);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(872, 407);
            this.pnMain.TabIndex = 88;
            // 
            // pnDisplay
            // 
            this.pnDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDisplay.Controls.Add(this.rdTatCa);
            this.pnDisplay.Controls.Add(this.rdTrong);
            this.pnDisplay.Controls.Add(this.rdDaDat);
            this.pnDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(291, 39);
            this.pnDisplay.TabIndex = 0;
            // 
            // rdTatCa
            // 
            this.rdTatCa.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdTatCa.AutoCheck = false;
            this.rdTatCa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rdTatCa.Location = new System.Drawing.Point(192, 0);
            this.rdTatCa.Name = "rdTatCa";
            this.rdTatCa.Size = new System.Drawing.Size(96, 36);
            this.rdTatCa.TabIndex = 2;
            this.rdTatCa.TabStop = true;
            this.rdTatCa.Text = "Tất cả";
            this.rdTatCa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdTatCa.UseVisualStyleBackColor = false;
            // 
            // rdTrong
            // 
            this.rdTrong.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdTrong.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rdTrong.Location = new System.Drawing.Point(0, 0);
            this.rdTrong.Name = "rdTrong";
            this.rdTrong.Size = new System.Drawing.Size(96, 36);
            this.rdTrong.TabIndex = 0;
            this.rdTrong.TabStop = true;
            this.rdTrong.Text = "Trống";
            this.rdTrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdTrong.UseVisualStyleBackColor = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(868, 403);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(815, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 26);
            this.label7.TabIndex = 97;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(758, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 26);
            this.label6.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(701, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 99;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(872, 28);
            this.menuStrip.TabIndex = 95;
            this.menuStrip.Text = "menuStrip";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.dịchVụToolStripMenuItem,
            this.cơSởVậtChấtToolStripMenuItem,
            this.đặtPhòngToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchHàngToolStripMenuItem,
            this.thêmKháchHàngToolStripMenuItem});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            this.thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            this.thôngTinKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            this.thôngTinKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchHàngToolStripMenuItem_Click);
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            this.thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            this.thêmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.thêmKháchHàngToolStripMenuItem.Text = "Thêm khách hàng";
            this.thêmKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thêmKháchHàngToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // dịchVụToolStripMenuItem
            // 
            this.dịchVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huowToolStripMenuItem,
            this.thựcPhẩmToolStripMenuItem1,
            this.thuêXeToolStripMenuItem});
            this.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            this.dịchVụToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.dịchVụToolStripMenuItem.Text = "Dịch vụ";
            // 
            // huowToolStripMenuItem
            // 
            this.huowToolStripMenuItem.Name = "huowToolStripMenuItem";
            this.huowToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.huowToolStripMenuItem.Text = "Hướng dẫn viên";
            this.huowToolStripMenuItem.Click += new System.EventHandler(this.huowToolStripMenuItem_Click);
            // 
            // thựcPhẩmToolStripMenuItem1
            // 
            this.thựcPhẩmToolStripMenuItem1.Name = "thựcPhẩmToolStripMenuItem1";
            this.thựcPhẩmToolStripMenuItem1.Size = new System.Drawing.Size(203, 24);
            this.thựcPhẩmToolStripMenuItem1.Text = "Thực phẩm";
            this.thựcPhẩmToolStripMenuItem1.Click += new System.EventHandler(this.thựcPhẩmToolStripMenuItem1_Click);
            // 
            // thuêXeToolStripMenuItem
            // 
            this.thuêXeToolStripMenuItem.Name = "thuêXeToolStripMenuItem";
            this.thuêXeToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.thuêXeToolStripMenuItem.Text = "Thuê xe";
            this.thuêXeToolStripMenuItem.Click += new System.EventHandler(this.thuêXeToolStripMenuItem_Click);
            // 
            // cơSởVậtChấtToolStripMenuItem
            // 
            this.cơSởVậtChấtToolStripMenuItem.Name = "cơSởVậtChấtToolStripMenuItem";
            this.cơSởVậtChấtToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.cơSởVậtChấtToolStripMenuItem.Text = "Cơ sở vật chất";
            this.cơSởVậtChấtToolStripMenuItem.Click += new System.EventHandler(this.cơSởVậtChấtToolStripMenuItem_Click);
            // 
            // đặtPhòngToolStripMenuItem
            // 
            this.đặtPhòngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiPhòngToolStripMenuItem,
            this.phòngToolStripMenuItem,
            this.hToolStripMenuItem});
            this.đặtPhòngToolStripMenuItem.Name = "đặtPhòngToolStripMenuItem";
            this.đặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.đặtPhòngToolStripMenuItem.Text = "Đặt phòng";
            // 
            // loạiPhòngToolStripMenuItem
            // 
            this.loạiPhòngToolStripMenuItem.Name = "loạiPhòngToolStripMenuItem";
            this.loạiPhòngToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.loạiPhòngToolStripMenuItem.Text = "Loại phòng";
            this.loạiPhòngToolStripMenuItem.Click += new System.EventHandler(this.loạiPhòngToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.phòngToolStripMenuItem.Text = "Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem,
            this.inHóaĐơnToolStripMenuItem,
            this.xuấtBáoCáoToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánThựcPhẩmToolStripMenuItem,
            this.thanhToánPhòngToolStripMenuItem,
            this.thanhToánThuêXeToolStripMenuItem,
            this.thanhToánDVHướngDẫnViênToolStripMenuItem});
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            // 
            // thanhToánThựcPhẩmToolStripMenuItem
            // 
            this.thanhToánThựcPhẩmToolStripMenuItem.Name = "thanhToánThựcPhẩmToolStripMenuItem";
            this.thanhToánThựcPhẩmToolStripMenuItem.Size = new System.Drawing.Size(329, 24);
            this.thanhToánThựcPhẩmToolStripMenuItem.Text = "Thanh toán thực phẩm";
            this.thanhToánThựcPhẩmToolStripMenuItem.Click += new System.EventHandler(this.thanhToánThựcPhẩmToolStripMenuItem_Click);
            // 
            // thanhToánPhòngToolStripMenuItem
            // 
            this.thanhToánPhòngToolStripMenuItem.Name = "thanhToánPhòngToolStripMenuItem";
            this.thanhToánPhòngToolStripMenuItem.Size = new System.Drawing.Size(329, 24);
            this.thanhToánPhòngToolStripMenuItem.Text = "Thanh toán Phòng";
            this.thanhToánPhòngToolStripMenuItem.Click += new System.EventHandler(this.thanhToánPhòngToolStripMenuItem_Click);
            // 
            // thanhToánThuêXeToolStripMenuItem
            // 
            this.thanhToánThuêXeToolStripMenuItem.Name = "thanhToánThuêXeToolStripMenuItem";
            this.thanhToánThuêXeToolStripMenuItem.Size = new System.Drawing.Size(329, 24);
            this.thanhToánThuêXeToolStripMenuItem.Text = "Thanh toán thuê xe";
            this.thanhToánThuêXeToolStripMenuItem.Click += new System.EventHandler(this.thanhToánThuêXeToolStripMenuItem_Click);
            // 
            // thanhToánDVHướngDẫnViênToolStripMenuItem
            // 
            this.thanhToánDVHướngDẫnViênToolStripMenuItem.Name = "thanhToánDVHướngDẫnViênToolStripMenuItem";
            this.thanhToánDVHướngDẫnViênToolStripMenuItem.Size = new System.Drawing.Size(329, 24);
            this.thanhToánDVHướngDẫnViênToolStripMenuItem.Text = "Thanh toán DV Hướng dẫn viên";
            this.thanhToánDVHướngDẫnViênToolStripMenuItem.Click += new System.EventHandler(this.thanhToánDVHướngDẫnViênToolStripMenuItem_Click);
            // 
            // inHóaĐơnToolStripMenuItem
            // 
            this.inHóaĐơnToolStripMenuItem.Name = "inHóaĐơnToolStripMenuItem";
            this.inHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.inHóaĐơnToolStripMenuItem.Text = "In hóa đơn";
            this.inHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.inHóaĐơnToolStripMenuItem_Click);
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất báo cáo";
            this.xuấtBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.xuấtBáoCáoToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đangPhátTriểnToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // đangPhátTriểnToolStripMenuItem
            // 
            this.đangPhátTriểnToolStripMenuItem.Name = "đangPhátTriểnToolStripMenuItem";
            this.đangPhátTriểnToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.đangPhátTriểnToolStripMenuItem.Text = "Đang phát triển";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 92;
            this.label2.Text = "Ngày trả phòng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 94;
            this.label3.Text = "Loại phòng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(812, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 89;
            this.label10.Text = "Đang ở";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(698, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 91;
            this.label8.Text = "Trống";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(755, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 18);
            this.label9.TabIndex = 90;
            this.label9.Text = "Đã đặt";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 93;
            this.label1.Text = "Ngày nhận phòng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.hToolStripMenuItem.Text = "Hình ảnh";
            this.hToolStripMenuItem.Click += new System.EventHandler(this.hToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(872, 628);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.dtpNgayNhan);
            this.Controls.Add(this.lstLoaiPhong);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(888, 666);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnMain.ResumeLayout(false);
            this.pnDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.RadioButton rdDaDat;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.ComboBox lstLoaiPhong;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnDisplay;
        private System.Windows.Forms.RadioButton rdTatCa;
        private System.Windows.Forms.RadioButton rdTrong;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đangPhátTriểnToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private ToolStripMenuItem cơSởVậtChấtToolStripMenuItem;
        private ToolStripMenuItem huowToolStripMenuItem;
        private ToolStripMenuItem thựcPhẩmToolStripMenuItem1;
        private ToolStripMenuItem thuêXeToolStripMenuItem;
        private ToolStripMenuItem thanhToánThựcPhẩmToolStripMenuItem;
        private ToolStripMenuItem thanhToánPhòngToolStripMenuItem;
        private ToolStripMenuItem thanhToánThuêXeToolStripMenuItem;
        private ToolStripMenuItem thanhToánDVHướngDẫnViênToolStripMenuItem;
        private ToolStripMenuItem đặtPhòngToolStripMenuItem;
        private ToolStripMenuItem loạiPhòngToolStripMenuItem;
        private ToolStripMenuItem phòngToolStripMenuItem;
        private ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem hToolStripMenuItem;

        public AutoScaleMode AutoScaleMode { get; private set; }
    }
}