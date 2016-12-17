using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DVhdv_DTO
    {
        private string _idDVhdv;

        public string IDDVhdv
        {
            get { return _idDVhdv; }
            set { _idDVhdv = value; }
        }

        private string _maKH;

        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        private string _maHDV;

        public string MaHDV
        {
            get { return _maHDV; }
            set { _maHDV = value; }
        }

        private DateTime _ngayThue;

        public DateTime NgayThue
        {
            get { return _ngayThue; }
            set { _ngayThue = value; }
        }

        private int _soNgayThue;

        public int SoNgayThue
        {
            get { return _soNgayThue; }
            set { _soNgayThue = value; }
        }


        private decimal _giaThue;

        public decimal GiaThue
        {
            get { return _giaThue; }
            set { _giaThue = value; }
        }

        private decimal _traTruoc;

        public decimal TraTruoc
        {
            get { return _traTruoc; }
            set { _traTruoc = value; }
        }

        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public DVhdv_DTO() { }

        public DVhdv_DTO(string idDVhdv, string maKH, string maHDV, string ngayThue, string soNgayThue, string giaThue, string traTruoc, string ghiChu)
        {
            _idDVhdv = idDVhdv;
            _maKH = maKH;
            _maHDV = maHDV;
            _ngayThue = Convert.ToDateTime(ngayThue);
            _soNgayThue = Convert.ToInt32(soNgayThue);
            _giaThue = Convert.ToDecimal(giaThue);
            _traTruoc = Convert.ToDecimal(traTruoc);
            _ghiChu = ghiChu;
        }
    }
}
