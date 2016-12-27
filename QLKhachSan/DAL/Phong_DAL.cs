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
    public class Phong_DAL
    {
        public DataTable GetDataPhong()
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM Phong";
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

        public DataTable GetDataPhong_fromTenLP(string tenLP)
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM Phong WHERE MaLP IN (SELECT IDLoaiPhong FROM LoaiPhong WHERE TenLP = N'" + tenLP + "')";
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

        public Boolean ThemPhong(Phong_DTO p)
        {
            string sql = "INSERT INTO Phong(IDPhong, MaLP, GhiChu, TrangThai) VALUES(N'" + p.IDPhong + "', N'" + p.MaLP
                + "', N'" + p.GhiChu + "', '" + p.TrangThai + "')";
            return new ExecuteDB().ExecuteData(sql);
        }

        public Boolean SuaPhong(Phong_DTO p)
        {
            string sql = "UPDATE Phong SET MaLP = N'" + p.MaLP + "', GhiChu = N'" + p.GhiChu
                + "', TrangThai = '" + p.TrangThai + "'WHERE IDPhong = N'" + p.IDPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
        }

        public Boolean XoaPhong(string idPhong)
        {
            string sql = "DELETE FROM Phong WHERE IDPhong = N'" + idPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
        }
    }
}
