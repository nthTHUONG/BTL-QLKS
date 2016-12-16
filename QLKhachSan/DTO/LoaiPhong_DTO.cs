using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiPhong_DTO
    {
        private string _idLoaiPhong;

        public string IDLoaiPhong
        {
            get { return _idLoaiPhong; }
            set { _idLoaiPhong = value; }
        }

        private string _tenLP;

        public string TenLP
        {
            get { return _tenLP; }
            set { _tenLP = value; }
        }

        private decimal _giaLP;

        public decimal GiaLP
        {
            get { return _giaLP; }
            set { _giaLP = value; }
        }

        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public LoaiPhong_DTO() { }

        public LoaiPhong_DTO(string idLoaiPhong, string tenLP, string giaLP, string soLuong, string ghiChu)
        {
            _idLoaiPhong = idLoaiPhong;
            _tenLP = tenLP;
            if (giaLP != "")
            {
                _giaLP = Convert.ToDecimal(giaLP);
            }
            if (soLuong != "")
            {
                _soLuong = Convert.ToInt32(soLuong);
            }
            _ghiChu = ghiChu;
        }
    }
}
