using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmChiTietThucPham : Form
    {
        Business BUS;
        public frmChiTietThucPham()
        {
            InitializeComponent();
        }

        private void frmChiTietThucPham_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Nút SỬA chưa được! chỉ có mã TP sửa được nhưng lại lưu dưới dạng thêm 1 mã TP,các thành phần khác ko thể sửa!!!");
            BUS = new Business();
            dataGV.DataSource = BUS.GetDataCTTP();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            ChiTietThucPham_DTO TP = new ChiTietThucPham_DTO(txtIDTP.Text, txtTenTP.Text, txtNhaSX.Text, dtNgaySX.Text, dtHanSD.Text, txtMieuTa.Text);
            Boolean status = BUS.ThemCTTP(TP);
            if (status == true)
            {
                MessageBox.Show("Thêm thành công!");
                dataGV.DataSource = BUS.GetDataPhong();
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Chưa nhập hoặc nhập trùng mã dịch vụ HDV.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtIDTP.Text = "";
            txtTenTP.Text = "";
            txtNhaSX.Text = "";
            dtNgaySX.Text = "";
            dtHanSD.Text = "";
            txtMieuTa.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            ChiTietThucPham_DTO TP = new ChiTietThucPham_DTO(txtIDTP.Text, txtTenTP.Text, txtNhaSX.Text, dtNgaySX.Text, dtHanSD.Text, txtMieuTa.Text);
            Boolean status = BUS.ThemCTTP(TP);
            btnReset_Click(sender, e);
            if (status == true)
            {
                MessageBox.Show("Sửa thành công!");
                dataGV.DataSource = BUS.GetDataCTTP();
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            Boolean status = BUS.XoaCTTP(txtIDTP.Text);
            btnReset_Click(sender, e);
            if (status == true)
            {
                MessageBox.Show("Xóa thành công!");
                dataGV.DataSource = BUS.GetDataCTTP();
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa thất bại! Mã dịch vụ không tồn tại.");
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dataGV.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dataGV.RowCount - 1; i++)
                {
                    dataGV.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dataGV.RowCount - 1; i++)
                {
                    if (dataGV.Rows[i].Cells["IDTP"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dataGV.Rows[i].Cells["TenTP"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dataGV.Rows[i].Cells["NhaSX"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dataGV.Rows[i].Cells["MieuTa"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dataGV.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGV.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGV.Rows[e.RowIndex];
                txtIDTP.Text = row.Cells[0].Value.ToString();
                txtTenTP.Text = row.Cells[1].Value.ToString();
                txtNhaSX.Text = row.Cells[2].Value.ToString();
                dtNgaySX.Text = row.Cells[3].Value.ToString();
                dtHanSD.Text = row.Cells[4].Value.ToString();
                txtMieuTa.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
