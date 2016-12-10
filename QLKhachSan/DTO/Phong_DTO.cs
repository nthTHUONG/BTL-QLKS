using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Phong_DTO
    {
        private string _idPhong;

        public string IDPhong
        {
            get { return _idPhong; }
            set { _idPhong = value; }
        }
        private string _idLoaiPhong;

        public string MaLP
        {
            get { return _idLoaiPhong; }
            set { _idLoaiPhong = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        private int _trangThai;

        public int TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }
    }
}
