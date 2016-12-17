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
<<<<<<< HEAD
        public DataTable GetDataTP()
=======
        public DataTable GetDataTP(string sql)
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
<<<<<<< HEAD
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
=======
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
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
<<<<<<< HEAD
            string sql = "INSERT INTO ThucPham VALUES(N'" + tp.IDThucPham + "', N'" + tp.TenTP + "', N'" + tp.NhaSX
                + "', '" + tp.NgaySX.ToString("yyyy-MM-dd") + "', '" + tp.HanSD.ToString("yyyy-MM-dd") + "', N'" + tp.MieuTa + "')";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("INSERT INTO ThucPham(IDThucPham, TenTP, NhaSX, NgaySX, HanSD, MieuTa) VALUES(N'"+ tp.IDThucPham +"',N'"+ tp.TenTP +"', N'"+ tp.NhaSX +"', '"+ tp.NgaySX.ToString("yyyy-MM-dd") +"', '"+ tp.HanSD.ToString("yyyy-MM-dd") +"',N'"+ tp.MieuTa +"')");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        public Boolean SuaTP(ThucPham_DTO tp)
        {
<<<<<<< HEAD
            string sql = "UPDATE ThucPham SET TenTP = N'" + tp.TenTP
                + "', NhaSX = N'" + tp.NhaSX + "', NgaySX = '" + tp.NgaySX.ToString("yyyy-MM-dd")
                + "', HanSD = '" + tp.HanSD.ToString("yyyy-MM-dd") + "', MieuTa = N'" + tp.MieuTa
                + "'WHERE IDThucPham = N'" + tp.IDThucPham + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("UPDATE ThucPham SET TenTP = N'" + tp.TenTP
                + "', NhaSX = N'" + tp.NhaSX + "', NgaySX = '" + tp.NgaySX.ToString("yyyy-MM-dd") + "', HanSD = '" + tp.HanSD.ToString("yyyy-MM-dd")
                + "', MieuTa = N'" + tp.MieuTa + "'WHERE IDThucPham = N'" + tp.IDThucPham + "'");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        public Boolean XoaTP(string idThucPham)
        {
<<<<<<< HEAD
            string sql = "DELETE FROM ThucPham WHERE IDThucPham = N'" + idThucPham + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("DELETE FROM ThucPham WHERE IDThucPham = N'" + idThucPham + "'");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }
    }

}
