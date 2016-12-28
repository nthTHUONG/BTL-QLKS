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
    public partial class frmCoSoVatChat : Form
    {
        Business BUS;
        public frmCoSoVatChat()
        {
            InitializeComponent();
        }
        
        private void frmCoSoVatChat_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            dgvCSVC.DataSource = BUS.GetDataCSVC();
        }

        private void Init()
        {
            txtIDCSVC.Text = "";
            txtTenCSVC.Text = "";
            txtMaLP.Text = "";
            txtSoLuong.Text = "";
            txtTinhTrang.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                CoSoVatChat_DTO csvc = new CoSoVatChat_DTO(txtIDCSVC.Text, txtTenCSVC.Text, txtMaLP.Text, txtSoLuong.Text, txtTinhTrang.Text, txtGhiChu.Text);
                if (MessageBox.Show("Thêm cơ sở vật chất?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.ThemCSVC(csvc);
                    MessageBox.Show("Thêm thành công!");
                    dgvCSVC.DataSource = BUS.GetDataCSVC();
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                CoSoVatChat_DTO csvc = new CoSoVatChat_DTO(txtIDCSVC.Text, txtTenCSVC.Text, txtMaLP.Text, txtSoLuong.Text, txtTinhTrang.Text, txtGhiChu.Text);
                if (MessageBox.Show("Lưu sửa đổi?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.SuaCSVC(csvc);
                    MessageBox.Show("Sửa thành công!");
                    dgvCSVC.DataSource = BUS.GetDataCSVC();
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
                if (MessageBox.Show("Xóa cơ sở vật chất?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.XoaCSVC(txtIDCSVC.Text);
                    MessageBox.Show("Xóa thành công!");
                    dgvCSVC.DataSource = BUS.GetDataCSVC();
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
            Init();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dgvCSVC.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dgvCSVC.RowCount - 1; i++)
                {
                    dgvCSVC.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvCSVC.RowCount - 1; i++)
                {
                    if ((dgvCSVC.Rows[i].Cells["IDCSVC"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                        || (dgvCSVC.Rows[i].Cells["TenCSVC"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true))
                    {
                        dgvCSVC.Rows[i].Visible = true;
                    }
                    else
                    {
                        dgvCSVC.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void dgvCSVC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCSVC.Rows[e.RowIndex];
                txtIDCSVC.Text = row.Cells[0].Value.ToString();
                txtTenCSVC.Text = row.Cells[1].Value.ToString();
                txtMaLP.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtTinhTrang.Text = row.Cells[4].Value.ToString();
                txtGhiChu.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
