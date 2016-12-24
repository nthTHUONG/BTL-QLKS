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
    public partial class frmThanhToanHDV : Form
    {
        SqlConnection cnn;
        string cnStr = "";
        public frmThanhToanHDV()
        {
            InitializeComponent();
        }

        private void frmThanhToanHDV_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            cnn = new SqlConnection(cnStr);
            LoadComBoBox_IDNhanVien();
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
        private void LoadComBoBox_IDNhanVien()
        {
            connect();
            try
            {
                string sql = "SELECT IDNhanVien FROM NhanVien";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbMaNV.DataSource = dt;
                cbbMaNV.DisplayMember = "IDNhanVien";
                cbbMaNV.Text = "Nhập Mã NV";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            disconnect();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
