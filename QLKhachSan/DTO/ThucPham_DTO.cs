using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThucPham_DTO
    {
        private string _idThucPham;

        public string IDThucPham
        {
            get { return _idThucPham; }
            set { _idThucPham = value; }
        }

        private string _tenTP;

        public string TenTP
        {
            get { return _tenTP; }
            set { _tenTP = value; }
        }

        private Decimal _donGia;

        public Decimal DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

        private string _nhaSX;

        public string NhaSX
        {
            get { return _nhaSX; }
            set { _nhaSX = value; }
        }

        private DateTime _ngaySX;

        public DateTime NgaySX
        {
            get { return _ngaySX; }
            set { _ngaySX = value; }
        }

        private DateTime _hanSD;

        public DateTime HanSD
        {
            get { return _hanSD; }
            set { _hanSD = value; }
        }

        private string _mieuTa;

        public string MieuTa
        {
            get { return _mieuTa; }
            set { _mieuTa = value; }
        }
        public ThucPham_DTO() { }

        public ThucPham_DTO(string idThucPham, string tenTP, string donGia, string nhaSX, string ngaySX, string hanSD, string mieuTa)
        {
            _idThucPham = idThucPham;
            _tenTP = tenTP;
            _donGia = Convert.ToDecimal(donGia);
            _nhaSX = nhaSX;
            _ngaySX = Convert.ToDateTime(ngaySX);
            _hanSD = Convert.ToDateTime(hanSD);
            _mieuTa = mieuTa;
        }
    }
}
