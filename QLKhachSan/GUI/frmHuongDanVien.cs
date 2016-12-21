using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHuongDanVien : Form
    {
        SqlConnection cnn;
        DataSet ds;
        string cnstr;
        public frmHuongDanVien()
        {
            InitializeComponent();
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
        private void getHDV()
        {
            try
            {
                string sql = "select* from HuongDanVien";
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                ds = new DataSet();
                da.Fill(ds, "HuongDanVien");
                dgvHDV.DataSource = ds.Tables["HuongDanVien"];
            }
            catch (Exception)
            {
                MessageBox.Show("Load fail!");
                //throw;
            }
           

        }
        private void frmHuongDanVien_Load(object sender, EventArgs e)
        {
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cnn = new SqlConnection(cnstr);
            getHDV();
        }

        private void dgvHDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHDV.Rows[e.RowIndex];
                txtIDHDV.Text = row.Cells["IDHDV"].Value.ToString();
                txtHo.Text = row.Cells["Ho"].Value.ToString();
                txtTen.Text = row.Cells["Ten"].Value.ToString();
                txtGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIDHDV.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtGioiTinh.Text = "";
            dtpNgaySinh.Text = "";
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dgvHDV.CurrentCell = null;
            if(txtTimKiem.Text == null)
            {
                for (int i = 0; i < dgvHDV.RowCount - 1; i++)
                {
                    dgvHDV.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvHDV.RowCount - 1; i++)
                {
                    if (dgvHDV.Rows[i].Cells["IDHDV"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true ||
                        dgvHDV.Rows[i].Cells["Ten"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true ||
                        dgvHDV.Rows[i].Cells["GioiTinh"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                        dgvHDV.Rows[i].Visible = true;
                    else
                        dgvHDV.Rows[i].Visible = false;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                string sql = "insert into HuongDanVien values(N'"+txtIDHDV.Text+"', N'"+txtHo.Text+"', N'"+txtTen.Text+"', N'"+txtGioiTinh.Text+"', N'"+dtpNgaySinh.Value.ToString("yyyy-MM-dd")+"')";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Thêm thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            getHDV();
            disconnect();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                string sql = "delete from HuongDanVien where IDHDV = N'"+txtIDHDV.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Xóa thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            getHDV();
            disconnect();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                string sql = "update HuongDanVien set Ho = N'" + txtHo.Text + "', Ten = N'" + txtTen.Text + "', GioiTinh = N'" + txtGioiTinh.Text+"', NgaySinh = N'"+dtpNgaySinh.Value.ToString("yyyy-MM-dd")+"' where IDHDV = N'"+txtIDHDV.Text+"'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            getHDV();
            disconnect();
        }
    }
}
