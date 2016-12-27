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

        public DataTable GetDataLP_TenLP()
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT DISTINCT TenLP FROM LoaiPhong";
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

        public Boolean ThemLP(LoaiPhong_DTO lp)
        {
            string sql = "INSERT INTO LoaiPhong VALUES(N'" + lp.IDLoaiPhong + "', N'" + lp.TenLP
                + "', '" + lp.GiaLP + "', '" + lp.SoLuong + "', '" + lp.GhiChu + "')";
            return new ExecuteDB().ExecuteData(sql);
        }

        public Boolean SuaLP(LoaiPhong_DTO lp)
        {
            string sql = "UPDATE LoaiPhong SET TenLP = N'" + lp.TenLP + "', GiaLP = '" + lp.GiaLP
                + "', SoLuong = '" + lp.SoLuong + "', GhiChu = '" + lp.GhiChu + "'WHERE IDLoaiPhong = N'" + lp.IDLoaiPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
        }

        public Boolean XoaLP(string idLoaiPhong)
        {
            string sql = "DELETE FROM LoaiPhong WHERE IDLoaiPhong = N'" + idLoaiPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
        }
    }
}
