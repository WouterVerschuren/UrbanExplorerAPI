using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanExplorerDTO;
using UrbanExplorerInterfaces;

namespace UrbanExplorerDAL
{
    public class ExplorerDataService : IExplorerDataService
    {
        public void Post(ExplorerDTO explorer)
        {
            //using (SqlConnection con = DatabaseConnection.CreateConnection())

            //    try
            //    {
            //        using (SqlCommand cmd = new SqlCommand("INSERT INTO Explorer(Name, Password, Email) VALUES(@Name, @Password, @Email)", con))
            //        {
            //            cmd.Parameters.AddWithValue("@Name", explorer.Name);
            //            cmd.Parameters.AddWithValue("@Password", explorer.Password);
            //            cmd.Parameters.AddWithValue("@Email", explorer.Email);

            //            con.Open();
            //            var reader = cmd.ExecuteReader();
            //        }
            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine(exception.ToString());
            //    }
            //    finally
            //    {
            //        con.Close();
            //    }
        }
    }
}
