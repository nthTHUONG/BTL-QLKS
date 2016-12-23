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
        DataTable dt, dtTP;
        public frmHoaDonTP()
        {
            InitializeComponent();
        }

        private void frmHoaDonTP_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            LoadCombobox();
            Init_Table();
            dgvThucPham.DataSource = dt;
            Init();
        }

        private void LoadCombobox()
        {
            cbbMaNV.DataSource = BUS.GetDataNV();
            cbbMaNV.DisplayMember = "IDNhanVien";
            cbbMaNV.Text = "Chọn nã NV";

            cbbMaTP.DataSource = BUS.GetDataTP();
            cbbMaTP.DisplayMember = "IDThucPham";
        }

        private void Init_Table()
        {
            dt = new DataTable();
            dt.Columns.Add("IDThucPham");
            dt.Columns.Add("Tên TP");
            dt.Columns.Add("Nhà SX");
            dt.Columns.Add("Ngày SX");
            dt.Columns.Add("Hạn SD");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Đơn giá");
            dtTP = new DataTable();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss tt");
        }

        private void Init()
        {
            cbbMaTP.Text = "Chọn mã TP";
            txtSoLuong.Text = "";
            lbDonGia.Text = "";
        }

        private void cbbMaTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoLuong.Text = "1";
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
                lbDonGia.Text = (Convert.ToDecimal(BUS.GetDataTP(cbbMaTP.Text).Rows[0]["DonGia"]) * Convert.ToInt32(txtSoLuong.Text)).ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dtTP.Rows.Clear();
            dtTP = BUS.GetDataTP(cbbMaTP.Text);
            DataRow row = dt.NewRow();
            row["IDThucPham"] = cbbMaTP.Text;
            row["Tên TP"] = dtTP.Rows[0]["TenTP"];
            row["Nhà SX"] = dtTP.Rows[0]["NhaSX"];
            row["Ngày SX"] = dtTP.Rows[0]["NgaySX"];
            row["Hạn SD"] = dtTP.Rows[0]["HanSD"];
            row["Số lượng"] = txtSoLuong.Text;
            row["Đơn giá"] = lbDonGia.Text;
            dt.Rows.Add(row);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
