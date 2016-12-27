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
        Business BUS;
        Dictionary<string, bool> dicTatCa, dicTrong, dicDaDat;
        Point p, d;
        Size size, n;
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            BUS = new Business();
            dicTatCa = new Dictionary<string, bool>();
            dicTrong = new Dictionary<string, bool>();
            dicDaDat = new Dictionary<string, bool>();

            lbTitle.Text = "        Quản Lý Đặt Phòng      ";

            Init_ComboBox();
            LoadRoom();
            pnlDisplay.BackColor = lbEmpty.BackColor;

            p = new Point(69, 79);      // Điểm đặt btnRoom đầu tiên.
            d = new Point(39, 39);      // Khoảng cách giữa 2 btnRoom.
            n = new Size(8, 4);         // Số btnRoom hiển thị (ngang, dọc).
            size = new Size(((picDisplay.Width - p.X * 2) + d.X) / n.Width - d.X,
                ((picDisplay.Height - p.Y - d.Y / 2) + d.Y) / n.Height - d.Y);
            rdTrong.Checked = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTitle.Text = lbTitle.Text.Substring(1) + lbTitle.Text.Substring(0, 1);
        }

        private void Init_ComboBox()
        {
            cbbLoaiPhong.Items.Add("Tất cả");
            cbbLoaiPhong.Text = "Tất cả";
            cbbLoaiPhong.Items.Add("Phòng đơn");
            cbbLoaiPhong.Items.Add("Phòng đôi");
            cbbLoaiPhong.Items.Add("Phòng nhóm 3");
            cbbLoaiPhong.Items.Add("Phòng nhóm 5");
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ShowRoom();
        }

        private void ShowRoom()
        {
            picDisplay.Controls.Clear();
            if (rdTrong.Checked)
            {
                ShowTrong();
            }
            else if (rdDaDat.Checked)
            {
                ShowDaDat();
            }
            else
            {
                ShowTatCa();
            }
        }

        private void LoadRoom()
        {
            dicTrong.Clear();
            dicDaDat.Clear();
            dicTatCa.Clear();
            DataTable dt;
            string maPhong;
            bool status;
            if (cbbLoaiPhong.Text == "Tất cả")
            {
                dt = BUS.GetDataPhong();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    maPhong = dt.Rows[i]["IDPhong"].ToString();
                    status = BUS.GetDataDP_khongLP(maPhong, dtpNgayNhan.Value, dtpNgayTra.Value);
                    dicTatCa.Add(maPhong, status);
                    if (status == true)
                    {
                        dicTrong.Add(maPhong, status);
                    }
                    else
                    {
                        dicDaDat.Add(maPhong, status);
                    }
                }
            }
            else
            {
                dt = BUS.GetDataPhong_fromTenLP(cbbLoaiPhong.Text);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    maPhong = dt.Rows[i]["IDPhong"].ToString();
                    status = BUS.GetDataDP_coLP(maPhong, dtpNgayNhan.Value, dtpNgayTra.Value, cbbLoaiPhong.Text);
                    dicTatCa.Add(maPhong, status);
                    if (status == true)
                    {
                        dicTrong.Add(maPhong, status);
                    }
                    else
                    {
                        dicDaDat.Add(maPhong, status);
                    }
                }
            }
            ShowRoom();
        }

        private void ShowTrong()
        {
            Point p_btn = p;
            foreach (KeyValuePair<string, bool> pair in dicTrong)
            {
                Button btnRoom = new Button();
                btnRoom.Location = p_btn;
                btnRoom.Size = size;
                btnRoom.Text = pair.Key.Trim();
                picDisplay.Controls.Add(btnRoom);
                if (p_btn.X + btnRoom.Width < picDisplay.Width - p.X * 2)
                {
                    p_btn.X += (btnRoom.Width + d.X);
                }
                else
                {
                    p_btn.X = p.X;
                    p_btn.Y += (btnRoom.Height + d.Y);
                }
                btnRoom.Click += new EventHandler(DatPhong_Click);
            }
        }

        private void ShowDaDat()
        {
            Point p_btn = p;
            foreach (KeyValuePair<string, bool> pair in dicDaDat)
            {
                Button btnRoom = new Button();
                btnRoom.Location = p_btn;
                btnRoom.Size = size;
                btnRoom.BackColor = lbPlaced.BackColor;
                btnRoom.Text = pair.Key.Trim();
                picDisplay.Controls.Add(btnRoom);
                if (p_btn.X + btnRoom.Width < picDisplay.Width - p.X * 2)
                {
                    p_btn.X += (btnRoom.Width + d.X);
                }
                else
                {
                    p_btn.X = p.X;
                    p_btn.Y += (btnRoom.Height + d.Y);
                }
            }
        }

        private void ShowTatCa()
        {
            Point p_btn = p;
            foreach (KeyValuePair<string, bool> pair in dicTatCa)
            {
                Button btnRoom = new Button();
                btnRoom.Location = p_btn;
                btnRoom.Size = size;
                if (pair.Value == false)
                {
                    btnRoom.BackColor = lbPlaced.BackColor;
                }
                else
                {
                    btnRoom.Click += new EventHandler(DatPhong_Click);
                }
                btnRoom.Text = pair.Key.Trim();
                picDisplay.Controls.Add(btnRoom);
                if (p_btn.X + btnRoom.Width < picDisplay.Width - p.X * 2)
                {
                    p_btn.X += (btnRoom.Width + d.X);
                }
                else
                {
                    p_btn.X = p.X;
                    p_btn.Y += (btnRoom.Height + d.Y);
                }
            }
        }

        private void DatPhong_Click(object sender, EventArgs e)
        {
            frmDatPhong f = new frmDatPhong();
            f.str_MaPhong = ((Button)sender).Text;
            f.Auto_Value();
            f.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.Show();
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
            frmThueXe frmTTXe = new frmThueXe();
            frmTTXe.Show();
        }

        private void thanhToánDVHướngDẫnViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVuHDV frmHDV = new frmDichVuHDV();
            frmHDV.Show();
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiPhong frmLP = new frmLoaiPhong();
            frmLP.Show();
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

        bool coHieu = false;

        private void cbbLoaiPhong_Click(object sender, EventArgs e)
        {
            coHieu = true;
        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coHieu == true)
            {
                LoadRoom();
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadRoom();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát khỏi hệ thống?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) 
                e.Cancel = true;
        }

        private void thựcPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmThucPham frmTP = new frmThucPham();
            frmTP.Show();
        }

        private void thuêXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChiTietXe frmCTXe = new frmChiTietXe();
            frmCTXe.Show();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHH frmHH = new frmHH();
            frmHH.Show();
        }

        private void tTThựcPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportThongTinTP frmRtp = new frmReportThongTinTP();
            frmRtp.Show();
        }

        private void tTKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportKH frmRkh = new frmReportKH();
            frmRkh.Show();
        }

        private void tTNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportNV frmRnv = new frmReportNV();
            frmRnv.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongKe frmTK = new frm_ThongKe();
            frmTK.Show();
        }
    }
}
