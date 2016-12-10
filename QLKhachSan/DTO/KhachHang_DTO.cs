using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string _idKhachHang;

        public string IDKhachHang
        {
            get { return _idKhachHang; }
            set { _idKhachHang = value; }
        }
        private string _ho;

        public string Ho
        {
            get { return _ho; }
            set { _ho = value; }
        }
        private string _ten;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        private string _gioiTinh;

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }
        private string _sDT;

        public string SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private string _quocTich;

        public string QuocTich
        {
            get { return _quocTich; }
            set { _quocTich = value; }
        }
    }
}
