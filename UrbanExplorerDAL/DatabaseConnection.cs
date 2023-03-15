using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanExplorerDAL
{
    internal static class DatabaseConnection
    {
        public static MySqlConnection CreateConnection()
        {
            MySqlConnection connection = new MySqlConnection(GetConnectionString());

            return connection;
        }

        public static string GetConnectionString()
        {
            return "";
        }
    }
}
