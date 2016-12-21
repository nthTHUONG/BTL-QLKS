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

        private void Init()
        {
            txtIDDVhdv.Text = "";
            txtMaKH.Text = "";
            txtMaHDV.Text = "";
            dtpNgayThue.Text = "";
            txtGiaThue.Text = "";
            txtGhiChu.Text = "";
        }
        private void getDichVuHDV()
        {
            try
            {
                string sql = "select * from DichVuHDV where GhiChu = N'Chưa thanh toán'";
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                ds = new DataSet();
                da.Fill(ds, "DichVuHDV");
                dgvDVhdv.DataSource = ds.Tables["DichVuHDV"];
                MessageBox.Show("Load thành công!");
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
                if (cnn != null && cnn.State != ConnectionState.Open)
                    cnn.Open();
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
