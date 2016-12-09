using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatPhong_DTO
    {
        private string _idDatPhong;

        public string IDDatPhong
        {
            get { return _idDatPhong; }
            set { _idDatPhong = value; }
        }

        private string _maPhong;

        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }

        private string _maLP;

        public string MaLP
        {
            get { return _maLP; }
            set { _maLP = value; }
        }

        private string _maKH;

        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        private string _ngayDat;

        public string NgayDat
        {
            get { return _ngayDat; }
            set { _ngayDat = value; }
        }
        private string _ngayNhan;

        public string NgayNhan
        {
            get { return _ngayNhan; }
            set { _ngayNhan = value; }
        }
        private string _ngayTra;

        public string NgayTra
        {
            get { return _ngayTra; }
            set { _ngayTra = value; }
        }
        private double _giaPhong;

        public double GiaPhong
        {
            get { return _giaPhong; }
            set { _giaPhong = value; }
        }
        private double _traTruoc;

        public double TraTruoc
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
    }
}
