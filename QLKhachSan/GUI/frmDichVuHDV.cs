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
using DTO;
namespace GUI
{
    public partial class frmDichVuHDV : Form
    {
        string cnStr = @"server = (local); database = QLKhachSan; integrated security = true;";
        SqlConnection cnn;
        List<HDV_DTO> lst = new List<HDV_DTO>();
        DataSet ds;
        string cnstr;
        SqlConnection cn;
        public frmDichVuHDV()
        {
            InitializeComponent();
        }

        private void frmDichVuHDV_Load(object sender, EventArgs e)
        {
            MessageBox.Show("nhập mã kh xem thông tin sử dụng dịch vụ,chưa tạo code!!!");
            cnn = new SqlConnection(cnStr);
            try
            {
                Connection();
                LoadData();
                //dataGV_CellClick(sender, );
                Disconnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
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
        private void LoadData()
        {
            string sql = "select * from DichVuHDV";
            SqlCommand cmd = new SqlCommand(sql, cnn);  //sql + cnStr de ket noi du lieu
            SqlDataReader dr = cmd.ExecuteReader();
            lst.Clear();
            while (dr.Read() == true)
            {
                HDV_DTO hdv = new HDV_DTO();
                hdv.IDDvHDV = dr["IDDvHDV"].ToString();
                hdv.MaKH = dr["MaKH"].ToString();
                hdv.MaHDV = dr["MaHDV"].ToString();
                hdv.NgayThue = dr["NgayThue"].ToString();
                hdv.GiaThue = dr["GiaThue"].ToString();
                hdv.GhiChu = dr["GhiChu"].ToString();
                lst.Add(hdv);
            }
            cmd.Dispose();  //giai phong bien cmd
            dr.Close();
            if (dataV.DataSource != null)
            {
                dataV.DataSource = null;
                dataV.DataSource = lst;
            }
            dataV.DataSource = lst;
        }
        private void Init()
        {
            txtIDdvHDV.Text = "";
            txtMaKH.Text = "";
            txtMaHDV.Text = "";
            dtpNgayThue.Text = "";
            txtGiaThue.Text = "";
            txtGhiChu.Text = "";
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dataV.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dataV.RowCount; i++)
                {
                    dataV.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dataV.RowCount; i++)
                {
                    if (dataV.Rows[i].Cells["IDDvHDV"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || dataV.Rows[i].Cells["MaKH"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || dataV.Rows[i].Cells["MaHDV"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || dataV.Rows[i].Cells["NgayThue"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || dataV.Rows[i].Cells["GiaThue"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dataV.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataV.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Init();
        }

      
      
      
    }
}
