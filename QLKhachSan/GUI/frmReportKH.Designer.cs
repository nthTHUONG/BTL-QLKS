namespace GUI
{
    partial class frmReportKH
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DanhSachKH = new GUI.DanhSachKH();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KhachHangTableAdapter = new GUI.DanhSachKHTableAdapters.KhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // KhachHangBindingSource
            // 
            this.KhachHangBindingSource.DataMember = "KhachHang";
            this.KhachHangBindingSource.DataSource = this.DanhSachKH;
            // 
            // DanhSachKH
            // 
            this.DanhSachKH.DataSetName = "DanhSachKH";
            this.DanhSachKH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KhachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.DanhSachKH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(898, 421);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // KhachHangTableAdapter
            // 
            this.KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 421);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.frmReportKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DanhSachKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KhachHangBindingSource;
        private DanhSachKH DanhSachKH;
        private DanhSachKHTableAdapters.KhachHangTableAdapter KhachHangTableAdapter;
    }
}