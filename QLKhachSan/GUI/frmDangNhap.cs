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
    public partial class frmDangNhap : Form
    {
        SqlConnection cnn;
        string cnstr = "";
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public static bool coHieu;
        public static string MaNV;
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaNV.Text) == true)
            {
                MessageBox.Show("Mời nhập ID !");
                return;
            }
            if (string.IsNullOrEmpty(txtPass.Text) == true)
            {
                MessageBox.Show("Mời nhập Pass !");
                return;
            }
           
            try
            {
               
                string sql = "select COUNT(*) from NhanVien where IDNhanVien = '" + txtMaNV.Text + "'AND Pass = '" + txtPass.Text + "'";
                connect();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                int kt = (int)cmd.ExecuteScalar();
                if( kt == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    coHieu = true;
                    MaNV = txtMaNV.Text;
                    disconnect();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập!");
                    disconnect();
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show( "Lỗi nặng " + ex.Message);
                //throw;
            }
            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cnn = new SqlConnection(cnstr);
            coHieu = false;
            MaNV = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
