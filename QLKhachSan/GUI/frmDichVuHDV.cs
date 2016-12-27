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
        SqlConnection cnn;
        string cnStr = "";
        public frmDichVuHDV()
        {
            InitializeComponent();
        }

        
        private void frmDichVuHDV_Load(object sender, EventArgs e)
        {
            BUS = new Business();
            cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cnn = new SqlConnection(cnStr);
            dgvDVhdv.DataSource = BUS.GetDataDVhdv();
            LoadComBoBox_IDKhachHang();
            LoadComBoBox_IDHDV();
           
            Init();
        }
        private void connect()
        {
            try
            {
                if (cnn != null && cnn.State != ConnectionState.Open)
                    cnn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);            }

        }
        private void disconnect()
        {
            try
            {
                if (cnn != null && cnn.State != ConnectionState.Closed)
                    cnn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadComBoBox_IDKhachHang()
        {
            cbbMaKH.DataSource = BUS.GetDataKH();
            cbbMaKH.DisplayMember = "IDKhachHang";
           
        }
        private void LoadComBoBox_IDHDV()
        {
            connect();
            try
            {
                string sql = "SELECT IDHDV FROM HuongDanVien";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbMaHDV.DataSource = dt;
                cbbMaHDV.DisplayMember = "IDHDV";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            disconnect();
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
        private void btThem_Click(object sender, EventArgs e)
        {
            DVhdv_DTO DVhdv = new DVhdv_DTO(txtIDDVhdv.Text, cbbMaKH.Text, cbbMaHDV.Text, dtpNgayThue.Text, txtSoNgayThue.Text, txtGiaThue.Text, txtTraTruoc.Text, txtGhiChu.Text);
            try
            {
                if (MessageBox.Show("Thêm dịch vụ hướng dẫn viên?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.ThemDVhdv(DVhdv);
                    MessageBox.Show("Thêm thành công!");
                    dgvDVhdv.DataSource = BUS.GetDataDVhdv();
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
                    dgvDVhdv.DataSource = BUS.GetDataDVhdv();
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
                txtIDDVhdv.Text = row.Cells["IDDvHDV"].Value.ToString();
                cbbMaKH.Text = row.Cells["MaKH"].Value.ToString();
                cbbMaHDV.Text = row.Cells["MaHDV"].Value.ToString();
                dtpNgayThue.Text = row.Cells["NgayThue"].Value.ToString();
                txtSoNgayThue.Text = row.Cells["SoNgayThue"].Value.ToString();
                txtGiaThue.Text = row.Cells["GiaThue"].Value.ToString();
                txtTraTruoc.Text = row.Cells["TraTruoc"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToanDichVuHDV frmTT = new frmThanhToanDichVuHDV();
            frmTT.str_MaKH = cbbMaKH.Text;
            frmTT.str_NgayThue = dtpNgayThue.Text;
            frmTT.str_SoNgayThue = txtSoNgayThue.Text;
            frmTT.str_GiaThue = txtGiaThue.Text;
            frmTT.str_MaHDV = cbbMaHDV.Text;
            frmTT.str_TraTruoc = txtTraTruoc.Text;
            frmTT.ShowDialog();
        }
    }
}
