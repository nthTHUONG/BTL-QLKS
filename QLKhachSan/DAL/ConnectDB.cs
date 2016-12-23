using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ConnectDB
    {
        public static SqlConnection ConnectData()
        {
            string cnstr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
            SqlConnection conn = new SqlConnection(cnstr);
            return conn;
        }

        public static void Open(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void Close(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
