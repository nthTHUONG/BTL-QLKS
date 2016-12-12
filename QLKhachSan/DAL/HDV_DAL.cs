using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class HDV_DAL
    {
        SqlConnection conn = ConnectDB.ConnectionDB();
        public DataTable GetDataDVhdv()
        {
            ConnectDB.Open(conn);
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM DichVuHDV", conn);
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
        private Boolean ExecuteDataDVhdv(string sql)
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
        public Boolean ThemDVhdv(HDV_DTO hdv)
        {
            ConnectDB.Open(conn);
            try
            {
                string sql = "INSERT INTO DichVuHDV(IDDvHDV, MaKH, MaHDV, NgayThue, GiaThue, GhiChu) VALUES(@id, @maKH, @maHDV, @ngayThue, @giaThue, @ghiChu)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (hdv.IDDvHDV == "")
                {
                    throw new Exception("Field \"IDDvHDV\" không thể để trống!");
                }
                cmd.Parameters.AddWithValue("@id", hdv.IDDvHDV);
                cmd.Parameters.AddWithValue("@maKH", hdv.MaKH);
                cmd.Parameters.AddWithValue("@maHDV", hdv.MaHDV);
                cmd.Parameters.AddWithValue("@ngayThue", hdv.NgayThue);
                cmd.Parameters.AddWithValue("@giaThue", hdv.GiaThue);
                cmd.Parameters.AddWithValue("@ghiChu", hdv.GhiChu);
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
        public Boolean SuaDVhdv(HDV_DTO hdv)
        {
            ConnectDB.Open(conn);
            try
            {
                return ExecuteDataDVhdv("UPDATE DichVuHDV SET MaKH = N'" + hdv.MaKH
                    + "', MaHDV = N'" + hdv.MaHDV + "', NgayThue = N'" + hdv.NgayThue + "', GiaThue = '" + hdv.GiaThue
                    + "', GhiChu = N'" + hdv.GhiChu + "'WHERE IDDvHDV = N'" + hdv.IDDvHDV + "'");
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
        public Boolean XoaDVhdv(string id)
        {
            ConnectDB.Open(conn);
            try
            {
                return ExecuteDataDVhdv("DELETE FROM DichVuHDV WHERE IDDvHDV = N'" + id + "'");
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
