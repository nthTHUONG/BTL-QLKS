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
<<<<<<< HEAD
            dgvDVhdv.DataSource = BUS.GetDataDVhdv();
=======
            dgvDVhdv.DataSource = BUS.GetDataDVhdv("SELECT * FROM DichVuHDV");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            LoadComBoBox();
            Init();
        }

        private void LoadComBoBox()
        {
            cbbMaKH.DataSource = BUS.GetDataKH();
            cbbMaKH.DisplayMember = "IDKhachHang";
<<<<<<< HEAD
        }

        private void Init()
        {
            txtIDDVhdv.Text = "";
            cbbMaKH.Text = "Chọn mã khách hàng";
            cbbMaHDV.Text = "Chọn mã hướng dẫn viên";
            txtSoNgayThue.Text = "";
            txtGiaThue.Text = "";
            txtTraTruoc.Text = "";
            txtGhiChu.Text = "";
        }

=======

            cbbMaHDV.DataSource = BUS.GetDataDVhdv("SELECT IDHDV FROM HuongDanVien");
            cbbMaHDV.DisplayMember = "IDHDV";

        }

        private void Init()
        {
            txtIDDVhdv.Text = "";
            cbbMaKH.Text = "Chọn mã khách hàng";
            cbbMaHDV.Text = "Chọn mã hướng dẫn viên";
            txtSoNgayThue.Text = "";
            txtGiaThue.Text = "";
            txtTraTruoc.Text = "";
            txtGhiChu.Text = "";
        }

>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        private void btThem_Click(object sender, EventArgs e)
        {
            DVhdv_DTO DVhdv = new DVhdv_DTO(txtIDDVhdv.Text, cbbMaKH.Text, cbbMaHDV.Text, dtpNgayThue.Text, txtSoNgayThue.Text, txtGiaThue.Text, txtTraTruoc.Text, txtGhiChu.Text);
            try
            {
                if (MessageBox.Show("Thêm dịch vụ hướng dẫn viên?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.ThemDVhdv(DVhdv);
                    MessageBox.Show("Thêm thành công!");
<<<<<<< HEAD
                    dgvDVhdv.DataSource = BUS.GetDataDVhdv();
=======
                    dgvDVhdv.DataSource = BUS.GetDataDVhdv("SELECT * FROM DichVuHDV");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                DVhdv_DTO DVhdv = new DVhdv_DTO(txtIDDVhdv.Text, cbbMaKH.Text, cbbMaHDV.Text, dtpNgayThue.Text, txtSoNgayThue.Text, txtGiaThue.Text, txtTraTruoc.Text, txtGhiChu.Text);
                if (MessageBox.Show("Lưu sửa đổi?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.SuaDVhdv(DVhdv);
                    MessageBox.Show("Sửa thành công!");
<<<<<<< HEAD
                    dgvDVhdv.DataSource = BUS.GetDataDVhdv();
=======
                    dgvDVhdv.DataSource = BUS.GetDataDVhdv("SELECT * FROM DichVuHDV");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
<<<<<<< HEAD
            {
                if (MessageBox.Show("Xóa dịch vụ hướng dẫn viên?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.XoaDVhdv(txtIDDVhdv.Text);
                    MessageBox.Show("Xóa thành công!");
                    dgvDVhdv.DataSource = BUS.GetDataDVhdv();
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
=======
            {
                if (MessageBox.Show("Xóa dịch vụ hướng dẫn viên?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.XoaDVhdv(txtIDDVhdv.Text);
                    MessageBox.Show("Xóa thành công!");
                    dgvDVhdv.DataSource = BUS.GetDataDVhdv("SELECT * FROM DichVuHDV");
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Reset?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Init();
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dgvDVhdv.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dgvDVhdv.RowCount - 1; i++)
                {
                    dgvDVhdv.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvDVhdv.RowCount - 1; i++)
                {
                    if (dgvDVhdv.Rows[i].Cells["IDDVhdv"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dgvDVhdv.Rows[i].Cells["MaKH"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dgvDVhdv.Rows[i].Cells["MaHDV"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dgvDVhdv.Rows[i].Visible = true;
                    }
                    else
                    {
                        dgvDVhdv.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void dgvDVhdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDVhdv.Rows[e.RowIndex];
                txtIDDVhdv.Text = row.Cells[0].Value.ToString();
                cbbMaKH.Text = row.Cells[1].Value.ToString();
                cbbMaHDV.Text = row.Cells[2].Value.ToString();
                dtpNgayThue.Text = row.Cells[3].Value.ToString();
                txtSoNgayThue.Text = row.Cells[4].Value.ToString();
                txtGiaThue.Text = row.Cells[5].Value.ToString();
                txtTraTruoc.Text = row.Cells[6].Value.ToString();
                txtGhiChu.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
