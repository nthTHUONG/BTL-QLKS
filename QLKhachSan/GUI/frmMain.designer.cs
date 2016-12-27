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
            this.lbTitle = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lbEmpty = new System.Windows.Forms.Label();
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
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánThựcPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánThuêXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánDVHướngDẫnViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTThựcPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tTNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đangPhátTriểnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbPlaced = new System.Windows.Forms.Label();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.pnlChoose = new System.Windows.Forms.Panel();
            this.rdTrong = new System.Windows.Forms.RadioButton();
            this.rdTatCa = new System.Windows.Forms.RadioButton();
            this.rdDaDat = new System.Windows.Forms.RadioButton();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.pnlChoose.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.dtpNgayTra.TabIndex = 2;
            this.dtpNgayTra.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
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
            this.dtpNgayNhan.TabIndex = 1;
            this.dtpNgayNhan.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // cbbLoaiPhong
            // 
            this.cbbLoaiPhong.FormattingEnabled = true;
            this.cbbLoaiPhong.Location = new System.Drawing.Point(8, 159);
            this.cbbLoaiPhong.Name = "cbbLoaiPhong";
            this.cbbLoaiPhong.Size = new System.Drawing.Size(173, 28);
            this.cbbLoaiPhong.TabIndex = 0;
            this.cbbLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiPhong_SelectedIndexChanged);
            this.cbbLoaiPhong.Click += new System.EventHandler(this.cbbLoaiPhong_Click);
            // 
            // lbEmpty
            // 
            this.lbEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmpty.BackColor = System.Drawing.Color.LimeGreen;
            this.lbEmpty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEmpty.Location = new System.Drawing.Point(758, 159);
            this.lbEmpty.Name = "lbEmpty";
            this.lbEmpty.Size = new System.Drawing.Size(40, 26);
            this.lbEmpty.TabIndex = 98;
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
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.hToolStripMenuItem.Text = "Hình ảnh";
            this.hToolStripMenuItem.Click += new System.EventHandler(this.hToolStripMenuItem_Click);
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
        
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tTThựcPhẩmToolStripMenuItem,
            this.tTKháchHàngToolStripMenuItem,
            this.tTNhânViênToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất báo cáo";
     
            // 
            // tTThựcPhẩmToolStripMenuItem
            // 
            this.tTThựcPhẩmToolStripMenuItem.Name = "tTThựcPhẩmToolStripMenuItem";
            this.tTThựcPhẩmToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.tTThựcPhẩmToolStripMenuItem.Text = "TT Thực phẩm";
            this.tTThựcPhẩmToolStripMenuItem.Click += new System.EventHandler(this.tTThựcPhẩmToolStripMenuItem_Click);
            // 
            // tTKháchHàngToolStripMenuItem
            // 
            this.tTKháchHàngToolStripMenuItem.Name = "tTKháchHàngToolStripMenuItem";
            this.tTKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.tTKháchHàngToolStripMenuItem.Text = "TT Khách Hàng";
            this.tTKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.tTKháchHàngToolStripMenuItem_Click);
            // 
            // tTNhânViênToolStripMenuItem
            // 
            this.tTNhânViênToolStripMenuItem.Name = "tTNhânViênToolStripMenuItem";
            this.tTNhânViênToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.tTNhânViênToolStripMenuItem.Text = "TT Nhân Viên";
            this.tTNhânViênToolStripMenuItem.Click += new System.EventHandler(this.tTNhânViênToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
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
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(755, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 90;
            this.label9.Text = "Trống";
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
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(812, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 89;
            this.label10.Text = "Đã đặt";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlaced
            // 
            this.lbPlaced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlaced.BackColor = System.Drawing.Color.DarkOrange;
            this.lbPlaced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPlaced.Location = new System.Drawing.Point(815, 159);
            this.lbPlaced.Name = "lbPlaced";
            this.lbPlaced.Size = new System.Drawing.Size(40, 26);
            this.lbPlaced.TabIndex = 97;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatPhong.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Location = new System.Drawing.Point(773, -1);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(96, 36);
            this.btnDatPhong.TabIndex = 0;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // pnlChoose
            // 
            this.pnlChoose.BackColor = System.Drawing.SystemColors.Control;
            this.pnlChoose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChoose.Controls.Add(this.rdTrong);
            this.pnlChoose.Controls.Add(this.rdTatCa);
            this.pnlChoose.Controls.Add(this.rdDaDat);
            this.pnlChoose.Location = new System.Drawing.Point(-1, -2);
            this.pnlChoose.Name = "pnlChoose";
            this.pnlChoose.Size = new System.Drawing.Size(310, 40);
            this.pnlChoose.TabIndex = 0;
            // 
            // rdTrong
            // 
            this.rdTrong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdTrong.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rdTrong.Location = new System.Drawing.Point(1, 2);
            this.rdTrong.Name = "rdTrong";
            this.rdTrong.Size = new System.Drawing.Size(96, 36);
            this.rdTrong.TabIndex = 0;
            this.rdTrong.Text = "Trống";
            this.rdTrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdTrong.UseVisualStyleBackColor = false;
            this.rdTrong.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdTatCa
            // 
            this.rdTatCa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdTatCa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rdTatCa.Location = new System.Drawing.Point(209, 2);
            this.rdTatCa.Name = "rdTatCa";
            this.rdTatCa.Size = new System.Drawing.Size(96, 36);
            this.rdTatCa.TabIndex = 2;
            this.rdTatCa.Text = "Tất cả";
            this.rdTatCa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdTatCa.UseVisualStyleBackColor = false;
            this.rdTatCa.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdDaDat
            // 
            this.rdDaDat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdDaDat.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rdDaDat.Location = new System.Drawing.Point(105, 2);
            this.rdDaDat.Name = "rdDaDat";
            this.rdDaDat.Size = new System.Drawing.Size(96, 36);
            this.rdDaDat.TabIndex = 1;
            this.rdDaDat.Text = "Đã đặt";
            this.rdDaDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdDaDat.UseVisualStyleBackColor = false;
            this.rdDaDat.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDisplay.Controls.Add(this.pnlChoose);
            this.pnlDisplay.Controls.Add(this.btnDatPhong);
            this.pnlDisplay.Controls.Add(this.picDisplay);
            this.pnlDisplay.Location = new System.Drawing.Point(0, 220);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(872, 407);
            this.pnlDisplay.TabIndex = 88;
            // 
            // picDisplay
            // 
            this.picDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDisplay.Image = global::GUI.Properties.Resources._15319554_1615662488736959_778824304_n;
            this.picDisplay.Location = new System.Drawing.Point(0, 0);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(868, 403);
            this.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
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
            this.Controls.Add(this.cbbLoaiPhong);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.lbPlaced);
            this.Controls.Add(this.lbEmpty);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(888, 666);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUNRISE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlChoose.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.ComboBox cbbLoaiPhong;
        private System.Windows.Forms.Label lbEmpty;
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
        private ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem hToolStripMenuItem;
        private Label label10;
        private Label lbPlaced;
        private Button btnDatPhong;
        private Panel pnlChoose;
        private RadioButton rdTrong;
        private RadioButton rdTatCa;
        private RadioButton rdDaDat;
        private Panel pnlDisplay;
        private PictureBox picDisplay;
        private ToolStripMenuItem tTThựcPhẩmToolStripMenuItem;
        private ToolStripMenuItem tTKháchHàngToolStripMenuItem;
        private ToolStripMenuItem tTNhânViênToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;

        // public AutoScaleMode AutoScaleMode { get; private set; }
    }
}