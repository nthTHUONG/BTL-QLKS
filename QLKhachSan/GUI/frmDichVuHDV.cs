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
    public partial class frmDichVuHDV : Form
    {
        public frmDichVuHDV()
        {
            InitializeComponent();
        }

        private void frmDichVuHDV_Load(object sender, EventArgs e)
        {
            MessageBox.Show("nhập mã kh xem thông tin sử dụng dịch vụ,chưa tạo code!!!");
        }
    }
}
