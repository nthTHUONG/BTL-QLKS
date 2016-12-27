namespace GUI
{
    partial class frmThemThueXe
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
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDKhachHang = new System.Windows.Forms.TextBox();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtIDThueXe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgvThemThueXe = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemThueXe)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(175, 143);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(168, 26);
            this.dtpNgayMuon.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(66, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 26);
            this.label10.TabIndex = 137;
            this.label10.Text = "Ngày mượn: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIDKhachHang
            // 
            this.txtIDKhachHang.Location = new System.Drawing.Point(175, 76);
            this.txtIDKhachHang.Name = "txtIDKhachHang";
            this.txtIDKhachHang.Size = new System.Drawing.Size(166, 26);
            this.txtIDKhachHang.TabIndex = 1;
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(455, 76);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(189, 26);
            this.txtTienCoc.TabIndex = 5;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Location = new System.Drawing.Point(455, 44);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(189, 26);
            this.txtGiaThue.TabIndex = 4;
            // 
            // txtMaXe
            // 
            this.txtMaXe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaXe.Location = new System.Drawing.Point(175, 110);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.ReadOnly = true;
            this.txtMaXe.Size = new System.Drawing.Size(166, 26);
            this.txtMaXe.TabIndex = 2;
            // 
            // txtIDThueXe
            // 
            this.txtIDThueXe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIDThueXe.Location = new System.Drawing.Point(175, 44);
            this.txtIDThueXe.Name = "txtIDThueXe";
            this.txtIDThueXe.ReadOnly = true;
            this.txtIDThueXe.Size = new System.Drawing.Size(166, 26);
            this.txtIDThueXe.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(364, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 131;
            this.label7.Text = "Tiền Cọc:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 132;
            this.label5.Text = "Giá Thuê:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 133;
            this.label2.Text = "Mã Xe:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 135;
            this.label1.Text = "Mã KH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 134;
            this.label4.Text = "Mã Thuê Xe:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayMuon);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtIDKhachHang);
            this.groupBox1.Controls.Add(this.txtTienCoc);
            this.groupBox1.Controls.Add(this.txtGiaThue);
            this.groupBox1.Controls.Add(this.txtMaXe);
            this.groupBox1.Controls.Add(this.txtIDThueXe);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 215);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Thêm Thuê xe";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(221, 233);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Location = new System.Drawing.Point(414, 233);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 43);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvThemThueXe
            // 
            this.dgvThemThueXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThemThueXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemThueXe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThemThueXe.Location = new System.Drawing.Point(0, 350);
            this.dgvThemThueXe.Name = "dgvThemThueXe";
            this.dgvThemThueXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThemThueXe.Size = new System.Drawing.Size(724, 153);
            this.dgvThemThueXe.TabIndex = 140;
            this.dgvThemThueXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThemThueXe_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 132;
            this.label3.Text = "Tìm Kiếm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(107, 306);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(221, 26);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // frmThemThueXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.Controls.Add(this.dgvThemThueXe);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThemThueXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Thuê Xe";
            this.Load += new System.EventHandler(this.frmThemThueXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemThueXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDKhachHang;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtIDThueXe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvThemThueXe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}