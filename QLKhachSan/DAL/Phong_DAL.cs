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
        public DataTable GetDataPhong(string sql)
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
                conn.Dispose();
            }
        }

        public Boolean ThemPhong(Phong_DTO p)
        {
            return new ExecuteDB().ExecuteData("INSERT INTO Phong(IDPhong, MaLP, GhiChu, TrangThai) VALUES(N'" + p.IDPhong + "', N'" + p.MaLP
                + "', N'" + p.GhiChu + "', '" + p.TrangThai + "')");
        }

        public Boolean SuaPhong(Phong_DTO p)
        {
            return new ExecuteDB().ExecuteData("UPDATE Phong SET MaLP = N'" + p.MaLP + "', GhiChu = N'" + p.GhiChu
                + "', TrangThai = '" + p.TrangThai + "'WHERE IDPhong = N'" + p.IDPhong + "'");
        }

        public Boolean XoaPhong(string idPhong)
        {
            return new ExecuteDB().ExecuteData("DELETE FROM Phong WHERE IDPhong = N'" + idPhong + "'");
        }
    }
}
