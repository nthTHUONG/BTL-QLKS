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
        SqlConnection conn = ConnectDB.ConnectionDB();

        public DataTable GetDataNV()
        {
            ConnectDB.Open(conn);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", conn);
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

        private Boolean ExecuteDataNV(string sql)
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

        public Boolean ThemNV(NhanVien_DTO nv)
        {
            ConnectDB.Open(conn);
            try
            {
                string sql = "INSERT INTO NhanVien(IDNhanVien, Ho, Ten, ChucVu, GioiTinh, NgaySinh, SDT, DiaChi) VALUES(@idNhanVien, @ho, @ten, @chucvu, @gioitinh, @ngaysinh, @sdt, @diachi)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (nv.IDNhanVien == "")
                {
                    throw new Exception("Field \"IDNhanVien\" không thể để trống!");
                }
                cmd.Parameters.AddWithValue("@idNhanVien", nv.IDNhanVien);
                cmd.Parameters.AddWithValue("@ho", nv.Ho);
                cmd.Parameters.AddWithValue("@ten", nv.Ten);
                cmd.Parameters.AddWithValue("@chucvu", nv.ChucVu);
                cmd.Parameters.AddWithValue("@gioitinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@ngaysinh", nv.NgaySinh);
                cmd.Parameters.AddWithValue("@sdt", nv.SDT);
                cmd.Parameters.AddWithValue("@diachi", nv.DiaChi);
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

        public Boolean SuaNV(NhanVien_DTO nv)
        {
            ConnectDB.Open(conn);
            try
            {
                return ExecuteDataNV("UPDATE NhanVien SET Ho = N'" + nv.Ho + "', Ten = N'" + nv.Ten
                    + "', ChucVu = N'" + nv.ChucVu + "', GioiTinh = N'" + nv.GioiTinh + "', NgaySinh = '" + nv.NgaySinh
                    + "', SDT = N'" + nv.SDT + "', DiaChi = N'" + nv.DiaChi + "'WHERE IDNhanVien = N'" + nv.IDNhanVien + "'");
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

        public Boolean XoaNV(string idNhanVien)
        {
            ConnectDB.Open(conn);
            try
            {
                return ExecuteDataNV("DELETE FROM NhanVien WHERE IDNhanVien = N'" + idNhanVien + "'");
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
