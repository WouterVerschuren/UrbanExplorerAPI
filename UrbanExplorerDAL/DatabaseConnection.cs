using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanExplorerDAL
{
    internal static class DatabaseConnection
    {
        public static SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection(GetConnectionString());

            return connection;
        }

        public static string GetConnectionString()
        {
            return "Data Source=LAPTOP-MOO8TEUR\\SPOTIFY2;Initial Catalog=UrbanExplorer;Integrated Security=True;TrustServerCertificate=True";
        }
    }
}
