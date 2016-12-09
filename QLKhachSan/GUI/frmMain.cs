using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lbTitle.Text = "        Quản Lý Đặt Phòng      ";
            //cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTitle.Text = lbTitle.Text.Substring(1) + lbTitle.Text.Substring(0, 1);
        }
    }
}
