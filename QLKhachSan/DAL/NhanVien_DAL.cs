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
<<<<<<< HEAD
=======
            string sql = "SELECT * FROM NhanVien";
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
<<<<<<< HEAD
                string sql = "SELECT * FROM NhanVien";
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
        
        public Boolean ThemNV(NhanVien_DTO nv)
        {
<<<<<<< HEAD
            string sql = "INSERT INTO NhanVien VALUES(N'" + nv.IDNhanVien + "', N'" + nv.Ho + "', N'" + nv.Ten
                + "', N'" + nv.ChucVu + "', N'" + nv.GioiTinh + "', '" + nv.NgaySinh.ToString("yyyy-MM-dd")
                + "', '" + nv.SDT + "', N'" + nv.DiaChi + "')";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("INSERT INTO NhanVien(IDNhanVien, Ho, Ten, ChucVu, GioiTinh, NgaySinh, SDT, DiaChi) VALUES(N'" + nv.IDNhanVien
                + "', N'" + nv.Ho + "', N'" + nv.Ten + "', N'" + nv.ChucVu + "', N'" + nv.GioiTinh + "', '" + nv.NgaySinh.ToString("yyyy-MM-dd") + "', '" + nv.SDT + "', N'" + nv.DiaChi + "')");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        public Boolean SuaNV(NhanVien_DTO nv)
        {
<<<<<<< HEAD
            string sql = "UPDATE NhanVien SET Ho = N'" + nv.Ho + "', Ten = N'" + nv.Ten
                + "', ChucVu = N'" + nv.ChucVu + "', GioiTinh = N'" + nv.GioiTinh + "', NgaySinh = '" + nv.NgaySinh.ToString("yyyy-MM-dd")
                + "', SDT = '" + nv.SDT + "', DiaChi = N'" + nv.DiaChi + "'WHERE IDNhanVien = N'" + nv.IDNhanVien + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("UPDATE NhanVien SET Ho = N'" + nv.Ho + "', Ten = N'" + nv.Ten
                + "', ChucVu = N'" + nv.ChucVu + "', GioiTinh = N'" + nv.GioiTinh + "', NgaySinh = '" + nv.NgaySinh.ToString("yyyy-MM-dd")
                + "', SDT = '" + nv.SDT + "', DiaChi = N'" + nv.DiaChi + "'WHERE IDNhanVien = N'" + nv.IDNhanVien + "'");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        public Boolean XoaNV(string idNhanVien)
        {
<<<<<<< HEAD
            string sql = "DELETE FROM NhanVien WHERE IDNhanVien = N'" + idNhanVien + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("DELETE FROM NhanVien WHERE IDNhanVien = N'" + idNhanVien + "'");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }
    }
}
