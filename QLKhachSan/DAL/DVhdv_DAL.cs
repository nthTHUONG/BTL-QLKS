using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class DVhdv_DAL
    {
        public DataTable GetDataDVhdv()
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM DichVuHDV";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                ConnectDB.Close(conn);
            }
        }
        public Boolean ThemDVhdv(DVhdv_DTO DVhdv)
        {
            string sql = "INSERT INTO DichVuHDV VALUES(N'" + DVhdv.IDDVhdv + "', N'" + DVhdv.MaKH + "', N'" + DVhdv.MaHDV
                + "', '" + DVhdv.NgayThue.ToString("yyyy-MM-dd") + "', '" + DVhdv.SoNgayThue
                + "', '" + DVhdv.GiaThue + "', '" + DVhdv.TraTruoc + "', N'" + DVhdv.GhiChu + "')";
            return new ExecuteDB().ExecuteData(sql);
        }
        public Boolean SuaDVhdv(DVhdv_DTO DVhdv)
        {
            string sql = "UPDATE DichVuHDV SET MaKH = N'" + DVhdv.MaKH + "', MaHDV = N'" + DVhdv.MaHDV
                + "', NgayThue = '" + DVhdv.NgayThue.ToString("yyyy-MM-dd") + "', SoNgayThue = '" + DVhdv.SoNgayThue + "', GiaThue = '" + DVhdv.GiaThue
                + "', TraTruoc = '" + DVhdv.TraTruoc + "', GhiChu = N'" + DVhdv.GhiChu + "'WHERE IDDVhdv = N'" + DVhdv.IDDVhdv + "'";
            return new ExecuteDB().ExecuteData(sql);
        }
        public Boolean XoaDVhdv(string idDVhdv)
        {
            string sql = "DELETE FROM DichVuHDV WHERE IDDVhdv = N'" + idDVhdv + "'";
            return new ExecuteDB().ExecuteData(sql);
        }
    }
}
