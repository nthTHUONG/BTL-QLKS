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
        decimal tongTien;
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
            tongTien = 0;
            Image_Xoa();
            Init();
        }

        private void LoadCombobox()
        {
            cbbMaNV.Text = frmDangNhap.MaNV;
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
            txtSoLuong.Text = "1";
            lbDonGia.Text = "";
            lbTongTien.Text = "";
        }

        private void cbbMaTP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(coHieu == false)
            {
                return;
            }
            try
            {
                if (cbbMaTP.Text != "Chọn mã TP")
                {
                    lbDonGia.Text = (Convert.ToDecimal(BUS.GetDataTP(cbbMaTP.Text).Rows[0]["DonGia"].ToString()) * Convert.ToInt32(txtSoLuong.Text)).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng phải là số nguyên!");
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbMaTP.Text != "Chọn mã TP")
                {
                    lbDonGia.Text = (Convert.ToDecimal(BUS.GetDataTP(cbbMaTP.Text).Rows[0]["DonGia"].ToString()) * Convert.ToInt32(txtSoLuong.Text)).ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng phải là số nguyên!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (DataGridViewRow row in dgvThucPham.Rows)
            {
                if ((row.Cells["IDThucPham"].Value != null) && (row.Cells["IDThucPham"].Value.ToString() == cbbMaTP.Text))
                {
                    check = true;
                    row.Cells["Số lượng"].Value = Convert.ToInt32(row.Cells["Số lượng"].Value.ToString()) + Convert.ToInt32(txtSoLuong.Text);
                    row.Cells["Đơn giá"].Value = Convert.ToDecimal(row.Cells["Đơn giá"].Value.ToString()) + Convert.ToDecimal(lbDonGia.Text);
                }
            }
            if (check == false)
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
            tongTien += Convert.ToDecimal(lbDonGia.Text);
            lbTongTien.Text = tongTien.ToString() ;
        }
        bool coHieu = false;
        private void cbbMaTP_Click(object sender, EventArgs e)
        {
            coHieu = true;
        }

        private void ptbXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Image_Xoa()
        {
            DataGridViewImageColumn img_dgv = new DataGridViewImageColumn();
            img_dgv.Image = GUI.Properties.Resources._15748984_591212551065716_1357324275_o;
            dgvThucPham.Columns.Insert(0, img_dgv);
        }

        private void dgvThucPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                dgvThucPham.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            //dtTP.Rows.Clear();

            frmThanhToanHDTP frmTP = new frmThanhToanHDTP();
            frmTP.str = lbTongTien.Text;
            frmTP.str1 = cbbMaNV.Text;
            frmTP.ShowDialog();
            int count = dgvThucPham.Rows.Count;
            for (int i = 0; i < count; i++)
                dgvThucPham.Rows.RemoveAt(0);
        }
    }
}
