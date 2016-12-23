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

        private void Init()
        {
            txtIDKhachHang.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtGioiTinh.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtQuocTich.Text = "";
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            try
            {
                KhachHang_DTO kh = new KhachHang_DTO(txtIDKhachHang.Text, txtHo.Text, txtTen.Text, txtGioiTinh.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text, txtQuocTich.Text);
                if (MessageBox.Show("Thêm khách hàng?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.ThemKH(kh);
                    MessageBox.Show("Thêm thành công!");
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btHuyBo_Click(object sender, EventArgs e)
        {
            //ds.RejectChanges();
            Init();
        }
    }
}
