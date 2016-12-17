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
using System.Data.SqlClient;
using System.Configuration;

namespace GUI
{
    public partial class frmThueXe : Form
    {
        string cnstr;
        SqlConnection cnn;
        DataSet ds;
        public frmThueXe()
        {
            InitializeComponent();
        }      
        private void ThueXe_Load(object sender, EventArgs e)
        {
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cnn = new SqlConnection(cnstr);
            getTheuXe();
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
                //throw;
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
                //throw;
            }

        }
        private void getTheuXe()
        {
            try
            {
                string sql = "select * from ThueXe where GhiChu = N'chưa thanh toán'";
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                ds = new DataSet();
                try
                {
                    ds.Tables["ThueXe"].Clear();
                }
                catch (Exception)
                {
                    
                }
               
                da.Fill(ds, "ThueXe");
                dgvThueXe.DataSource = ds.Tables["ThueXe"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
        }
        private void LoadComboBox()
        {
            
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Reset()
        {
            txtIDThueXe.Text = "";
            txtIDKhachHang.Text = "";
            txtMaXe.Text = "";
            txtGhiChu.Text = "";
            txtGiaThue.Text = "";
            txtTienCoc.Text = "";

        }

        private void dgvThueXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThueXe.Rows[e.RowIndex];
                txtIDThueXe.Text = row.Cells[0].Value.ToString();
                txtIDKhachHang.Text = row.Cells[1].Value.ToString();
                txtMaXe.Text = row.Cells[2].Value.ToString();            
                dtpNgayMuon.Text = row.Cells[3].Value.ToString();
                dtpNgayTra.Text = row.Cells[4].Value.ToString();
                txtGiaThue.Text = row.Cells[5].Value.ToString();
                txtTienCoc.Text = row.Cells[6].Value.ToString();
                txtGhiChu.Text = row.Cells[7].Value.ToString();
                double tiencoc = double.Parse(row.Cells[6].Value.ToString());
                double giathue = double.Parse(row.Cells[5].Value.ToString());
                double tien = giathue - tiencoc;
                lblTongTien.Text = tien.ToString() + " đồng";

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemThueXe frmF = new frmThemThueXe();
            frmF.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                string sql = " update ThueXe set GhiChu = N'Đã Thanh Toán' where IDThueXe = N'" + txtIDThueXe.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                Reset();
                getTheuXe();
                dgvThueXe.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi!");
                //throw;
            }
            disconnect();

        }
    }
}
