using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class frm_ThongKe : Form
    {
        public frm_ThongKe()
        {
            InitializeComponent();
        }
        string cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable load_TheoNgay(DateTime batDau, DateTime ketThuc)
        {
            DataTable dtb = new DataTable();
            try
            {
                string sql = "SELECT DAY(dp.NgayNhan) AS ThoiGian, COUNT(*) AS SoLuong FROM DatPhong dp WHERE NgayNhan >= '" + batDau.ToString("yyyy-MM-dd") + "' AND NgayNhan <= '" + ketThuc.ToString("yyyy-MM-dd") + "' GROUP BY DAY(NgayNhan)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                da = new SqlDataAdapter(cmd);
                
                da.Fill(dtb);
                cmd.Dispose();

            }
            catch (Exception)
            {
                return null;
            }

            return dtb;
        }

        DataTable load_TheoThang(DateTime batDau, DateTime ketThuc)
        {
            DataTable dtb = new DataTable();

            try
            {
                string sql = "SELECT MONTH(dp.NgayNhan) AS ThoiGian, COUNT(*) AS SoLuong FROM DatPhong dp WHERE NgayNhan >= '" + batDau.ToString("yyyy-MM-dd") + "' AND NgayNhan <= '" + ketThuc.ToString("yyyy-MM-dd") + "' GROUP BY MONTH(NgayNhan)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                da = new SqlDataAdapter(cmd);
                
                da.Fill(dtb);
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dtb;
        }

        DataTable load_TheoNam(DateTime batDau, DateTime ketThuc)
        {
            DataTable dtb = new DataTable();
            try
            {
                string sql = "SELECT YEAR(dp.NgayNhan) AS ThoiGian, COUNT(*) AS SoLuong FROM DatPhong dp WHERE NgayNhan >= '" + batDau.ToString("yyyy-MM-dd") + "' AND NgayNhan <= '" + ketThuc.ToString("yyyy-MM-dd") + "' GROUP BY YEAR(NgayNhan)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                da = new SqlDataAdapter(cmd);
               
                da.Fill(dtb);
                cmd.Dispose();

            }
            catch (Exception)
            {
                return null;
            }

            return dtb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbNgay.Checked == true)
                chart1.DataSource = load_TheoNgay(dtpBatDau.Value, dtpKetThuc.Value);
            else if(rdbThang.Checked == true)
                chart1.DataSource = load_TheoThang(dtpBatDau.Value, dtpKetThuc.Value);
            else
                chart1.DataSource = load_TheoNam(dtpBatDau.Value, dtpKetThuc.Value);

            if (chart1.DataSource == null)
                return;

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Thời Gian";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng";
            chart1.Series[0].XValueType = ChartValueType.Int32;
            chart1.Series[0].XValueMember = "ThoiGian";
            chart1.Series[0].YValueMembers = "SoLuong";
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            dtpKetThuc.Value = dtpBatDau.Value = DateTime.Now;
            rdbNgay.Checked = true;
            conn = new SqlConnection(cnstr);
        }
    }
}
