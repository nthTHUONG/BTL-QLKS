﻿using DTO;
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
<<<<<<< HEAD
=======
            string sql = "SELECT * FROM KhachHang";
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
<<<<<<< HEAD
                string sql = "SELECT * FROM KhachHang";
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
<<<<<<< HEAD
=======
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
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            }
        }

        public Boolean ThemKH(KhachHang_DTO kh)
        {
<<<<<<< HEAD
            string sql = "INSERT INTO KhachHang VALUES(N'" + kh.IDKhachHang + "', N'" + kh.Ho + "', N'" + kh.Ten
                + "', N'" + kh.GioiTinh + "', '" + kh.SDT + "', '" + kh.Email + "', N'" + kh.DiaChi + "', N'" + kh.QuocTich + "')";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("INSERT INTO KhachHang(IDKhachHang, Ho, Ten, GioiTinh, SDT, Email, DiaChi, QuocTich) VALUES(N'" + kh.IDKhachHang
                + "', N'" + kh.Ho + "', N'" + kh.Ten + "', N'" + kh.GioiTinh + "', '" + kh.SDT + "', '" + kh.Email + "', N'" + kh.DiaChi + "', N'" + kh.QuocTich + "')");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        public Boolean SuaKH(KhachHang_DTO kh)
        {
<<<<<<< HEAD
            string sql = "UPDATE KhachHang SET Ho = N'" + kh.Ho + "', Ten = N'" + kh.Ten
                + "', GioiTinh = N'" + kh.GioiTinh + "', SDT = '" + kh.SDT + "', Email = '" + kh.Email
                + "', DiaChi = N'" + kh.DiaChi + "', QuocTich = N'" + kh.QuocTich
                + "'WHERE IDKhachHang = N'" + kh.IDKhachHang + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("UPDATE KhachHang SET Ho = N'" + kh.Ho + "', Ten = N'" + kh.Ten
                + "', GioiTinh = N'" + kh.GioiTinh + "', SDT = '" + kh.SDT + "', Email = '" + kh.Email
                + "', DiaChi = N'" + kh.DiaChi + "', QuocTich = N'" + kh.QuocTich + "'WHERE IDKhachHang = N'" + kh.IDKhachHang + "'");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }

        public Boolean XoaKH(string idKhachHang)
        {
<<<<<<< HEAD
            string sql = "DELETE FROM KhachHang WHERE IDKhachHang = N'" + idKhachHang + "'";
            return new ExecuteDB().ExecuteData(sql);
=======
            return new ExecuteDB().ExecuteData("DELETE FROM KhachHang WHERE IDKhachHang = N'" + idKhachHang + "'");
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
        }
    }
}
