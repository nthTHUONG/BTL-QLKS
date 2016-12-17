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

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.Show();
           
        }
     
        private void inHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chưa làm");
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chưa làm");
        }

        private void thựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThucPham frmTP = new frmThucPham();
            frmTP.Show();
        }

        private void cơSởVậtChấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoSoVatChat frmCSVC = new frmCoSoVatChat();
            frmCSVC.Show();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            frmDatPhong frmCSVC = new frmDatPhong();
            frmCSVC.Show();
        }
        private void huowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVuHDV frmDV = new frmDichVuHDV();
            frmDV.Show();
        }
       
        private void thanhToánPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmThanhToanPhong frmTTP = new frmThanhToanPhong();
            frmTTP.Show();
            
        }

        private void thanhToánThuêXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chưa làm");
        }

        private void thanhToánDVHướngDẫnViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmThanhToanHDV frmTThdv = new frmThanhToanHDV();
            frmTThdv.Show();
            
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiPhong frmLP = new frmLoaiPhong();
            frmLP.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhong frmP = new frmPhong();
            frmP.Show();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.Show();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemKH frmThemKH = new frmThemKH();
            frmThemKH.Show();
        }

        private void thanhToánThựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonTP frmHD = new frmHoaDonTP();
            frmHD.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát khỏi hệ thống?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) 
                e.Cancel = true;
        }

        private void thuêXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThueXe frmThueXe = new frmThueXe();
            frmThueXe.Show();
        }


    }
}
