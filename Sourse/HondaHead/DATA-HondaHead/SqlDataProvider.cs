using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace DATAHondaHead
{
    public class SqlDataProvider
    {
        public static string connectionstring;
        public static SqlConnection connection;
        public SqlDataProvider()
        {
            if (connection == null)
            {
                connectionstring = DATAHondaHead.Properties.Settings.Default.ConnectString;
                connection = new SqlConnection(connectionstring);
            }
        }
        public SqlConnection GetConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                return connection;
            }
            else
            {
                return connection;
            }
        }
    }
}
