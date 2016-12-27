namespace GUI
{
    partial class frmCoSoVatChat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCSVC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDCSVC = new System.Windows.Forms.TextBox();
            this.txtTenCSVC = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaLP = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCSVC
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCSVC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCSVC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCSVC.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvCSVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSVC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCSVC.Location = new System.Drawing.Point(0, 342);
            this.dgvCSVC.Name = "dgvCSVC";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCSVC.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCSVC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCSVC.Size = new System.Drawing.Size(643, 164);
            this.dgvCSVC.TabIndex = 0;
            this.dgvCSVC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCSVC_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã CSVC:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(59, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên CSVC:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(59, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã LP:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(59, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(59, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tình trạng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(59, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ghi chú:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIDCSVC
            // 
            this.txtIDCSVC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDCSVC.Location = new System.Drawing.Point(153, 31);
            this.txtIDCSVC.Name = "txtIDCSVC";
            this.txtIDCSVC.Size = new System.Drawing.Size(224, 26);
            this.txtIDCSVC.TabIndex = 0;
            // 
            // txtTenCSVC
            // 
            this.txtTenCSVC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenCSVC.Location = new System.Drawing.Point(153, 70);
            this.txtTenCSVC.Name = "txtTenCSVC";
            this.txtTenCSVC.Size = new System.Drawing.Size(224, 26);
            this.txtTenCSVC.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuong.Location = new System.Drawing.Point(153, 147);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(224, 26);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtMaLP
            // 
            this.txtMaLP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaLP.Location = new System.Drawing.Point(153, 109);
            this.txtMaLP.Name = "txtMaLP";
            this.txtMaLP.Size = new System.Drawing.Size(224, 26);
            this.txtMaLP.TabIndex = 2;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTinhTrang.Location = new System.Drawing.Point(153, 188);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(224, 26);
            this.txtTinhTrang.TabIndex = 4;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGhiChu.Location = new System.Drawing.Point(153, 226);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(224, 26);
            this.txtGhiChu.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.BackColor = System.Drawing.Color.SandyBrown;
            this.btnThem.Location = new System.Drawing.Point(503, 70);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 38);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.BackColor = System.Drawing.Color.SandyBrown;
            this.btnXoa.Location = new System.Drawing.Point(503, 158);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 38);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCapNhat.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCapNhat.Location = new System.Drawing.Point(503, 114);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(101, 38);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReset.BackColor = System.Drawing.Color.SandyBrown;
            this.btnReset.Location = new System.Drawing.Point(503, 202);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 38);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTinhTrang);
            this.groupBox1.Controls.Add(this.txtMaLP);
            this.groupBox1.Controls.Add(this.txtTenCSVC);
            this.groupBox1.Controls.Add(this.txtIDCSVC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 282);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Cơ Sở Vật Chất";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTimKiem.Location = new System.Drawing.Point(127, 302);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(309, 26);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tìm kiếm:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCoSoVatChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(643, 506);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvCSVC);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCoSoVatChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cơ Sở Vật Chất";
            this.Load += new System.EventHandler(this.frmCoSoVatChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSVC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCSVC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDCSVC;
        private System.Windows.Forms.TextBox txtTenCSVC;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaLP;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
    }
}