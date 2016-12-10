using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietXe_DTO
    {
        private string _idXe;

        public string IDXe
        {
            get { return _idXe; }
            set { _idXe = value; }
        }
        private string _hangSX;

        public string HangSanXuat
        {
            get { return _hangSX; }
            set { _hangSX = value; }
        }
        private string _loaiXe ;

        public string LoaiXe 
        {
            get { return _loaiXe ; }
            set { _loaiXe  = value; }
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
        private bool _trangThai;

        public bool TrangThai
        {
            get { return _trangThai; }
            set { _trangThai = value; }
        }



    }
}
