using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
using BLL;
namespace GUI
{
    public partial class frmDichVuHDV : Form
    {
        Business BUS;
        public frmDichVuHDV()
        {
            InitializeComponent();
        }

        private void frmDichVuHDV_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            dataV.DataSource = BUS.GetDataDVhdv();
            //DataTable dtKH = new DataTable();
            DataTable dtKH = null;
            dtKH = BUS.GetDataKH();
            cbbMaKH.DataSource = dtKH;
            cbbMaKH.DisplayMember = "IDKhachHang";
            DataTable dtHDV = null;
            dtHDV = BUS.GetDataDVhdv();
            cbbMaHDV.DataSource = dtHDV;
            cbbMaHDV.DisplayMember = "MaHDV";
          
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            HDV_DTO hdv = new HDV_DTO(txtIDdvHDV.Text, cbbMaKH.Text, cbbMaHDV.Text, dtpNgayThue.Text, txtGiaThue.Text, txtGhiChu.Text);
            Boolean status = BUS.ThemDVhdv(hdv);
            if (status == true)
            {
                MessageBox.Show("Thêm thành công!");
                dataV.DataSource = BUS.GetDataDVhdv();
                btReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Chưa nhập hoặc nhập trùng mã dịch vụ HDV.");
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtIDdvHDV.Text = "";
            cbbMaKH.Text = "";
            cbbMaHDV.Text = "";
            dtpNgayThue.Text = "";
            txtGiaThue.Text = "";
            txtGhiChu.Text = "";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            HDV_DTO hdv = new HDV_DTO(txtIDdvHDV.Text, cbbMaKH.Text, cbbMaHDV.Text, dtpNgayThue.Text, txtGiaThue.Text, txtGhiChu.Text);
            Boolean status = BUS.SuaDVhdv(hdv);
            btReset_Click(sender, e);
            if (status == true)
            {
                MessageBox.Show("Sửa thành công!");
                dataV.DataSource = BUS.GetDataDVhdv();
                btReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            BUS = new Business();
            Boolean status = BUS.XoaDVhdv(txtIDdvHDV.Text);
            btReset_Click(sender, e);
            if (status == true)
            {
                MessageBox.Show("Xóa thành công!");
                dataV.DataSource = BUS.GetDataDVhdv();
                btReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa thất bại! Mã dịch vụ không tồn tại.");
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dataV.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dataV.RowCount - 1; i++)
                {
                    dataV.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dataV.RowCount - 1; i++)
                {
                    if (dataV.Rows[i].Cells["IDDvHDV"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dataV.Rows[i].Cells["MaKH"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dataV.Rows[i].Cells["MaHDV"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dataV.Rows[i].Cells["GiaThue"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dataV.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataV.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void dataV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataV.Rows[e.RowIndex];
                txtIDdvHDV.Text = row.Cells[0].Value.ToString();
                cbbMaKH.Text = row.Cells[1].Value.ToString();
                cbbMaHDV.Text = row.Cells[2].Value.ToString();
                dtpNgayThue.Text = row.Cells[3].Value.ToString();
                txtGiaThue.Text = row.Cells[4].Value.ToString();
                txtGhiChu.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
