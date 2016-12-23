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

        private string _maPhong;

        public string MaPhong
        {
            get { return _maPhong; }
            set { _maPhong = value; }
        }

        private DateTime _ngayDat;

        public DateTime NgayDat
        {
            get { return _ngayDat; }
            set { _ngayDat = value; }
        }
        private DateTime _ngayNhan;

        public DateTime NgayNhan
        {
            get { return _ngayNhan; }
            set { _ngayNhan = value; }
        }
        private DateTime _ngayTra;

        public DateTime NgayTra
        {
            get { return _ngayTra; }
            set { _ngayTra = value; }
        }
        private decimal _thanhTien;

        public decimal ThanhTien
        {
            get { return _thanhTien; }
            set { _thanhTien = value; }
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

        private bool _tinhTrang;

        public bool TinhTrang
        {
            get { return _tinhTrang; }
            set { _tinhTrang = value; }
        }
        

        public DatPhong_DTO() { }

        public DatPhong_DTO(string idDatPhong, string maKH, string maNV, string maPhong, string ngayDat, string ngayNhan, string ngayTra, string thanhTien, string traTruoc, string ghiChu, bool tinhTrang)
        {
            _idDatPhong = idDatPhong;
            _maKH = maKH;
            _maNV = maNV;
            _maPhong = maPhong;
            _ngayDat = Convert.ToDateTime(ngayDat);
            _ngayNhan = Convert.ToDateTime(ngayNhan);
            _ngayTra = Convert.ToDateTime(ngayTra);
            _thanhTien = Convert.ToDecimal(thanhTien);
            _traTruoc = Convert.ToDecimal(traTruoc);
            _ghiChu = ghiChu;
            _tinhTrang = tinhTrang;
        }
    }
}
