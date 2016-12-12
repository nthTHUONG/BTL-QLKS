using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietThucPham_DTO
    {
        private string _idTP;

        public string IDTP
        {
            get { return _idTP; }
            set { _idTP = value; }
        }
        private string _tenTP;

        public string TenTP
        {
            get { return _tenTP; }
            set { _tenTP = value; }
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
        public ChiTietThucPham_DTO() { }
        public ChiTietThucPham_DTO(string idTP, string tenTP, string nhaSX, string ngaySX, string hanSD, string mieuTa)
        {
            _idTP = idTP;
            _tenTP = tenTP;
            _nhaSX = nhaSX;
            _ngaySX = Convert.ToDateTime(ngaySX);
            _hanSD = Convert.ToDateTime(hanSD);
            _mieuTa = mieuTa;
        }
    }
}
