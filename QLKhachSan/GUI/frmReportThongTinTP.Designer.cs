namespace GUI
{
    partial class frmReportThongTinTP
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
            this.ThucPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TTTP = new GUI.TTTP();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThucPhamTableAdapter = new GUI.TTTPTableAdapters.ThucPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ThucPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTTP)).BeginInit();
            this.SuspendLayout();
            // 
            // ThucPhamBindingSource
            // 
            this.ThucPhamBindingSource.DataMember = "ThucPham";
            this.ThucPhamBindingSource.DataSource = this.TTTP;
            // 
            // TTTP
            // 
            this.TTTP.DataSetName = "TTTP";
            this.TTTP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ThucPhamBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportTP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(996, 585);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // ThucPhamTableAdapter
            // 
            this.ThucPhamTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportThongTinTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportThongTinTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin đặt phòng";
            this.Load += new System.EventHandler(this.frmReportThongTinDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThucPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TTTP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThucPhamBindingSource;
        private TTTP TTTP;
        private TTTPTableAdapters.ThucPhamTableAdapter ThucPhamTableAdapter;
    }
}