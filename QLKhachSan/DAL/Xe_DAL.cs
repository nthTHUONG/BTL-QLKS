using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class Xe_DAL
    {
        SqlConnection cnn = ConnectDB.ConnectData();
        public DataTable GetDataXe()
        {
            ConnectDB.Open(cnn);
            try
            {
                string sql = "SELECT * FROM Xe";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.Dispose();
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                ConnectDB.Close(cnn);
            }
        }

        public Boolean ThemXe(Xe_DTO xe)
        {
            return new ExecuteDB().ExecuteData("INSERT INTO Xe values (N'" + xe.IDXe+"', N'" + xe.HangSX+"', N'" + xe.LoaiXe+"', '" + xe.GiaThue+"', N'" + xe.GhiChu+"', N'" + xe.TinhTrang+"')");
        }

        public Boolean SuaXe(Xe_DTO xe)
        {
            return new ExecuteDB().ExecuteData("update Xe set HangSX = N'" + xe.HangSX + "', LoaiXe = N'" + xe.LoaiXe + "', GiaThue = '" + xe.GiaThue + "',GhiChu =  N'" + xe.GhiChu + "',TrangThai = '" + xe.TinhTrang + "' where IDXe = N'" + xe.IDXe + "'");
        }
        public Boolean XoaXe(string idXe)
        {
            return new ExecuteDB().ExecuteData("DELETE FROM Xe WHERE IDXe = N'" + idXe + "'");
        }
    }
}
