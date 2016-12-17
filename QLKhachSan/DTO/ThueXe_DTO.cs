using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThueXe_DTO
    {
        private string _idThueXe;

        public string IDThueXe
        {
            get { return _idThueXe; }
            set { _idThueXe = value; }
        }
        private string _idKhachHang;

        public string IDKhachHang
        {
            get { return _idKhachHang; }
            set { _idKhachHang = value; }
        }
        private string _idXe;

        public string IDXe
        {
            get { return _idXe; }
            set { _idXe = value; }
        }
        private DateTime _ngayThueXe;

        public DateTime NgayThueXe
        {
            get { return _ngayThueXe; }
            set { _ngayThueXe = value; }
        }
        private DateTime _ngayTraXe;

        public DateTime NgayTraXe
        {
            get { return _ngayTraXe; }
            set { _ngayTraXe = value; }
        }
        private decimal _giaThue;

        public decimal GiaThue
        {
            get { return _giaThue; }
            set { _giaThue = value; }
        }
        private decimal _tienCoc;

        public decimal TienCoc
        {
            get { return _tienCoc; }
            set { _tienCoc = value; }
        }
        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
        public ThueXe_DTO() { }
        public ThueXe_DTO(string idThueXe, string idkhachhang, string idXe, string ngaythue, string ngaytra, string giathue, string tiencoc, string ghichu)
        {
            _idThueXe = idThueXe;
            _idKhachHang = idkhachhang;
            _idXe = idXe;
            _ngayThueXe = Convert.ToDateTime(ngaythue);
            _ngayTraXe = Convert.ToDateTime(ngaytra);
            _giaThue = Convert.ToDecimal(giathue);
            _tienCoc = Convert.ToDecimal(tiencoc);
            _ghiChu = ghichu;
        }

    }
}
