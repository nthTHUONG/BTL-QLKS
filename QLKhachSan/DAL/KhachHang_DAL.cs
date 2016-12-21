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
        public DataTable GetDataKH()
        {
            string sql = "SELECT * FROM KhachHang";
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

        public DataTable GetDataKH(string idKhachHang)
        {
            string sql = "SELECT * FROM KhachHang WHERE IDKhachHang = N'" + idKhachHang + "'";
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

        public Boolean ThemKH(KhachHang_DTO kh)
        {
            return new ExecuteDB().ExecuteData("INSERT INTO KhachHang(IDKhachHang, Ho, Ten, GioiTinh, SDT, Email, DiaChi, QuocTich) VALUES(N'" + kh.IDKhachHang
                + "', N'" + kh.Ho + "', N'" + kh.Ten + "', N'" + kh.GioiTinh + "', '" + kh.SDT + "', '" + kh.Email + "', N'" + kh.DiaChi + "', N'" + kh.QuocTich + "')");
        }

        public Boolean SuaKH(KhachHang_DTO kh)
        {
            return new ExecuteDB().ExecuteData("UPDATE KhachHang SET Ho = N'" + kh.Ho + "', Ten = N'" + kh.Ten
                + "', GioiTinh = N'" + kh.GioiTinh + "', SDT = '" + kh.SDT + "', Email = '" + kh.Email
                + "', DiaChi = N'" + kh.DiaChi + "', QuocTich = N'" + kh.QuocTich + "'WHERE IDKhachHang = N'" + kh.IDKhachHang + "'");
        }

        public Boolean XoaKH(string idKhachHang)
        {
            return new ExecuteDB().ExecuteData("DELETE FROM KhachHang WHERE IDKhachHang = N'" + idKhachHang + "'");
        }
    }
}
