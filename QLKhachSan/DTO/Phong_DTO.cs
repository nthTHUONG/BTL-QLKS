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

        private string _maLP;

        public string MaLP
        {
            get { return _maLP; }
            set { _maLP = value; }
        }

        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        private bool _trangThai;

        public bool TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }

        public Phong_DTO() { }

        public Phong_DTO(string idPhong, string maLP, string ghiChu, string trangThai)
        {
            _idPhong = idPhong;
            _maLP = maLP;
            _ghiChu = ghiChu;
            _trangThai = Convert.ToBoolean(trangThai);
        }
    }
}
