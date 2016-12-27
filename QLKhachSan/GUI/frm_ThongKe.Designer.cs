namespace GUI
{
    partial class frm_ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbThang = new System.Windows.Forms.RadioButton();
            this.rdbNgay = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(836, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 79);
            this.button1.TabIndex = 32;
            this.button1.Text = "Thống Kê";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpKetThuc
            // 
            this.dtpKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetThuc.Location = new System.Drawing.Point(177, 65);
            this.dtpKetThuc.Name = "dtpKetThuc";
            this.dtpKetThuc.Size = new System.Drawing.Size(155, 22);
            this.dtpKetThuc.TabIndex = 31;
            this.dtpKetThuc.Value = new System.DateTime(2016, 3, 30, 0, 0, 0, 0);
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatDau.Location = new System.Drawing.Point(177, 19);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(155, 22);
            this.dtpBatDau.TabIndex = 30;
            this.dtpBatDau.Value = new System.DateTime(2016, 3, 30, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(56, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Thời Gian Kết Thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(56, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Thơi Gian Bắt Đầu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.rdbThang);
            this.groupBox1.Controls.Add(this.rdbNgay);
            this.groupBox1.Controls.Add(this.dtpKetThuc);
            this.groupBox1.Controls.Add(this.dtpBatDau);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 97);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(491, 64);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 22);
            this.rdbNam.TabIndex = 38;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Năm";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbThang
            // 
            this.rdbThang.AutoSize = true;
            this.rdbThang.Location = new System.Drawing.Point(491, 41);
            this.rdbThang.Name = "rdbThang";
            this.rdbThang.Size = new System.Drawing.Size(67, 22);
            this.rdbThang.TabIndex = 38;
            this.rdbThang.TabStop = true;
            this.rdbThang.Text = "Tháng";
            this.rdbThang.UseVisualStyleBackColor = true;
            // 
            // rdbNgay
            // 
            this.rdbNgay.AutoSize = true;
            this.rdbNgay.Location = new System.Drawing.Point(491, 18);
            this.rdbNgay.Name = "rdbNgay";
            this.rdbNgay.Size = new System.Drawing.Size(60, 22);
            this.rdbNgay.TabIndex = 38;
            this.rdbNgay.TabStop = true;
            this.rdbNgay.Text = "Ngày";
            this.rdbNgay.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(32, 129);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số Lượng";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1005, 386);
            this.chart1.TabIndex = 39;
            this.chart1.Text = "chart1";
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1049, 527);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "frm_ThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frm_ThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpKetThuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbThang;
        private System.Windows.Forms.RadioButton rdbNgay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}