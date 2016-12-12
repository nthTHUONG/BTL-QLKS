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
    public class KhachHang_DAL
    {
        SqlConnection conn = ConnectDB.ConnectionDB();

        public DataTable GetDataKH()
        {
            ConnectDB.Open(conn);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang", conn);
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

        private Boolean ExecuteDataKH(string sql)
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

        public Boolean ThemKH(KhachHang_DTO kh)
        {
            ConnectDB.Open(conn);
            try
            {
                string sql = "INSERT INTO KhachHang(IDKhachHang, Ho, Ten, GioiTinh, SDT, Email, DiaChi, QuocTich) VALUES(@idKhachHang, @ho, @ten, @gioitinh, @sdt, @email, @diachi, @quoctich)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (kh.IDKhachHang == "")
                {
                    throw new Exception("Field \"IDKhachHang\" không thể để trống!");
                }
                cmd.Parameters.AddWithValue("@idKhachHang", kh.IDKhachHang);
                cmd.Parameters.AddWithValue("@ho", kh.Ho);
                cmd.Parameters.AddWithValue("@ten", kh.Ten);
                cmd.Parameters.AddWithValue("@gioitinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@sdt", kh.SDT);
                cmd.Parameters.AddWithValue("@email", kh.Email);
                cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@quoctich", kh.QuocTich);
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

        public Boolean SuaKH(KhachHang_DTO kh)
        {
            ConnectDB.Open(conn);
            try
            {
                return ExecuteDataKH("UPDATE KhachHang SET Ho = N'" + kh.Ho + "', Ten = N'" + kh.Ten
                    + "', GioiTinh = N'" + kh.GioiTinh + "', SDT = '" + kh.SDT + "', Email = N'" + kh.Email
                    + "', DiaChi = N'" + kh.DiaChi + "', QuocTich = N'" + kh.QuocTich + "'WHERE IDKhachHang = N'" + kh.IDKhachHang + "'");
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

        public Boolean XoaKH(string idKhachHang)
        {
            ConnectDB.Open(conn);
            try
            {
                return ExecuteDataKH("DELETE FROM KhachHang WHERE IDKhachHang = N'" + idKhachHang + "'");
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
