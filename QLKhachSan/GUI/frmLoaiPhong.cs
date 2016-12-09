using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class frmLoaiPhong : Form
    {
        SqlConnection cnn;
        List<LoaiPhong_DTO> lst = new List<LoaiPhong_DTO>();
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection("server = .; database = QLKhachSan; integrated security = true;");
            try
            {
                Connection();
                getLoaiPhong();
                MessageBox.Show("Đã load dữ liệu thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                Disconnection();
            }
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
                // throw;
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
                // throw;
            }
        }
        private void getLoaiPhong()
        {
            string sql = "select* from LoaiPhong";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            lst.Clear();
            while (dr.Read() == true)
            {
                LoaiPhong_DTO lp = new LoaiPhong_DTO();
                lp.IDLoaiPhong = dr["IDLoaiPhong"].ToString();
                lp.TenLP = dr["TenLP"].ToString();
                lp.GiaLP = Convert.ToDecimal(dr["GiaLP"]);
                lp.SoLuong = Convert.ToInt32(dr["SoLuong"]);
                lp.GhiChu = dr["GhiChu"].ToString();
                lst.Add(lp);
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

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();
                string sql = "update LoaiPhong set  TenLP = N'" + txtTenLPhong.Text + "', GiaLP = '" + txtGiaLP.Text + "', SoLuong = N'" + txtSoLuong.Text + "', GhiChu = N'" + txtGhiChu.Text + "' where IDLoaiPhong = N'" + txtMaLP.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                getLoaiPhong();
                MessageBox.Show("Đã update thành công!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            finally
            {
                Disconnection();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaLP.Text = "";
            txtTenLPhong.Text = "";
            txtGiaLP.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
            txtTimKiem.Text = "";
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
                    if (dataGV.Rows[i].Cells["IDLoaiPhong"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true ||
                        dataGV.Rows[i].Cells["TenLP"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true ||
                        dataGV.Rows[i].Cells["GiaLP"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true ||
                        dataGV.Rows[i].Cells["SoLuong"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dataGV.Rows[i].Visible = true;
                    }
                    else
                        dataGV.Rows[i].Visible = false;
                }
            }
        }

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGV.Rows[e.RowIndex];
                txtMaLP.Text = row.Cells[0].Value.ToString();
                txtTenLPhong.Text = row.Cells[1].Value.ToString();
                txtGiaLP.Text = row.Cells[2].Value.ToString();
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtGhiChu.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
