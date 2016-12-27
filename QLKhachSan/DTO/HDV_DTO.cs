using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HDV_DTO
    {
        private string _idHDV;

        public string IDHDV
        {
            get { return _idHDV; }
            set { _idHDV = value; }
        }
        private string _TenHDV;

        public string TenHDV
        {
            get { return _TenHDV; }
            set { _TenHDV = value; }
        }
        private string _GioiTinh;

        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public HDV_DTO(string IDHDV, string TenHDV, string GioiTinh, string NgaySinh)
        {
            _idHDV = IDHDV;
            _TenHDV = TenHDV;
            _GioiTinh = GioiTinh;
            _NgaySinh = Convert.ToDateTime(NgaySinh);
        }
    }
}
