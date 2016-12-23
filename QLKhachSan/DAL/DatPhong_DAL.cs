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
<<<<<<< HEAD
=======
            string sql = "SELECT * FROM DatPhong";
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
<<<<<<< HEAD
                string sql = "SELECT * FROM DatPhong";
=======
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
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

<<<<<<< HEAD
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

        public DataTable GetDataDP_fromMaKH(string maKH)
        {
=======
        public DataTable GetDataDP(string MaKH)
        {
            string sql = "SELECT * FROM DatPhong WHERE MaKH = N'" + MaKH + "'";
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
<<<<<<< HEAD
                string sql = "SELECT * FROM DatPhong WHERE MaKH = N'" + maKH + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
=======
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable dtt = new DataTable();
                da.Fill(dtt);
                return dtt;
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
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
<<<<<<< HEAD
            ExecuteDB e = new ExecuteDB();
            string sql = "SELECT COUNT(*) FROM DatPhong WHERE MaPhong = N'" + dp.MaPhong
                + "' AND(NgayNhan <= '" + dp.NgayTra.ToString("yyyy-MM-dd") + "' OR NgayTra >= '" + dp.NgayNhan.ToString("yyyy-MM-dd") + "')";
            int status = (int)e.ExecuteScalar(sql);
            if (status != 0)
            {
                return false;
            }
            sql = "INSERT INTO DatPhong VALUES(N'" + dp.IDDatPhong + "', N'" + dp.MaKH + " ', N'" + dp.MaNV + "', N'" + dp.MaPhong
                + "', '" + dp.NgayDat.ToString("yyyy-MM-dd") + "', '" + dp.NgayNhan.ToString("yyyy-MM-dd") + "', '" + dp.NgayTra.ToString("yyyy-MM-dd")
                + "', '" + dp.ThanhTien + "', '" + dp.TraTruoc + "', N'" + dp.GhiChu + "')";
            return e.ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("INSERT INTO DatPhong VALUES(N'" + dp.IDDatPhong
                + "', N'"+ dp.MaKH + "', N'" + dp.MaNV + "', N'" + dp.MaPhong + "', '" + dp.NgayDat + "', '" + dp.NgayNhan + "', N'" + dp.NgayTra + "', N'" + dp.ThanhTien + "', N'" + dp.TraTruoc + "', N'" + dp.GhiChu + "')");
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
        }

        public Boolean SuaDP(DatPhong_DTO dp)
        {
<<<<<<< HEAD
            string sql = "UPDATE DatPhong SET MaKH = N'" + dp.MaKH + "', MaNV = N'" + dp.MaNV
                + "', MaPhong = N'" + dp.MaPhong + "', NgayDat = '" + dp.NgayDat.ToString("yyyy-MM-dd")
                + "', NgayNhan = '" + dp.NgayNhan.ToString("yyyy-MM-dd") + "', NgayTra = N'" + dp.NgayTra.ToString("yyyy-MM-dd")
                + "', ThanhTien = N'" + dp.ThanhTien + "', TraTruoc = N'" + dp.TraTruoc + "', GhiChu = N'" + dp.GhiChu
                + "'WHERE IDDatPhong = N'" + dp.IDDatPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("UPDATE DatPhong SET MaKH = N'" + dp.MaKH + "', MaNV = N'" + dp.MaNV
                + "', MaPhong = N'" + dp.MaPhong + "', NgayDat = '" + dp.NgayDat + "', NgayNhan = '" + dp.NgayNhan
                + "', NgayTra = N'" + dp.NgayTra + "', ThanhTien = N'" + dp.ThanhTien + "', TraTruoc = N'" + dp.TraTruoc
                + "', GhiChu = N'" + dp.GhiChu + "'WHERE IDDatPhong = N'" + dp.IDDatPhong + "'");
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
        }

        public Boolean XoaDP(string idDatPhong)
        {
<<<<<<< HEAD
            string sql = "DELETE FROM DatPhong WHERE IDDatPhong = N'" + idDatPhong + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("DELETE FROM DatPhong WHERE IDDatPhong = N'" + idDatPhong + "'");
>>>>>>> d838e9a4307b60a38cfd1ca69dc8f3739a47a05a
        }
    }
}
