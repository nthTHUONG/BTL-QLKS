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
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM NhanVien";
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

        public string getChucVuNhanVien(string maNV)
        {
            string cv = "";
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM NhanVien where IDNhanVien = '" + maNV + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                IDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cv = dr["ChucVu"].ToString();
                }
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
            return cv;
        }
        
        public Boolean ThemNV(NhanVien_DTO nv)
        {
            string sql = "INSERT INTO NhanVien VALUES(N'" + nv.IDNhanVien + "', N'" + nv.Ho + "', N'" + nv.Ten
                + "', N'" + nv.ChucVu + "', N'" + nv.GioiTinh + "', '" + nv.NgaySinh.ToString("yyyy-MM-dd")
                + "', '" + nv.SDT + "', N'" + nv.DiaChi + "')";
            return new ExecuteDB().ExecuteData(sql);
        }

        public Boolean SuaNV(NhanVien_DTO nv)
        {
            string sql = "UPDATE NhanVien SET Ho = N'" + nv.Ho + "', Ten = N'" + nv.Ten
                + "', ChucVu = N'" + nv.ChucVu + "', GioiTinh = N'" + nv.GioiTinh + "', NgaySinh = '" + nv.NgaySinh.ToString("yyyy-MM-dd")
                + "', SDT = '" + nv.SDT + "', DiaChi = N'" + nv.DiaChi + "'WHERE IDNhanVien = N'" + nv.IDNhanVien + "'";
            return new ExecuteDB().ExecuteData(sql);
        }

        public Boolean XoaNV(string idNhanVien)
        {
            string sql = "DELETE FROM NhanVien WHERE IDNhanVien = N'" + idNhanVien + "'";
            return new ExecuteDB().ExecuteData(sql);
        }
    }
}
