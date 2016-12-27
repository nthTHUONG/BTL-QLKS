using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmReportThongTinTP : Form
    {
        public frmReportThongTinTP()
        {
            InitializeComponent();
        }

        private void frmReportThongTinDP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TTTP.ThucPham' table. You can move, or remove it, as needed.
        
            this.ThucPhamTableAdapter.Fill(this.TTTP.ThucPham);

            this.reportViewer1.RefreshReport();
        }
    }
}
