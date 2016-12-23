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
<<<<<<< HEAD
        decimal giaPhong;
        public frmDatPhong()
=======
         public frmDatPhong()
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
        {
            InitializeComponent();
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            LoadCombobox();
            Init();
        }

        private void LoadCombobox()
        {
<<<<<<< HEAD
            cbbMaNV.DataSource = BUS.GetDataNV();
            cbbMaNV.DisplayMember = "IDNhanVien";

            cbbMaKH.DataSource = BUS.GetDataKH();
            cbbMaKH.DisplayMember = "IDKhachHang";

            cbbMaPhong.DataSource = BUS.GetDataPhong();
            cbbMaPhong.DisplayMember = "IDPhong";
=======
            /*cbbMaNV.DataSource = BUS.GetDataNV("SELECT IDNhanVien FROM NhanVien");
            cbbMaNV.DisplayMember = "IDNhanVien";

            cbbMaKH.DataSource = BUS.GetDataKH("SELECT IDKhachHang FROM KhachHang");
            cbbMaKH.DisplayMember = "IDKhachHang";

            cbbMaPhong.DataSource = BUS.GetDataPhong("SELECT IDPhong FROM Phong");
            cbbMaPhong.DisplayMember = "IDPhong";*/
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
        }

        private void Init()
        {
            cbbMaNV.Text = "Chọn mã NV";
            cbbMaKH.Text = "Chọn mã KH";
<<<<<<< HEAD
            txtMaDP.Text = "DP" + (BUS.GetDataDP().Rows.Count + 1).ToString();
            cbbMaPhong.Text = "Chọn mã phòng";
            txtTenLP.Text = "";
            txtNgayDat.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtThanhTien.Text = "0";
            txtTraTruoc.Text = "0";
=======
            txtMaDP.Text = "";
            cbbMaPhong.Text = "Chọn mã phòng";
            lbTenLP.Text = "";
            lbThanhTien.Text = "";
            txtTraTruoc.Text = "";
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
            txtGhiChu.Text = "";
        }

        private void ThanhTien()
<<<<<<< HEAD
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
=======
        {
            try
            {
                /*decimal giaPhong = Convert.ToDecimal(BUS.GetDataLP("SELECT GiaLP FROM LoaiPhong WHERE IDLoaiPhong IN(SELECT MaLP FROM Phong WHERE IDPhong = N'" + cbbMaPhong.Text + "')").Rows[0][0]);
                TimeSpan duration = Convert.ToDateTime(dtpNgayTra.Text).Subtract(Convert.ToDateTime(dtpNgayNhan.Text));
                int time = Convert.ToInt32(duration.ToString("%d"));
                lbThanhTien.Text = (time <= 0) ? giaPhong.ToString() : (giaPhong * time).ToString();*/
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
            }
        }

<<<<<<< HEAD
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            try
            {
                DatPhong_DTO dp = new DatPhong_DTO(txtMaDP.Text, cbbMaKH.Text, cbbMaNV.Text, cbbMaPhong.Text,
                    txtNgayDat.Text, dtpNgayNhan.Text, dtpNgayTra.Text, txtThanhTien.Text, txtTraTruoc.Text, txtGhiChu.Text);
                BUS.ThemDP(dp);
                MessageBox.Show("Đặt phòng thành công.", "Successfully!", MessageBoxButtons.OK);
                Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
=======
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            frmThemKH f = new frmThemKH();
            f.ShowDialog();
        }

        private void cbbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbTenLP.Text = BUS.GetDataLP("SELECT TenLP FROM LoaiPhong WHERE IDLoaiPhong IN(SELECT MaLP FROM Phong WHERE IDPhong = N'" + cbbMaPhong.Text + "')").Rows[0][0].ToString();
            ThanhTien();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ThanhTien();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {

>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
        }
    }
}
