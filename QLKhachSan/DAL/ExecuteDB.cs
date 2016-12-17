using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExecuteDB
    {
<<<<<<< HEAD
        public Boolean ExecuteData(string sql)
        {
            SqlConnection conn = ConnectDB.ConnectData();
=======
        SqlConnection conn = ConnectDB.ConnectData();

        public Boolean ExecuteData(string sql)
        {
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
            ConnectDB.Open(conn);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                ConnectDB.Close(conn);
                conn.Dispose();
            }
        }
<<<<<<< HEAD
        public object ExecuteScalar(string sql)
        {
            SqlConnection conn = ConnectDB.ConnectData();
            ConnectDB.Open(conn);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                object value = cmd.ExecuteScalar();
                cmd.Dispose();
                return value;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                ConnectDB.Close(conn);
                conn.Dispose();
            }
        }
=======
>>>>>>> 3af32be00ffc70fb665eb58bee93763a1c2d5ef0
    }
}
