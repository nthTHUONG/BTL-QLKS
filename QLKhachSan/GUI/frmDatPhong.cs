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
    public partial class frmDatPhong : Form
    {
        Business BUS;
        decimal giaPhong;
        public frmDatPhong()
        {
            InitializeComponent();
        }

        public string str_MaPhong;

        public void Auto_Value()
        {
            cbbMaNV.Text = frmDangNhap.MaNV;
            Business B = new Business();
            cbbMaPhong.Text = str_MaPhong;
            cbbMaKH.DataSource = B.GetDataKH();
            cbbMaKH.DisplayMember = "IDKhachHang";
            txtMaDP.Text = "DP" + (B.GetDataDP().Rows.Count + 1).ToString();
            DataTable dt = B.GetDataLP_fromIDPhong(cbbMaPhong.Text);
            if (dt.Rows.Count > 0)
            {
                txtTenLP.Text = dt.Rows[0]["TenLP"].ToString();
                giaPhong = Convert.ToDecimal(dt.Rows[0]["GiaLP"]);
            }
            txtNgayDat.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtTraTruoc.Text = "0";
            TimeSpan duration = dtpNgayTra.Value.Subtract(dtpNgayNhan.Value);
            int time = Convert.ToInt32(duration.ToString("%d"));
            txtThanhTien.Text = (time == 0) ? giaPhong.ToString() : (giaPhong * time).ToString();
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            if (cbbMaKH.DataSource == null)
            {
                LoadCombobox();
                Init();
            }
        }

        private void LoadCombobox()
        {
            cbbMaNV.Text = frmDangNhap.MaNV;
            cbbMaKH.DataSource = BUS.GetDataKH();
            cbbMaKH.DisplayMember = "IDKhachHang";
            cbbMaPhong.DataSource = BUS.GetDataPhong();
            cbbMaPhong.DisplayMember = "IDPhong";
        }

        private void Init()
        {
            cbbMaKH.Text = "Chọn mã KH";
            txtMaDP.Text = "DP" + (BUS.GetDataDP().Rows.Count + 1).ToString();
            cbbMaPhong.Text = "Chọn mã phòng";
            txtTenLP.Text = "";
            txtNgayDat.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtThanhTien.Text = "0";
            txtTraTruoc.Text = "0";
            txtGhiChu.Text = "";
        }

        private void ThanhTien()
        {
            TimeSpan duration = Convert.ToDateTime(dtpNgayTra.Text).Subtract(Convert.ToDateTime(dtpNgayNhan.Text));
            int time = Convert.ToInt32(duration.ToString("%d"));
            txtThanhTien.Text = (time == 0) ? giaPhong.ToString() : (giaPhong * time).ToString();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmThemKH f = new frmThemKH();
            f.ShowDialog();
            cbbMaKH.DataSource = BUS.GetDataKH();
            cbbMaKH.DisplayMember = "IDKhachHang";
            cbbMaKH.Text = "Chọn mã KH";
        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = BUS.GetDataLP_fromIDPhong(cbbMaPhong.Text);
            if (dt.Rows.Count > 0)
            {
                txtTenLP.Text = dt.Rows[0]["TenLP"].ToString();
                giaPhong = Convert.ToDecimal(dt.Rows[0]["GiaLP"]);
            }
            ThanhTien();
        }

        private void dtpNgayTra_ValueChanged(object sender, EventArgs e)
        {
            ThanhTien();
            dtpNgayTra.MinDate = dtpNgayNhan.Value;
            if (dtpNgayNhan.Value > dtpNgayTra.Value)
            {
                dtpNgayTra.Value = dtpNgayNhan.Value;
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            try
            {
                DatPhong_DTO dp = new DatPhong_DTO(txtMaDP.Text, cbbMaKH.Text, cbbMaNV.Text, cbbMaPhong.Text,
                    txtNgayDat.Text, dtpNgayNhan.Text, dtpNgayTra.Text, txtThanhTien.Text, txtTraTruoc.Text, txtGhiChu.Text, true);
                BUS.ThemDP(dp);
                MessageBox.Show("Đặt phòng thành công.", "Successfully!", MessageBoxButtons.OK);
                Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
