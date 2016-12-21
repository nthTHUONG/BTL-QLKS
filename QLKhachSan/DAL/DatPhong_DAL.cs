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
            string sql = "SELECT * FROM DatPhong";
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

        public DataTable GetDataDP(string MaKH)
        {
            string sql = "SELECT * FROM DatPhong WHERE MaKH = N'" + MaKH + "'";
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable dtt = new DataTable();
                da.Fill(dtt);
                return dtt;
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
            return new ExecuteDB().ExecuteData("INSERT INTO DatPhong VALUES(N'" + dp.IDDatPhong
                + "', N'"+ dp.MaKH + "', N'" + dp.MaNV + "', N'" + dp.MaPhong + "', '" + dp.NgayDat + "', '" + dp.NgayNhan + "', N'" + dp.NgayTra + "', N'" + dp.ThanhTien + "', N'" + dp.TraTruoc + "', N'" + dp.GhiChu + "')");
        }

        public Boolean SuaDP(DatPhong_DTO dp)
        {
            return new ExecuteDB().ExecuteData("UPDATE DatPhong SET MaKH = N'" + dp.MaKH + "', MaNV = N'" + dp.MaNV
                + "', MaPhong = N'" + dp.MaPhong + "', NgayDat = '" + dp.NgayDat + "', NgayNhan = '" + dp.NgayNhan
                + "', NgayTra = N'" + dp.NgayTra + "', ThanhTien = N'" + dp.ThanhTien + "', TraTruoc = N'" + dp.TraTruoc
                + "', GhiChu = N'" + dp.GhiChu + "'WHERE IDDatPhong = N'" + dp.IDDatPhong + "'");
        }

        public Boolean XoaDP(string idDatPhong)
        {
            return new ExecuteDB().ExecuteData("DELETE FROM DatPhong WHERE IDDatPhong = N'" + idDatPhong + "'");
        }
    }
}
