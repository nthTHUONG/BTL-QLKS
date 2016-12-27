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
            dtpNgayMuon.Format = DateTimePickerFormat.Custom;
            dtpNgayMuon.CustomFormat = "dd/MM/yyyy HH:00";

            getTheuXe();
            LoadComboBox_MaNV();
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
                string sql = "select tx.IDThueXe, tx.MaKH, tx.MaXe, tx.ThoiGianThueXe, tx.GiaThue, tx.TienCoc from ThueXe tx where GhiChu = N'chưa thanh toán'";
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                ds = new DataSet();
                da.Fill(ds, "ThueXe");
                dgvThueXe.DataSource = ds.Tables["ThueXe"];
                try
                {
                    ds.Tables["ThueXe"].Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
        double SoGioThue(DateTime NgayMuon, DateTime NgayTra)
        {
            TimeSpan timeSpan = NgayTra.Subtract(NgayMuon);
            return timeSpan.TotalHours;
        }
        private void LoadComboBox_MaNV()
        {
            connect();
            string sql = "select IDNhanVien from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbMaNV.Text = frmDangNhap.MaNV;
            disconnect();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Reset()
        {
            txtIDThueXe.Text = "";
            txtIDKhachHang.Text = "";
            txtMaXe.Text = "";
            //txtGhiChu.Text = "";
            txtGiaThue.Text = "";
            txtTienCoc.Text = "";

        }
        string rutGonTien(string TongTien)
        {
            if (TongTien.Length < 3)
                return TongTien;
            string Dong = TongTien.Substring(TongTien.Length - 3);

            if (Dong[0] >= '5')
            {
                int i = TongTien.Length - 3;
                do
                {
                    i--;
                    if (TongTien[i] != '9')
                        TongTien = TongTien.Substring(0, i) + (char)(TongTien[i] + 1) + TongTien.Substring(i + 1);
                    else
                        TongTien = TongTien.Substring(0, i) + '0' + TongTien.Substring(i + 1);


                } while (i > 0 && TongTien[i] == '0');
            }

            TongTien = TongTien.Substring(0, TongTien.Length - 3) + "000";
            return TongTien;
        }
        private void dgvThueXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThueXe.Rows[e.RowIndex];
                txtIDThueXe.Text = row.Cells["IDThueXe"].Value.ToString();
                txtIDKhachHang.Text = row.Cells["MaKH"].Value.ToString();
                txtMaXe.Text = row.Cells["MaXe"].Value.ToString();            
                dtpNgayMuon.Value = (DateTime)row.Cells["ThoiGianThueXe"].Value;
                txtGiaThue.Text = row.Cells["GiaThue"].Value.ToString();
                txtTienCoc.Text = row.Cells["TienCoc"].Value.ToString();
                double tiencoc = double.Parse(row.Cells["TienCoc"].Value.ToString());
                double giathue = double.Parse(row.Cells["GiaThue"].Value.ToString());
                double thoiGianThue = SoGioThue(dtpNgayMuon.Value, DateTime.Now) / 24;
                int tien = (int)((thoiGianThue * giathue) - tiencoc);

                string TongTien = tien.ToString();
                //MessageBox.Show("Tiền Lúc Đầu: " + TongTien);
                lblTongTien.Text = rutGonTien(TongTien);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemThueXe frmF = new frmThemThueXe();
            this.Hide();
            frmF.ShowDialog();
            this.Show();
            getTheuXe();

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(dgvThueXe.SelectedRows.Count <= 0)
            {
                MessageBox.Show("chưa chọn người cần thanh toán");
                return;
            }
            connect();
            try
            {
                string sql = "update ThueXe set ThoiGianTraXe = '"+ DateTime.Now.ToString("yyyy-MM-dd HH:mm") +"', TongTien = "+ lblTongTien.Text +",GhiChu = N'Đã Thanh Toán' where IDThueXe = N'" + txtIDThueXe.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();

                string sql2 = "update Xe set TrangThai = 'True' where IDXe = N'" + txtMaXe.Text + "'";
                cmd = new SqlCommand(sql, cnn);
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

        private void timerXe_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss tt");
        }
    }
}
