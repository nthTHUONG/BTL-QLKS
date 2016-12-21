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
         public frmDatPhong()
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
            /*cbbMaNV.DataSource = BUS.GetDataNV("SELECT IDNhanVien FROM NhanVien");
            cbbMaNV.DisplayMember = "IDNhanVien";

            cbbMaKH.DataSource = BUS.GetDataKH("SELECT IDKhachHang FROM KhachHang");
            cbbMaKH.DisplayMember = "IDKhachHang";

            cbbMaPhong.DataSource = BUS.GetDataPhong("SELECT IDPhong FROM Phong");
            cbbMaPhong.DisplayMember = "IDPhong";*/
        }

        private void Init()
        {
            cbbMaNV.Text = "Chọn mã NV";
            cbbMaKH.Text = "Chọn mã KH";
            txtMaDP.Text = "";
            cbbMaPhong.Text = "Chọn mã phòng";
            lbTenLP.Text = "";
            lbThanhTien.Text = "";
            txtTraTruoc.Text = "";
            txtGhiChu.Text = "";
        }

        private void ThanhTien()
        {
            try
            {
                /*decimal giaPhong = Convert.ToDecimal(BUS.GetDataLP("SELECT GiaLP FROM LoaiPhong WHERE IDLoaiPhong IN(SELECT MaLP FROM Phong WHERE IDPhong = N'" + cbbMaPhong.Text + "')").Rows[0][0]);
                TimeSpan duration = Convert.ToDateTime(dtpNgayTra.Text).Subtract(Convert.ToDateTime(dtpNgayNhan.Text));
                int time = Convert.ToInt32(duration.ToString("%d"));
                lbThanhTien.Text = (time <= 0) ? giaPhong.ToString() : (giaPhong * time).ToString();*/
            }
            catch (Exception) { }
        }

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

        }
    }
}
