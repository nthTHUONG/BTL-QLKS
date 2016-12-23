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
        SqlConnection cnn;
        DataSet ds;
        string cnstr;
        public frmDichVuHDV()
        {
            InitializeComponent();
        }

        private void frmDichVuHDV_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            BUS = new Business();
            dgvDVhdv.DataSource = BUS.GetDataDVhdv();
            LoadComBoBox();
            Init();
        }

        private void LoadComBoBox()
        {
            cbbMaKH.DataSource = BUS.GetDataKH();
            cbbMaKH.DisplayMember = "IDKhachHang";
        }
=======
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cnn = new SqlConnection(cnstr);
            getDichVuHDV();
        }

        //private void LoadComBoBox()
        //{
        //    cbbMaKH.DataSource = ("SELECT IDKhachHang FROM KhachHang");
        //    cbbMaKH.DisplayMember = "IDKhachHang";

        //    cbbMaHDV.DataSource = ("SELECT IDHDV FROM HuongDanVien");
        //    cbbMaHDV.DisplayMember = "IDHDV";   

        //}
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a

        private void Init()
        {
            txtIDDVhdv.Text = "";
<<<<<<< HEAD
            cbbMaKH.Text = "Chọn mã khách hàng";
            cbbMaHDV.Text = "Chọn mã hướng dẫn viên";
            txtSoNgayThue.Text = "";
            txtGiaThue.Text = "";
            txtTraTruoc.Text = "";
            txtGhiChu.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
=======
            txtMaKH.Text = "";
            txtMaHDV.Text = "";
            dtpNgayThue.Text = "";
            txtGiaThue.Text = "";
            txtGhiChu.Text = "";
        }
        private void getDichVuHDV()
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
        {
            try
            {
<<<<<<< HEAD
                if (MessageBox.Show("Thêm dịch vụ hướng dẫn viên?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.ThemDVhdv(DVhdv);
                    MessageBox.Show("Thêm thành công!");
                    dgvDVhdv.DataSource = BUS.GetDataDVhdv();
                    Init();
                }
=======
                string sql = "select * from DichVuHDV where GhiChu = N'Chưa thanh toán'";
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                ds = new DataSet();
                da.Fill(ds, "DichVuHDV");
                dgvDVhdv.DataSource = ds.Tables["DichVuHDV"];
                MessageBox.Show("Load thành công!");
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
            }
            catch (Exception)
            {
                MessageBox.Show("Load fail!");
               // throw;
            }
           
        }
        private void connect()
        {
            try
            {
<<<<<<< HEAD
                DVhdv_DTO DVhdv = new DVhdv_DTO(txtIDDVhdv.Text, cbbMaKH.Text, cbbMaHDV.Text, dtpNgayThue.Text, txtSoNgayThue.Text, txtGiaThue.Text, txtTraTruoc.Text, txtGhiChu.Text);
                if (MessageBox.Show("Lưu sửa đổi?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUS.SuaDVhdv(DVhdv);
                    MessageBox.Show("Sửa thành công!");
                    dgvDVhdv.DataSource = BUS.GetDataDVhdv();
                    Init();
                }
=======
                if (cnn != null && cnn.State != ConnectionState.Open)
                    cnn.Open();
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
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
                // throw;
            }
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            frmThanhToanHDV frm = new frmThanhToanHDV();
            frm.ShowDialog();
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

        private void dgvDVhdv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDVhdv.Rows[e.RowIndex];
                txtIDDVhdv.Text = row.Cells["IDDvHDV"].Value.ToString();
                txtMaKH.Text = row.Cells["MaKH"].Value.ToString();
                txtMaHDV.Text = row.Cells["MaHDV"].Value.ToString();
                dtpNgayThue.Text = row.Cells["NgayThue"].Value.ToString();
                txtGiaThue.Text = row.Cells["GiaThue"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                string sql = "update DichVuHDV set GhiChu = N'Đã thanh toán' where IDDvHDV = N'" + txtIDDVhdv.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Đã thanh toán thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Thanh toán không thành công!");
                //throw;
            }
            getDichVuHDV();
            disconnect();
            
        }
    }
}
