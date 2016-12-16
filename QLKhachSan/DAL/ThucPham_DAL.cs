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
        public DataTable GetDataTP(string sql)
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
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
            return new ExecuteDB().ExecuteData("INSERT INTO ThucPham(IDThucPham, TenTP, NhaSX, NgaySX, HanSD, MieuTa) VALUES(N'"+ tp.IDThucPham +"',N'"+ tp.TenTP +"', N'"+ tp.NhaSX +"', '"+ tp.NgaySX.ToString("yyyy-MM-dd") +"', '"+ tp.HanSD.ToString("yyyy-MM-dd") +"',N'"+ tp.MieuTa +"')");
        }

        public Boolean SuaTP(ThucPham_DTO tp)
        {
            return new ExecuteDB().ExecuteData("UPDATE ThucPham SET TenTP = N'" + tp.TenTP
                + "', NhaSX = N'" + tp.NhaSX + "', NgaySX = '" + tp.NgaySX.ToString("yyyy-MM-dd") + "', HanSD = '" + tp.HanSD.ToString("yyyy-MM-dd")
                + "', MieuTa = N'" + tp.MieuTa + "'WHERE IDThucPham = N'" + tp.IDThucPham + "'");
        }

        public Boolean XoaTP(string idThucPham)
        {
            return new ExecuteDB().ExecuteData("DELETE FROM ThucPham WHERE IDThucPham = N'" + idThucPham + "'");
        }
    }

}
