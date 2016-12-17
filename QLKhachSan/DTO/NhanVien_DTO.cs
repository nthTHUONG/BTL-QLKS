using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string _idNhanVien;

        public string IDNhanVien
        {
            get { return _idNhanVien; }
            set { _idNhanVien = value; }
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

        private string _chucVu;

        public string ChucVu
        {
            get { return _chucVu; }
            set { _chucVu = value; }
        }

        private string _gioiTinh;

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        private string _sdt;

        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public NhanVien_DTO() { }

        public NhanVien_DTO(string idNhanVien, string ho, string ten, string chucVu, string gioiTinh, string ngaySinh, string sdt, string diaChi)
        {
            _idNhanVien = idNhanVien;
            _ho = ho;
            _ten = ten;
            _chucVu = chucVu;
            _gioiTinh = gioiTinh;
            _ngaySinh = Convert.ToDateTime(ngaySinh);
            _sdt = sdt;
            _diaChi = diaChi;
        }
    }
}
