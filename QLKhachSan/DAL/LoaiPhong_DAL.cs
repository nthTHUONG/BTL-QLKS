using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiPhong_DAL
    {
        public DataTable GetDataLP()
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM LoaiPhong";
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
                conn.Dispose();
            }
        }

<<<<<<< HEAD
        public DataTable GetDataLP_IDLP(string idLoaiPhong)
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM LoaiPhong WHERE IDLoaiPhong = N'" + idLoaiPhong + "'";
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
                conn.Dispose();
            }
        }

=======
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        public DataTable GetDataLP_fromIDPhong(string idPhong)
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM LoaiPhong WHERE IDLoaiPhong IN(SELECT MaLP FROM Phong WHERE IDPhong = N'" + idPhong + "')";
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
                conn.Dispose();
            }
        }
<<<<<<< HEAD

        public Boolean ThemLP(LoaiPhong_DTO lp)
        {
            string sql = "INSERT INTO LoaiPhong VALUES(N'" + lp.IDLoaiPhong + "', N'" + lp.TenLP
                + "', '" + lp.GiaLP + "', '" + lp.SoLuong + "', '" + lp.GhiChu + "')";
            return new ExecuteDB().ExecuteData(sql);
=======
       
        public Boolean ThemLP(LoaiPhong_DTO lp)
        {
            return new ExecuteDB().ExecuteData("INSERT INTO LoaiPhong VALUES(N'" + lp.IDLoaiPhong + "', N'" + lp.TenLP
                + "', '" + lp.GiaLP + "', '" + lp.SoLuong + "', '" + lp.GhiChu + "')");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        public Boolean SuaLP(LoaiPhong_DTO lp)
        {
<<<<<<< HEAD
            string sql = "UPDATE LoaiPhong SET TenLP = N'" + lp.TenLP + "', GiaLP = '" + lp.GiaLP
                + "', SoLuong = '" + lp.SoLuong + "', GhiChu = '" + lp.GhiChu + "'WHERE IDLoaiPhong = N'" + lp.IDLoaiPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("UPDATE LoaiPhong SET TenLP = N'" + lp.TenLP + "', GiaLP = '" + lp.GiaLP
                + "', SoLuong = '" + lp.SoLuong + "', GhiChu = '" + lp.GhiChu + "'WHERE IDLoaiPhong = N'" + lp.IDLoaiPhong + "'");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        public Boolean XoaLP(string idLoaiPhong)
        {
<<<<<<< HEAD
            string sql = "DELETE FROM LoaiPhong WHERE IDLoaiPhong = N'" + idLoaiPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("DELETE FROM LoaiPhong WHERE IDLoaiPhong = N'" + idLoaiPhong + "'");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }
    }
}
