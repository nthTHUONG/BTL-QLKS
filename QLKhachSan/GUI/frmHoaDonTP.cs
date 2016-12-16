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
    public partial class frmHoaDonTP : Form
    {
        Business BUS;
        public frmHoaDonTP()
        {
            InitializeComponent();
        }

        private void frmHoaDonTP_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            LoadCombobox();
            Init();
        }

        private void LoadCombobox()
        {
            cbbMaNV.DataSource = BUS.GetDataNV();
            cbbMaNV.DisplayMember = "IDNhanVien";

            cbbMaTP.DataSource = BUS.GetDataTP("SELECT IDThucPham FROM ThucPham");
            cbbMaTP.DisplayMember = "IDThucPham";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss tt");
        }

        private void Init()
        {
            cbbMaNV.Text = "Chọn nã NV";
            cbbMaTP.Text = "Chọn mã TP";
            txtSoLuong.Text = "";
            lbDonGia.Text = "";
        }

        private void cbbMaTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDonGia.Text = BUS.GetDataTP("SELECT DonGia FROM HoaDonThucPham WHERE MaTP = N'" + cbbMaTP.Text + "'").ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            lbDonGia.Text = (Convert.ToDecimal(BUS.GetDataTP("SELECT DonGia FROM HoaDonThucPham WHERE MaTP = N'" + cbbMaTP.Text + "'")) * Convert.ToInt32(txtSoLuong)).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
