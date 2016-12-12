using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Business
    {
        #region Đăng nhập
        public Boolean CheckLogin(string user, string pass)
        {
            /*SqlConnection conn = ConnectDB.ConnectionDB();
            DataTable dt = connDB.getData("SELECT * FROM NhanVien WHERE IDNhanVien = N'"+ user + "'");
            if ((dt != null) && (dt.Rows.Count == 1))
            {
                return true;
            }*/
            return false;
        }
        #endregion

        #region Nhân viên
        public DataTable GetDataNV()
        {
            return new NhanVien_DAL().GetDataNV();
        }

        public Boolean ThemNV(NhanVien_DTO nv)
        {
            return new NhanVien_DAL().ThemNV(nv);
        }

        public Boolean SuaNV(NhanVien_DTO nv)
        {
            return new NhanVien_DAL().SuaNV(nv);
        }

        public Boolean XoaNV(string idNhanVien)
        {
            return new NhanVien_DAL().XoaNV(idNhanVien);
        }
        #endregion

        #region Khách hàng
        public DataTable GetDataKH()
        {
            return new KhachHang_DAL().GetDataKH();
        }

        public Boolean ThemKH(KhachHang_DTO kh)
        {
            return new KhachHang_DAL().ThemKH(kh);
        }

        public Boolean SuaKH(KhachHang_DTO kh)
        {
            return new KhachHang_DAL().SuaKH(kh);
        }

        public Boolean XoaKH(string idKhachHang)
        {
            return new KhachHang_DAL().XoaKH(idKhachHang);
        }
        #endregion

        #region DV HDV
        public DataTable GetDataDVhdv()
        {
            return new HDV_DAL().GetDataDVhdv();
        }

        public Boolean ThemDVhdv(HDV_DTO hdv)
        {
            return new HDV_DAL().ThemDVhdv(hdv);
        }

        public Boolean SuaDVhdv(HDV_DTO hdv)
        {
            return new HDV_DAL().SuaDVhdv(hdv);
        }

        public Boolean XoaDVhdv(string id)
        {
            return new HDV_DAL().XoaDVhdv(id);
        }
        #endregion

        #region CTTP
        public DataTable GetDataCTTP()
        {
            return new ChiTietTP_DAL().GetDataCTTP();
        }

        public Boolean ThemCTTP(ChiTietThucPham_DTO TP)
        {
            return new ChiTietTP_DAL().ThemCTTP(TP);
        }

        public Boolean SuaCTTP(ChiTietThucPham_DTO TP)
        {
            return new ChiTietTP_DAL().SuaCTTP(TP);
        }

        public Boolean XoaCTTP(string idTP)
        {
            return new ChiTietTP_DAL().XoaCTTP(idTP);
        }
        #endregion

        #region Phong
        public DataTable GetDataPhong()
        {
            return new Phong_DAL().GetDataPhong();
        }

        public Boolean ThemPhong(Phong_DTO P)
        {
            return new Phong_DAL().ThemPhong(P);
        }

        public Boolean SuaPhong(Phong_DTO P)
        {
            return new Phong_DAL().SuaPhong(P);
        }

        public Boolean XoaPhong(string idPhong)
        {
            return new Phong_DAL().XoaPhong(idPhong);
        }
        #endregion
    }
}
