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
    public partial class frmLoaiPhong : Form
    {
        Business BUS;
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            dgvLoaiPhong.DataSource = BUS.GetDataLP();
        }

        private void Init()
        {
            txtIDLP.Text = "";
            txtTenLP.Text = "";
            txtGiaLP.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiPhong_DTO lp = new LoaiPhong_DTO(txtIDLP.Text, txtTenLP.Text, txtGiaLP.Text, txtSoLuong.Text, txtGhiChu.Text);
                if (MessageBox.Show("Thêm loại phòng!", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.ThemLP(lp);
                    MessageBox.Show("Thêm thành công!");
                    dgvLoaiPhong.DataSource = BUS.GetDataLP();
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiPhong_DTO lp = new LoaiPhong_DTO(txtIDLP.Text, txtTenLP.Text, txtGiaLP.Text, txtSoLuong.Text, txtGhiChu.Text);
                if (MessageBox.Show("Lưu sửa đổi?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.SuaLP(lp);
                    MessageBox.Show("Sửa thành công!");
                    dgvLoaiPhong.DataSource = BUS.GetDataLP();
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
                if (MessageBox.Show("Xóa loại phòng?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.XoaKH(txtIDLP.Text);
                    MessageBox.Show("Xóa thành công!");
                    dgvLoaiPhong.DataSource = BUS.GetDataLP();
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

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dgvLoaiPhong.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dgvLoaiPhong.RowCount - 1; i++)
                {
                    dgvLoaiPhong.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvLoaiPhong.RowCount - 1; i++)
                {
                    if (dgvLoaiPhong.Rows[i].Cells["IDLoaiPhong"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true ||
                        dgvLoaiPhong.Rows[i].Cells["TenLP"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true ||
                        dgvLoaiPhong.Rows[i].Cells["GiaLP"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true ||
                        dgvLoaiPhong.Rows[i].Cells["SoLuong"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dgvLoaiPhong.Rows[i].Visible = true;
                    }
                    else
                    {
                        dgvLoaiPhong.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoaiPhong.Rows[e.RowIndex];
                txtIDLP.Text = row.Cells[0].Value.ToString();
                txtTenLP.Text = row.Cells[1].Value.ToString();
                txtGiaLP.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtGhiChu.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
