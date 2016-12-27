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
using System.IO;

namespace GUI
{
    public partial class frmThanhToanHDTP : Form
    {
        SqlConnection cnn;
        string cnStr = "";
        DataSet ds;
        public frmThanhToanHDTP()
        {
            InitializeComponent();
        }
        private void getHDTP()
        {
            try
            {
                string sql = "select hd.IDHoaDon, hd.MaKH, hd.MaNV, hd.NgayMua, hd.TongTien from HoaDonThucPham hd ";
                ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                da.Fill(ds, "HoaDonThucPham");
                dgvHDTP.DataSource = ds.Tables["HoaDonThucPham"];
            }
            catch (Exception)
            {
                MessageBox.Show("Fail!");
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
            }
        }
        private void getComboBox()
        {
            connect();
            try
            {
                string sql = "select IDKhachHang from KhachHang";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbIDKhachHang.DataSource = dt;
                cbbIDKhachHang.DisplayMember = "IDKhachHang";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            disconnect();        
        }
        private string SinhMa()
        {
            connect();
            string strMa = "";
            try
            {
                string sql = "select count(*) from HoaDonThucPham";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                int count = (int)cmd.ExecuteScalar();
                count++;
                strMa = "HD" + count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            disconnect();
            return strMa;
        }
        public string str;
        public string str1;
        private void ThanhToanHDTP_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cnn = new SqlConnection(cnStr);
            getHDTP();
            getComboBox();
            txtIDHoaDon.Text = SinhMa();
            lblTongTien.Text = str;
            txtIDNhanVien.Text = str1;
            cbbIDKhachHang.Text = "Nhập mã KH";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            connect();
            try
            {
                string sql = "insert into HoaDonThucPham values(N'" + txtIDHoaDon.Text + "', N'" + cbbIDKhachHang.Text + "', N'" + txtIDNhanVien.Text + "', N'" + dtpNgayMua.Value.ToString("yyyy/MM/dd") + "', '"+lblTongTien.Text+"', NULL)";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery(); 
                MessageBox.Show("Thêm Thành Công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            disconnect();
            getHDTP();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dgvHDTP.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dgvHDTP.RowCount - 1; i++)
                {
                    dgvHDTP.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvHDTP.RowCount - 1; i++)
                {
                    if (dgvHDTP.Rows[i].Cells["IDHoaDon"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dgvHDTP.Rows[i].Cells["MaKH"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                       || dgvHDTP.Rows[i].Cells["MaNV"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dgvHDTP.Rows[i].Visible = true;
                    }
                    else
                    {
                        dgvHDTP.Rows[i].Visible = false;
                    }
                }
            }
    }
    }
}
