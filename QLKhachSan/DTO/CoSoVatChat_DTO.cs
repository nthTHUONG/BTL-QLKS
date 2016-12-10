using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CoSoVatChat_DTO
    {
        private string _idCSVC;

        public string IDCSVC
        {
            get { return _idCSVC; }
            set { _idCSVC = value; }
        }
        private string _ten;

        public string TenCSVC
        {
            get { return _ten; }
            set { _ten = value; }
        }
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        private string _idLoaiPhong;

        public string MaLP
        {
            get { return _idLoaiPhong; }
            set { _idLoaiPhong = value; }
        }
        private bool _tinhTrang;

        public bool TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
    }
}
