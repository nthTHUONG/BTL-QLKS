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
    public partial class frmKhachHang : Form
    {
        Business BUS;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            dgvKhachHang.DataSource = BUS.GetDataKH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            KhachHang_DTO kh = new KhachHang_DTO(txtIDKhachHang.Text, txtHo.Text, txtTen.Text, txtGioiTinh.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text, txtQuocTich.Text);
            Boolean status = BUS.ThemKH(kh);
            if (status == true)
            {
                MessageBox.Show("Thêm thành công!");
                dgvKhachHang.DataSource = BUS.GetDataNV();
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Chưa nhập hoặc nhập trùng mã khách hàng.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            KhachHang_DTO kh = new KhachHang_DTO(txtIDKhachHang.Text, txtHo.Text, txtTen.Text, txtGioiTinh.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text, txtQuocTich.Text);
            Boolean status = BUS.SuaKH(kh);
            if (status == true)
            {
                MessageBox.Show("Sửa thành công!");
                dgvKhachHang.DataSource = BUS.GetDataKH();
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
            Boolean status = BUS.XoaKH(txtIDKhachHang.Text);
            if (status == true)
            {
                MessageBox.Show("Xóa thành công!");
                dgvKhachHang.DataSource = BUS.GetDataKH();
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa thất bại! Mã khách hàng không tồn tại.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIDKhachHang.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtGioiTinh.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtQuocTich.Text = "";
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dgvKhachHang.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dgvKhachHang.RowCount - 1; i++)
                {
                    dgvKhachHang.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvKhachHang.RowCount - 1; i++)
                {
                    if (dgvKhachHang.Rows[i].Cells["IDKhachHang"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || (dgvKhachHang.Rows[i].Cells["Ho"].Value.ToString() + " " + dgvKhachHang.Rows[i].Cells["Ten"].Value.ToString()).ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || dgvKhachHang.Rows[i].Cells["SDT"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dgvKhachHang.Rows[i].Visible = true;
                    }
                    else
                    {
                        dgvKhachHang.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtIDKhachHang.Text = row.Cells[0].Value.ToString();
                txtHo.Text = row.Cells[1].Value.ToString();
                txtTen.Text = row.Cells[2].Value.ToString();
                txtGioiTinh.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtDiaChi.Text = row.Cells[6].Value.ToString();
                txtQuocTich.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
