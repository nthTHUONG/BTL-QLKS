using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HDV_DTO
    {
        private string _idDvHDV;

        public string IDDvHDV
        {
            get { return _idDvHDV; }
            set { _idDvHDV = value; }
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
        private string _giaThue;

        public string GiaThue
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
        public HDV_DTO() { }
        public HDV_DTO(string idDvHDV, string maKH, string maHDV, string ngayThue, string giaThue, string ghiChu)
        {
            _idDvHDV = idDvHDV;
            _maKH = maKH;
            _maHDV = maHDV;
            _ngayThue = Convert.ToDateTime(ngayThue);
            _giaThue = giaThue;
            _ghiChu = ghiChu;
        }
    }
}
