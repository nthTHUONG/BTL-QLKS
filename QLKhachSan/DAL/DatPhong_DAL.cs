using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DatPhong_DAL
    {
        public DataTable GetDataDP()
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM DatPhong";
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

        public DataTable GetDataDP(string idDatPhong)
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM DatPhong WHERE IDDatPhong = N'" + idDatPhong + "'";
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

        public Boolean GetDataDP_khongLP(string maPhong, DateTime start, DateTime finish)
        {
            ExecuteDB e = new ExecuteDB();
            string sql = "SELECT COUNT(*) FROM DatPhong WHERE MaPhong = N'" + maPhong
                    + "' AND(NgayNhan >= '" + finish.ToString("yyyy-MM-dd") + "' OR NgayTra <= '" + start.ToString("yyyy-MM-dd") + "')";
            int status = (int)e.ExecuteScalar(sql);
            if (status != 0)
            {
                return false;
            }
            return true;
        }

        public Boolean GetDataDP_coLP(string maPhong, DateTime start, DateTime finish, string tenLP)
        {
            ExecuteDB e = new ExecuteDB();
            string sql = "SELECT COUNT(*) FROM DatPhong WHERE MaPhong = N'" + maPhong
                    + "' AND(NgayNhan >= '" + finish.ToString("yyyy-MM-dd") + "' OR NgayTra <= '" + start.ToString("yyyy-MM-dd")
                    + "') AND MaPhong IN (SELECT MaPhong FROM Phong WHERE MaLP IN (SELECT IDLoaiPhong FROM LoaiPhong WHERE TenLP = N'" + tenLP + "'))";
            int status = (int)e.ExecuteScalar(sql);
            if (status != 0)
            {
                return false;
            }
            return true;
        }

        public DataTable GetDataDP_fromMaKH(string maKH)
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                string sql = "SELECT * FROM DatPhong WHERE MaKH = N'" + maKH + "' AND TinhTrang = 0";
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

        public Boolean ThemDP(DatPhong_DTO dp)
        {
            ExecuteDB e = new ExecuteDB();
            string sql = "SELECT COUNT(*) FROM DatPhong WHERE MaPhong = N'" + dp.MaPhong
                + "' AND(NgayNhan >= '" + dp.NgayTra.ToString("yyyy-MM-dd") + "' OR NgayTra <= '" + dp.NgayNhan.ToString("yyyy-MM-dd") + "')";
            int status = (int)e.ExecuteScalar(sql);
            if (status != 0)
            {
                return false;
            }
            sql = "INSERT INTO DatPhong VALUES(N'" + dp.IDDatPhong + "', N'" + dp.MaKH + " ', N'" + dp.MaNV + "', N'" + dp.MaPhong
                + "', '" + dp.NgayDat.ToString("yyyy-MM-dd") + "', '" + dp.NgayNhan.ToString("yyyy-MM-dd") + "', '" + dp.NgayTra.ToString("yyyy-MM-dd")
                + "', '" + dp.ThanhTien + "', '" + dp.TraTruoc + "', N'" + dp.GhiChu + "', 1)";
            return e.ExecuteData(sql);
        }

        public Boolean SuaDP(DatPhong_DTO dp)
        {
            string sql = "UPDATE DatPhong SET MaKH = N'" + dp.MaKH + "', MaNV = N'" + dp.MaNV
                + "', MaPhong = N'" + dp.MaPhong + "', NgayDat = '" + dp.NgayDat.ToString("yyyy-MM-dd")
                + "', NgayNhan = '" + dp.NgayNhan.ToString("yyyy-MM-dd") + "', NgayTra = N'" + dp.NgayTra.ToString("yyyy-MM-dd")
                + "', ThanhTien = N'" + dp.ThanhTien + "', TraTruoc = N'" + dp.TraTruoc + "', GhiChu = N'" + dp.GhiChu + ", TinhTrang = " + dp.TinhTrang.GetHashCode()
                + "'WHERE IDDatPhong = N'" + dp.IDDatPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
        }

        public Boolean ThanhToan(string maKH, string maPhong, string ngayNhan)
        {
            string sql = "UPDATE DatPhong SET TinhTrang = 1 WHERE MaKH = N'" + maKH + "' AND MaPhong = '" + maPhong + "' AND NgayNhan = '" + ngayNhan +"'";
            ExecuteDB exc = new ExecuteDB();
            exc.ExecuteData(sql);
            sql = "UPDATE Phong SET TrangThai = 0 WHERE IDPhong = '"+ maPhong +"'";
            exc.ExecuteData(sql);

            return true;
        }
        public Boolean XoaDatPhong(string maKH, string maPhong, string ngayNhan)
        {
            string sql = "DELETE DatPhong WHERE MaKH = N'" + maKH + "' AND MaPhong = '" + maPhong + "' AND NgayNhan = '" + ngayNhan + "'";
            return new ExecuteDB().ExecuteData(sql);
        }
        public Boolean XoaDatPhong(string IdDatPhong)
        {
            string sql = "DELETE DatPhong WHERE IDDatPhong = '"+ IdDatPhong +"'";
            return new ExecuteDB().ExecuteData(sql);
        }
    }
}
