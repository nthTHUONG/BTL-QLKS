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

namespace GUI
{
    public partial class frmChiTietXe : Form
    {
        Business BUS;
        public frmChiTietXe()
        {
            InitializeComponent();
        }

        private void frmChiTietXe_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            dgvXe.DataSource = BUS.GetDataXe();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                Xe_DTO xe = new Xe_DTO(txtIDXe.Text, txtHangSX.Text, txtLoaiXe.Text, txtGiaThue.Text, txtGhiChu.Text, txtTrangThai.Text);
                BUS.ThemXe(xe);
                dgvXe.DataSource = BUS.GetDataXe();
                MessageBox.Show("Đã thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Xe_DTO xe = new Xe_DTO(txtIDXe.Text, txtHangSX.Text, txtLoaiXe.Text, txtGiaThue.Text, txtGhiChu.Text, txtTrangThai.Text);
                BUS.SuaXe(xe);
                dgvXe.DataSource = BUS.GetDataXe();
                MessageBox.Show("Đã cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                BUS.XoaXe(txtIDXe.Text);
                dgvXe.DataSource = BUS.GetDataXe();
                MessageBox.Show("Đã xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvXe.Rows[e.RowIndex];
                txtIDXe.Text = row.Cells[0].Value.ToString();
                txtHangSX.Text = row.Cells[1].Value.ToString();
                txtLoaiXe.Text = row.Cells[2].Value.ToString();
                txtGiaThue.Text = row.Cells[3].Value.ToString();
                txtGhiChu.Text = row.Cells[4].Value.ToString();
                txtTrangThai.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIDXe.Text = "";
            txtHangSX.Text = "";
            txtLoaiXe.Text = "";
            txtGiaThue.Text = "";
            txtGhiChu.Text = "";
            txtTrangThai.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
