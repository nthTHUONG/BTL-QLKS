using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CoSoVatChat_DTO
    {
        private string _idCSVC;

        public string IDCSVC
        {
            get { return _idCSVC; }
            set { _idCSVC = value; }
        }

        private string _tenCSVC;

        public string TenCSVC
        {
            get { return _tenCSVC; }
            set { _tenCSVC = value; }
        }

        private string _maLP;

        public string MaLP
        {
            get { return _maLP; }
            set { _maLP = value; }
        }

        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        private string _tinhTrang;

        public string TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }

        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        public CoSoVatChat_DTO() { }

        public CoSoVatChat_DTO(string idCSVC, string tenCSVC, string maLP, string soLuong, string tinhTrang, string ghiChu)
        {
            _idCSVC = idCSVC;
            _tenCSVC = tenCSVC;
            _maLP = maLP;
            _soLuong = Convert.ToInt32(soLuong);
            _tinhTrang = tinhTrang;
            _ghiChu = ghiChu;
        }
    }
}
