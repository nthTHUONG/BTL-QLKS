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
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM KhachHang";
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
            string sql = "INSERT INTO KhachHang VALUES(N'" + kh.IDKhachHang + "', N'" + kh.Ho + "', N'" + kh.Ten
                + "', N'" + kh.GioiTinh + "', '" + kh.SDT + "', '" + kh.Email + "', N'" + kh.DiaChi + "', N'" + kh.QuocTich + "')";
            return new ExecuteDB().ExecuteData(sql);
        }

        public Boolean SuaKH(KhachHang_DTO kh)
        {
            string sql = "UPDATE KhachHang SET Ho = N'" + kh.Ho + "', Ten = N'" + kh.Ten
                + "', GioiTinh = N'" + kh.GioiTinh + "', SDT = '" + kh.SDT + "', Email = '" + kh.Email
                + "', DiaChi = N'" + kh.DiaChi + "', QuocTich = N'" + kh.QuocTich
                + "'WHERE IDKhachHang = N'" + kh.IDKhachHang + "'";
            return new ExecuteDB().ExecuteData(sql);
        }

        public Boolean XoaKH(string idKhachHang)
        {
            string sql = "DELETE FROM KhachHang WHERE IDKhachHang = N'" + idKhachHang + "'";
            return new ExecuteDB().ExecuteData(sql);
        }
    }
}
