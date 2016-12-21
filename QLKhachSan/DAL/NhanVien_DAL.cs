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
    public class NhanVien_DAL
    {
        public DataTable GetDataNV()
        {
            string sql = "SELECT * FROM NhanVien";
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
        
        public Boolean ThemNV(NhanVien_DTO nv)
        {
            return new ExecuteDB().ExecuteData("INSERT INTO NhanVien(IDNhanVien, Ho, Ten, ChucVu, GioiTinh, NgaySinh, SDT, DiaChi) VALUES(N'" + nv.IDNhanVien
                + "', N'" + nv.Ho + "', N'" + nv.Ten + "', N'" + nv.ChucVu + "', N'" + nv.GioiTinh + "', '" + nv.NgaySinh.ToString("yyyy-MM-dd") + "', '" + nv.SDT + "', N'" + nv.DiaChi + "')");
        }

        public Boolean SuaNV(NhanVien_DTO nv)
        {
            return new ExecuteDB().ExecuteData("UPDATE NhanVien SET Ho = N'" + nv.Ho + "', Ten = N'" + nv.Ten
                + "', ChucVu = N'" + nv.ChucVu + "', GioiTinh = N'" + nv.GioiTinh + "', NgaySinh = '" + nv.NgaySinh.ToString("yyyy-MM-dd")
                + "', SDT = '" + nv.SDT + "', DiaChi = N'" + nv.DiaChi + "'WHERE IDNhanVien = N'" + nv.IDNhanVien + "'");
        }

        public Boolean XoaNV(string idNhanVien)
        {
            return new ExecuteDB().ExecuteData("DELETE FROM NhanVien WHERE IDNhanVien = N'" + idNhanVien + "'");
        }
    }
}
