using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThemKH : Form
    {
        Business BUS;
        public frmThemKH()
        {
            InitializeComponent();
        }
        private void frmThemKH_Load(object sender, EventArgs e)
        {
            MessageBox.Show("nút HỦY chưa dùng được!");
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            KhachHang_DTO kh = new KhachHang_DTO(txtIDKhachHang.Text, txtHo.Text, txtTen.Text, txtGioiTinh.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text, txtQuocTich.Text);
            Boolean status = BUS.ThemKH(kh);
            if (status == true)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Chưa nhập hoặc nhập trùng mã khách hàng.");
            }
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            //ds.RejectChanges();
        }
    }
}
