using System;
using DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GUI
{
    public partial class frmChiTietHDV : Form
    {
        string cnStr = @"server = (local); database = QLKhachSan; integrated security = true;";
        SqlConnection cnn;
        List<ChiTietHDV_DTO> lst = new List<ChiTietHDV_DTO>();
        public frmChiTietHDV()
        {
            InitializeComponent();
        }

        private void frmChiTietHDV_Load(object sender, EventArgs e)
        {
            
            cnn = new SqlConnection(cnStr);
            try
            {
                Connection();
                LoadData();
                Disconnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
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
        private void LoadData()
        {
            string sql = "select * from HuongDanVien";
            SqlCommand cmd = new SqlCommand(sql, cnn);  // sql + cnStr de ket noi du lieu
            SqlDataReader dr = cmd.ExecuteReader();
            lst.Clear();
            while (dr.Read() == true)
            {
                ChiTietHDV_DTO hdv = new ChiTietHDV_DTO();
                hdv.IDHDV = dr["IDHDV"].ToString();
                hdv.Ten = dr["Ten"].ToString();
                hdv.GioiTinh = dr["GioiTinh"].ToString();
                hdv.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]).ToString("dd/MM/yyyy");    // nv.NgaySinh = ((DateTime)dr["NgaySinh"]).ToString("dd/MM/yyyy");
                lst.Add(hdv);
            }
            cmd.Dispose();  //giai phong bien cmd
            dr.Close();
            if (dataGV.DataSource != null)
            {
                dataGV.DataSource = null;
                dataGV.DataSource = lst;
            }
            dataGV.DataSource = lst;
        }

        private void Init()
        {
            txtIDHDV.Text = "";
            txtTenHDV.Text = "";
            txtGioiTinh.Text = "";
            //dtpNgaySinh = null;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();
                string sql = "insert into HuongDanVien values('" + txtIDHDV.Text + "', N'" + txtTenHDV.Text + "', N'" + txtGioiTinh.Text + "', '" + dtpNgaySinh.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                LoadData();
                MessageBox.Show("Đã thêm thành công!");
                Disconnection();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Vui lòng nhập mã HDV khác!");
                // throw;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();
                string sql = "UPDATE HuongDanVien SET Ten = N'" + txtTenHDV.Text + "', GioiTinh = N'" + txtGioiTinh.Text
                    + "', NgaySinh = N'" + dtpNgaySinh.Text
                    + "' WHERE IDHDV = N'" + txtIDHDV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                LoadData();
                MessageBox.Show("Đã cập nhật thành công!");
                Disconnection();
                Init();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                /*Connection();
                string sql = "DELETE FROM HuongDanVien WHERE IDHDV = N'" + txtIDHDV.Text + "' DELETE FROM DichVuHDV WHERE IDHDV = N'" + txtIDHDV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                LoadData();
                MessageBox.Show("Đã xóa thành công!");
                Disconnection();
                Init();*/
                Connection();
                string sql = "DELETE FROM HuongDanVien WHERE IDHDV = N'" + txtIDHDV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                LoadData();
                MessageBox.Show("Đã xóa thành công!");
                Disconnection();
                Init();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();
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
                    if (dataGV.Rows[i].Cells["IDHDV"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || dataGV.Rows[i].Cells["Ten"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || dataGV.Rows[i].Cells["GioiTinh"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
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

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGV.Rows[e.RowIndex];
                txtIDHDV.Text = row.Cells[0].Value.ToString();
                txtTenHDV.Text = row.Cells[1].Value.ToString();
                txtGioiTinh.Text = row.Cells[2].Value.ToString();
                dtpNgaySinh.Text = row.Cells[3].Value.ToString();

            }
        }
    }
}
