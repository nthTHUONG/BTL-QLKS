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
    public partial class frmThanhToanHDV : Form
    {
        public frmThanhToanHDV()
        {
            InitializeComponent();
        }

        private void frmThanhToanHDV_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss tt");
        }
    }
}
