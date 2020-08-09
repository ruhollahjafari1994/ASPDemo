using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DB
    {
        public static string ConnectionString
        {
            get
            {
                string conStr = ConfigurationManager.ConnectionStrings["DBADW"].ToString();
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(conStr);
                sb.ApplicationName = ApplicationName ?? sb.ApplicationName;
                sb.ConnectTimeout = (ConnectionTimeout > 0) ? ConnectionTimeout : sb.ConnectTimeout;
                return sb.ToString();
            }
        }

        /// //Return an Open Connection to the Caller 
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        /// //Override the Connection Time Out
        public static int ConnectionTimeout { get; set; }



        /// /Property Used To Override The name Of The Application
        public static string ApplicationName { get; set; }
    }
}
