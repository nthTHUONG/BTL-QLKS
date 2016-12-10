using DTO;
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

namespace GUI
{
    public partial class frmDatPhong : Form
    {
        string cnStr = @"server = (local); database = QLKhachSan; integrated security = true;";
        SqlConnection cnn;
        List<DatPhong_DTO> lst = new List<DatPhong_DTO>();
        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
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
                //throw;
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
            string sql = "select * from ChiTietDatPhong";
            SqlCommand cmd = new SqlCommand(sql, cnn);  //sql + cnStr de ket noi du lieu
            SqlDataReader dr = cmd.ExecuteReader();
            lst.Clear();
            while (dr.Read() == true)
            {
                DatPhong_DTO dp = new DatPhong_DTO();
                //kh.IDKhachHang = dr.GetString(0);
                dp.IDDatPhong = dr["IDDatPhong"].ToString();
                dp.MaPhong = dr["MaPhong"].ToString();
                dp.MaLP = dr["MaLP"].ToString();
                dp.MaKH = dr["MaKH"].ToString();
                dp.MaNV = dr["MaNV"].ToString();
                dp.NgayDat = Convert.ToDateTime(dr["NgayDat"]);
                dp.NgayNhan = Convert.ToDateTime(dr["NgayNhan"]);
                dp.NgayTra = Convert.ToDateTime(dr["NgayTra"]);
                dp.GiaPhong = Convert.ToDecimal(dr["GiaPhong"]);
                dp.TraTruoc = Convert.ToDecimal(dr["TraTruoc"]);
                dp.GhiChu = dr["GhiChu"].ToString();
                lst.Add(dp);
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
            txtIDDatPhong.Text = "";
            txtMaKH.Text = "";
            txtMaNV.Text = "";
            txtMaPhong.Text = "";
            txtMaLP.Text = "";
            txtNgayDat.Text = "";
            txtNgayNhan.Text = "";
            txtNgayTra.Text = "";
            txtGiaPhong.Text = "";
            txtTraTruoc.Text = "";
            txtGhiChu.Text = "";
        }
    }
}
