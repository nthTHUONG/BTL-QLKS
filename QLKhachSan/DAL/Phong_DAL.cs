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
<<<<<<< HEAD
        public DataTable GetDataPhong()
=======
        public DataTable GetDataPhong(string sql)
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
<<<<<<< HEAD
                string sql = "SELECT * FROM Phong";
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
                conn.Dispose();
            }
        }

        public Boolean ThemPhong(Phong_DTO p)
        {
<<<<<<< HEAD
            string sql = "INSERT INTO Phong(IDPhong, MaLP, GhiChu, TrangThai) VALUES(N'" + p.IDPhong + "', N'" + p.MaLP
                + "', N'" + p.GhiChu + "', '" + p.TrangThai + "')";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("INSERT INTO Phong(IDPhong, MaLP, GhiChu, TrangThai) VALUES(N'" + p.IDPhong + "', N'" + p.MaLP
                + "', N'" + p.GhiChu + "', '" + p.TrangThai + "')");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        public Boolean SuaPhong(Phong_DTO p)
        {
<<<<<<< HEAD
            string sql = "UPDATE Phong SET MaLP = N'" + p.MaLP + "', GhiChu = N'" + p.GhiChu
                + "', TrangThai = '" + p.TrangThai + "'WHERE IDPhong = N'" + p.IDPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("UPDATE Phong SET MaLP = N'" + p.MaLP + "', GhiChu = N'" + p.GhiChu
                + "', TrangThai = '" + p.TrangThai + "'WHERE IDPhong = N'" + p.IDPhong + "'");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        public Boolean XoaPhong(string idPhong)
        {
<<<<<<< HEAD
            string sql = "DELETE FROM Phong WHERE IDPhong = N'" + idPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("DELETE FROM Phong WHERE IDPhong = N'" + idPhong + "'");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }
    }
}
