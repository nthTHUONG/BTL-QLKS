using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Xe_DTO
    {
        private string _idXe;

        public string IDXe
        {
            get { return _idXe; }
            set { _idXe = value; }
        }
        private string _hangSX;

        public string HangSX
        {
            get { return _hangSX; }
            set { _hangSX = value; }
        }
        private string _loaiXe;

        public string LoaiXe
        {
            get { return _loaiXe; }
            set { _loaiXe = value; }
        }
        private decimal _giaThue;

        public decimal GiaThue
        {
            get { return _giaThue; }
            set { _giaThue = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        private Boolean _tingTrang;

        public Boolean TinhTrang
        {
            get { return _tingTrang; }
            set { _tingTrang = value; }
        }

        public Xe_DTO() { }
        public Xe_DTO(string idxe, string hangsx, string loaixe, string giaThue, string ghichu, string tinhtrang)
        {
            _idXe = idxe;
            _hangSX = hangsx;
            _loaiXe = loaixe;
            _giaThue = Convert.ToDecimal(giaThue);
            _ghiChu = ghichu;
            _tingTrang = Convert.ToBoolean(tinhtrang);
        }
    }
}
