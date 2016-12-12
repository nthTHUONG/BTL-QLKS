using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHoaDonThucPham : Form
    {
        public frmHoaDonThucPham()
        {
            InitializeComponent();
        }

        private void frmHoaDonThucPham_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss tt");
        }
    }
}
