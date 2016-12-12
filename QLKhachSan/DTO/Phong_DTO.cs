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
        private string p;
        private string p_2;
        private string p_3;
        private string p_4;

        public Phong_DTO(string p, string p_2, string p_3, string p_4)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.p_2 = p_2;
            this.p_3 = p_3;
            this.p_4 = p_4;
        }

        public int TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }
    }
}
