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
    public partial class frmThucPham : Form
    {
        Business BUS;
        public frmThucPham()
        {
            InitializeComponent();
        }

        private void frmThucPham_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            dgvThucPham.DataSource = BUS.GetDataTP();
        }

        private void Init()
        {
            txtIDTP.Text = "";
            txtTenTP.Text = "";
            txtDonGia.Text = "";
            txtNhaSX.Text = "";
            dtNgaySX.Text = "";
            dtHanSD.Text = "";
            txtMieuTa.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ThucPham_DTO tp = new ThucPham_DTO(txtIDTP.Text, txtTenTP.Text, txtDonGia.Text, txtNhaSX.Text, dtNgaySX.Text, dtHanSD.Text, txtMieuTa.Text);
                if (MessageBox.Show("Thêm thực phẩm?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.ThemTP(tp);
                    MessageBox.Show("Thêm thành công!");
                    dgvThucPham.DataSource = BUS.GetDataTP();
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Init();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ThucPham_DTO tp = new ThucPham_DTO(txtIDTP.Text, txtTenTP.Text, txtDonGia.Text, txtNhaSX.Text, dtNgaySX.Text, dtHanSD.Text, txtMieuTa.Text);
                if (MessageBox.Show("Lưu sửa đổi?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.SuaTP(tp);
                    MessageBox.Show("Sửa thành công!");
                    dgvThucPham.DataSource = BUS.GetDataTP();
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xóa thực phẩm?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.XoaTP(txtIDTP.Text);
                    MessageBox.Show("Xóa thành công!");
                    dgvThucPham.DataSource = BUS.GetDataTP();
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dgvThucPham.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dgvThucPham.RowCount - 1; i++)
                {
                    dgvThucPham.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvThucPham.RowCount - 1; i++)
                {
                    if (dgvThucPham.Rows[i].Cells["IDTP"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dgvThucPham.Rows[i].Cells["TenTP"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dgvThucPham.Rows[i].Cells["NhaSX"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dgvThucPham.Rows[i].Cells["MieuTa"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dgvThucPham.Rows[i].Visible = true;
                    }
                    else
                    {
                        dgvThucPham.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void dgvThucPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThucPham.Rows[e.RowIndex];
                txtIDTP.Text = row.Cells[0].Value.ToString();
                txtTenTP.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[1].Value.ToString();
                txtNhaSX.Text = row.Cells[3].Value.ToString();
                dtNgaySX.Text = row.Cells[4].Value.ToString();
                dtHanSD.Text = row.Cells[5].Value.ToString();
                txtMieuTa.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
