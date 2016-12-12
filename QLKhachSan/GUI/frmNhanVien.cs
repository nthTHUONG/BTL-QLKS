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
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            NhanVien_DTO nv = new NhanVien_DTO(txtIDNhanVien.Text, txtHo.Text, txtTen.Text, txtChucVu.Text, txtGioiTinh.Text, dtpNgaySinh.Text, txtSDT.Text, txtDiaChi.Text);
            Boolean status = BUS.ThemNV(nv);
            if (status == true)
            {
                MessageBox.Show("Thêm thành công!");
                dgvNhanVien.DataSource = BUS.GetDataNV();
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Chưa nhập hoặc nhập trùng mã nhân viên.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            NhanVien_DTO nv = new NhanVien_DTO(txtIDNhanVien.Text, txtHo.Text, txtTen.Text, txtChucVu.Text, txtGioiTinh.Text, dtpNgaySinh.Text, txtSDT.Text, txtDiaChi.Text);
            Boolean status = BUS.SuaNV(nv);
            btnReset_Click(sender, e);
            if (status == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgvNhanVien.DataSource = BUS.GetDataNV();
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
            Boolean status = BUS.XoaDVhdv(txtIDNhanVien.Text);
            btnReset_Click(sender, e);
            if (status == true)
            {
                MessageBox.Show("Xóa thành công!");
                dgvNhanVien.DataSource = BUS.GetDataNV();
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa thất bại! Mã nhân viên không tồn tại.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIDNhanVien.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtChucVu.Text = "";
            txtGioiTinh.Text = "";
            dtpNgaySinh.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
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
                txtIDNhanVien.Text = row.Cells[0].Value.ToString();
                txtHo.Text = row.Cells[1].Value.ToString();
                txtTen.Text = row.Cells[2].Value.ToString();
                txtChucVu.Text = row.Cells[3].Value.ToString();
                txtGioiTinh.Text = row.Cells[4].Value.ToString();
                dtpNgaySinh.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
                txtDiaChi.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
