using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
namespace DAL
{
    public class ThucPham_DAL
    {
        public DataTable GetDataTP()
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM ThucPham";
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

        public DataTable GetDataTP(string idThucPham)
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM ThucPham WHERE IDThucPham = N'" + idThucPham + "'";
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

        public Boolean ThemTP(ThucPham_DTO tp)
        {
            string sql = "INSERT INTO ThucPham VALUES(N'" + tp.IDThucPham + "', N'" + tp.TenTP + "', '" + tp.DonGia + "', N'" + tp.NhaSX
                + "', '" + tp.NgaySX.ToString("yyyy-MM-dd") + "', '" + tp.HanSD.ToString("yyyy-MM-dd") + "', N'" + tp.MieuTa + "')";
            return new ExecuteDB().ExecuteData(sql);
        }

        public Boolean SuaTP(ThucPham_DTO tp)
        {
            string sql = "UPDATE ThucPham SET TenTP = N'" + tp.TenTP + "', DonGia = '" + tp.DonGia
                + "', NhaSX = N'" + tp.NhaSX + "', NgaySX = '" + tp.NgaySX.ToString("yyyy-MM-dd")
                + "', HanSD = '" + tp.HanSD.ToString("yyyy-MM-dd") + "', MieuTa = N'" + tp.MieuTa
                + "'WHERE IDThucPham = N'" + tp.IDThucPham + "'";
            return new ExecuteDB().ExecuteData(sql);
        }

        public Boolean XoaTP(string idThucPham)
        {
            string sql = "DELETE FROM ThucPham WHERE IDThucPham = N'" + idThucPham + "'";
            return new ExecuteDB().ExecuteData(sql);
        }
    }

}
