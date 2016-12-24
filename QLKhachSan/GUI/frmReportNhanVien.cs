using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Configuration;

namespace GUI
{
    public partial class frmReportNhanVien : Form
    {
        SqlConnection cnn;
        string cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
        public frmReportNhanVien()
        {
            InitializeComponent();
        }

        private void ReportNhanVien_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(cnStr);
            string sql = "SELECT * FROM NhanVien";
            DataTable dtNV = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            da.Fill(dtNV);
            ReportDataSource rptNhanVien = new ReportDataSource("NV", dtNV);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rptNhanVien);
            reportViewer1.LocalReport.ReportPath = @"..\..\ReportNhanVien.rdlc";
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
