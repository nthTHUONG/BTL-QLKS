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
    public partial class frmNhanVien : Form
    {
        Business BUS;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            dgvNhanVien.DataSource = BUS.GetDataNV();
            dgvNhanVien.Columns["Pass"].Visible = false;
            string chucVuNhanVien = BUS.GetChucVu(frmDangNhap.MaNV);
            if(string.IsNullOrWhiteSpace(chucVuNhanVien) == false)
            {
                if (chucVuNhanVien.Trim().ToLower().Equals("quản lý") != true)
                {
                    MessageBox.Show("chỉ có quản lý mới được vào form nầy");
                    this.Close();
                }
            }
        }

        private void Init()
        {
            txtIDNhanVien.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtChucVu.Text = "";
            txtGioiTinh.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien_DTO nv = new NhanVien_DTO(txtIDNhanVien.Text, txtHo.Text, txtTen.Text, txtChucVu.Text, txtGioiTinh.Text, dtpNgaySinh.Text, txtSDT.Text, txtDiaChi.Text);
                if (MessageBox.Show("Thêm nhân viên?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.ThemNV(nv);
                    MessageBox.Show("Thêm thành công!");
                    dgvNhanVien.DataSource = BUS.GetDataNV();
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
                NhanVien_DTO nv = new NhanVien_DTO(txtIDNhanVien.Text, txtHo.Text, txtTen.Text, txtChucVu.Text, txtGioiTinh.Text, dtpNgaySinh.Text, txtSDT.Text, txtDiaChi.Text);
                if (MessageBox.Show("Lưu sửa đổi?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.SuaNV(nv);
                    MessageBox.Show("Sửa thành công!");
                    dgvNhanVien.DataSource = BUS.GetDataNV();
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
                if (MessageBox.Show("Xóa nhân viên?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.XoaNV(txtIDNhanVien.Text);
                    MessageBox.Show("Xóa thành công!");
                    dgvNhanVien.DataSource = BUS.GetDataNV();
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
            dgvNhanVien.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dgvNhanVien.RowCount - 1; i++)
                {
                    dgvNhanVien.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvNhanVien.RowCount - 1; i++)
                {
                    if (dgvNhanVien.Rows[i].Cells["IDNhanVien"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || (dgvNhanVien.Rows[i].Cells["Ho"].Value.ToString() + " " + dgvNhanVien.Rows[i].Cells["Ten"].Value.ToString()).ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || dgvNhanVien.Rows[i].Cells["SDT"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dgvNhanVien.Rows[i].Visible = true;
                    }
                    else
                    {
                        dgvNhanVien.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtIDNhanVien.Text = row.Cells["IDNhanVien"].Value.ToString();
                txtHo.Text = row.Cells["Ho"].Value.ToString();
                txtTen.Text = row.Cells["Ten"].Value.ToString();
                txtChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        private void btSinhMaNV_Click(object sender, EventArgs e)
        {
            DataTable dtNV = BUS.GetDataNV();
            txtIDNhanVien.Text = "NV" + (Convert.ToInt32(dtNV.Rows[dtNV.Rows.Count - 1]["IDNhanVien"].ToString().Substring(2)) + 1).ToString();
        }
    }
}
