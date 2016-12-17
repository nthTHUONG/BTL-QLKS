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
    public partial class frmThemThueXe : Form
    {
        string cnstr;
        SqlConnection cnn;
        DataSet ds;
        public frmThemThueXe()
        {
            InitializeComponent();
        }
        private void reset()
        {
            txtIDThueXe.Text = "";
            txtIDKhachHang.Text = "";
            txtMaXe.Text = "";
            txtTienCoc.Text = "";
            txtGiaThue.Text = "";
            txtGhiChu.Text = "";
            dtpNgayMuon.Text = "";
            dtpNgayTra.Text = ""; 
        }
        private void LoadXe()
        {
            try
            {
                string sql = "select * from ChiTietXe where TrangThai = N'True'";
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                ds = new DataSet();
                da.Fill(ds, "ChiTietXe");
                dgvThemThueXe.DataSource = ds.Tables["ChiTietXe"];
            }
            catch (Exception )
            {
                MessageBox.Show("Load dữ liệu không thành công!");
<<<<<<< HEAD
=======
                //throw;
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            }
            
        }
        private void frmThemThueXe_Load(object sender, EventArgs e)
        {
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cnn = new SqlConnection(cnstr);
            LoadXe();
            txtIDThueXe.Text = SinhMa();

        }

        string SinhMa()
        {
            connect();
            string strMa = "";
            try
            {
                string sql = "select count(*) from ThueXe";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                int count = (int)cmd.ExecuteScalar();
                reset();
                
                count++;
                strMa = "TX" + count.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
<<<<<<< HEAD
=======
                //throw;
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            }
            disconnect();
            return strMa;
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dgvThemThueXe.CurrentCell = null;
            if(txtTimKiem == null)
            {
                for (int i = 0; i < dgvThemThueXe.RowCount -1; i++)
                {
                    dgvThemThueXe.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvThemThueXe.RowCount - 1; i++)
                {
                    if (dgvThemThueXe.Rows[i].Cells["LoaiXe"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
<<<<<<< HEAD
                    {
                        dgvThemThueXe.Rows[i].Visible = true;
                    }
                    else
                    {
                        dgvThemThueXe.Rows[i].Visible = false;
                    }
=======
                        
                             dgvThemThueXe.Rows[i].Visible = true;
                    else
                             dgvThemThueXe.Rows[i].Visible = false;
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
                }
            }
        }
        private void dgvThemThueXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThemThueXe.Rows[e.RowIndex];
                txtMaXe.Text = row.Cells["IDXe"].Value.ToString();
            }
        }
        private void connect()
        {
            try
            {
                if (cnn != null && cnn.State != ConnectionState.Open)
<<<<<<< HEAD
                {
                    cnn.Open();
                }
=======
                    cnn.Open();
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
<<<<<<< HEAD
=======
                //throw;
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            }
            
        }
        private void disconnect()
        {
            try
            {
                if (cnn != null && cnn.State != ConnectionState.Closed)
<<<<<<< HEAD
                {
                    cnn.Close();
                }
=======
                    cnn.Close();
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
<<<<<<< HEAD
=======
                //throw;
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                string sql = "insert into ThueXe values(N'" + txtIDThueXe.Text + "', N'" + txtIDKhachHang.Text + " ', N'" + txtMaXe.Text + "', N'" + dtpNgayMuon.Value.ToString("yyyy-MM-dd") + "', N'" + dtpNgayTra.Value.ToString("yyyy-MM-dd") + "', '" + txtGiaThue.Text + "', '" + txtTienCoc.Text + "', N'" + txtGhiChu.Text + "')";
                string sql2 = "update ChiTietXe set TrangThai = N'False' where IDXe = N'" + txtMaXe.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(sql2, cnn);
                cmd.ExecuteNonQuery();
                reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Xin nhập đầy đủ thông tin!");
<<<<<<< HEAD
=======
               // throw;
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            }
            disconnect();   
            LoadXe();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
