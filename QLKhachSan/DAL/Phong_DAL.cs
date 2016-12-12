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
    public class Phong_DAL
    {
        SqlConnection conn = ConnectDB.ConnectionDB();
        public DataTable GetDataPhong()
        {
            ConnectDB.Open(conn);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Phong", conn);
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
        private Boolean ExecuteDataPhong(string sql)
        {
            ConnectDB.Open(conn);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                ConnectDB.Close(conn);
            }
        }
        public Boolean ThemPhong(Phong_DTO P)
        {
            ConnectDB.Open(conn);
            try
            {
                string sql = "INSERT INTO Phong(IDPhong, MaLP, GhiChu, TrangThai) VALUES(@idPhong, @maLP, @ghiChu, @trangThai)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (P.IDPhong == "")
                {
                    throw new Exception("Field \"IDPhong\" không thể để trống!");
                }
                cmd.Parameters.AddWithValue("@idPhong", P.IDPhong);
                cmd.Parameters.AddWithValue("@maLP", P.MaLP);
                cmd.Parameters.AddWithValue("@ghiChu", P.GhiChu);
                cmd.Parameters.AddWithValue("@trangThai", P.TrangThai);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                ConnectDB.Close(conn);
            }
        }
        public Boolean SuaPhong(Phong_DTO P)
        {
            ConnectDB.Open(conn);
            try
            {
                return ExecuteDataPhong("UPDATE Phong SET MaLP = N'" + P.MaLP
                    + "', GhiChu = N'" + P.GhiChu + "', TrangThai = N'" + P.TrangThai + "'WHERE IDPhong = N'" + P.IDPhong + "'");
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                ConnectDB.Close(conn);
            }
        }
        public Boolean XoaPhong(string idPhong)
        {
            ConnectDB.Open(conn);
            try
            {
                return ExecuteDataPhong("DELETE FROM Phong WHERE IDPhong = N'" + idPhong + "'");
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                ConnectDB.Close(conn);
            }
        }
    }
}
