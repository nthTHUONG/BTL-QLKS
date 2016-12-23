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
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
<<<<<<< HEAD
                string sql = "SELECT * FROM Phong";
=======
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
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
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
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
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
        }

        public Boolean XoaPhong(string idPhong)
        {
<<<<<<< HEAD
            string sql = "DELETE FROM Phong WHERE IDPhong = N'" + idPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("DELETE FROM Phong WHERE IDPhong = N'" + idPhong + "'");
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
        }
    }
}
