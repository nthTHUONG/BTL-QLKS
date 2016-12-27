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

namespace GUI
{
    public partial class frmThanhToanDichVuHDV : Form
    {
        SqlConnection cnn;
        string cnStr = "";
        public frmThanhToanDichVuHDV()
        {
            InitializeComponent();
        }
        public string str_MaKH;
        public string str_NgayThue;
        public string str_SoNgayThue;
        public string str_GiaThue;
        public string str_MaHDV;
        public string str_TraTruoc;

        private void frmThanhToanHDV_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cnn = new SqlConnection(cnStr);
            
            txtMaKH.Text = str_MaKH;
            dtpNgayThue.Text = str_NgayThue;
            txtSoNgayThue.Text = str_SoNgayThue;
            txtDonGia.Text = str_GiaThue;
            txtMaHDV.Text = str_MaHDV;
            txtTraTruoc.Text = str_TraTruoc;
            cbbMaNV.Text = frmDangNhap.MaNV;
            TongTien();
        }

        private void TongTien()
        {
            decimal tongTien, giaThue, traTruoc;
            int soNgayThue;
            soNgayThue = int.Parse(txtSoNgayThue.Text);
            giaThue = decimal.Parse(txtDonGia.Text);
            traTruoc = decimal.Parse(txtTraTruoc.Text);
            tongTien = soNgayThue * giaThue - traTruoc;
            lblTongTien.Text = tongTien.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss tt");
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
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công!");
        }
    }
}
