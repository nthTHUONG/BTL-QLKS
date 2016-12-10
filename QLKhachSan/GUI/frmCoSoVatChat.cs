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
using DTO;

namespace GUI
{
    public partial class frmCoSoVatChat : Form
    {
        SqlConnection cnn;
        List<CoSoVatChat_DTO> lst = new List<CoSoVatChat_DTO>();
        public frmCoSoVatChat()
        {
            InitializeComponent();
        }
        private void Connection()
        {
            try
            {
                if (cnn != null && cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Disconnection()
        {
            try
            {
                if (cnn != null && cnn.State != ConnectionState.Closed)
                {
                    cnn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getCSVC()
        {
            string sql = "select* from CoSoVatChat";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            lst.Clear();
            while (dr.Read() == true)
            {
                CoSoVatChat_DTO vc = new CoSoVatChat_DTO();
                vc.IDCSVC = dr["IDCSVC"].ToString();
                vc.TenCSVC = dr["TenCSVC"].ToString();
                vc.SoLuong = Convert.ToInt32(dr["SoLuong"]);
                vc.MaLP = dr["MaLP"].ToString();
                vc.TinhTrang = Convert.ToBoolean(dr["TinhTrang"]);
                vc.GhiChu = dr["GhiChu"].ToString();
                lst.Add(vc);
            }
            cmd.Dispose();
            dr.Close();
            if (dataGV.DataSource != null)
            {
                dataGV.DataSource = null;
                dataGV.DataSource = lst;
            }
            dataGV.DataSource = lst;

        }
        private void frmCoSoVatChat_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection("server = .; database = QLKhachSan; integrated security = true;");
            try
            {
                Connection();
                getCSVC();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Disconnection();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();
                string sql = "insert into CoSoVatChat values (N'" + txtMaCSVC.Text + "', N'" + txtTenCSVC.Text + "', '" + txtSoLuong.Text + "', N'" + txtMaLP.Text + "', '" + txtTinhTrang.Text + "', N'" + txtGhiChu.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                getCSVC();
                MessageBox.Show("Đã thêm thành công!");
                Disconnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();
                string sql = "update CoSoVatChat set TenCSVC = N'" + txtTenCSVC.Text + "', SoLuong = '" + txtSoLuong.Text + "', MaLP = N'" + txtMaLP.Text + "', TinhTrang = N'" + txtTinhTrang.Text + "', GhiChu = N'" + txtGhiChu.Text + "' where IDCSVC = N'" + txtMaCSVC.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                getCSVC();
                MessageBox.Show("Đã cập nhật thành công@");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                Disconnection();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Connection();
            try
            {
                string sql = "delete from CoSoVatChat where IDCSVC = N'" + txtMaCSVC.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                getCSVC();
                MessageBox.Show("Đã Xóa thành công hàng dữ liệu!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //  throw;
            }
            finally
            {
                Disconnection();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaCSVC.Text = "";
            txtTenCSVC.Text = "";
            txtMaLP.Text = "";
            txtSoLuong.Text = "";
            txtTinhTrang.Text = "";
            txtGhiChu.Text = "";
        }

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGV.Rows[e.RowIndex];
                txtMaCSVC.Text = row.Cells[0].Value.ToString();
                txtTenCSVC.Text = row.Cells[1].Value.ToString();
                txtSoLuong.Text = row.Cells[2].Value.ToString();
                txtMaLP.Text = row.Cells[3].Value.ToString();
                txtTinhTrang.Text = row.Cells[4].Value.ToString();
                txtGhiChu.Text = row.Cells[5].Value.ToString();
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dataGV.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dataGV.RowCount; i++)
                {
                    dataGV.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dataGV.RowCount; i++)
                {
                    if ((dataGV.Rows[i].Cells["IDCSVC"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                        || (dataGV.Rows[i].Cells["TenCSVC"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true))
                    {
                        dataGV.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGV.Rows[i].Visible = false;
                    }
                }
            }
        }
    }
}
