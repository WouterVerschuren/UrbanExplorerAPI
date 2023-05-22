using MySqlConnector;
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
    public class LocationDataService : IlocationDataService 
    {

        public LocationDTO GetLocationById(int id)
        {
            return 
        }
        //public LocationDTO GetLocationById(int id)
        //{
        //    LocationDTO location = new LocationDTO();
        //    using (SqlConnection con = DatabaseConnection.CreateConnection())

        //        try
        //        {
        //            using (SqlCommand cmd = new SqlCommand("SELECT * FROM location WHERE id = " + id, con))
        //            {
        //                con.Open();
        //                var reader = cmd.ExecuteReader();
        //                while (reader.Read())
        //                {
        //                    if (!reader.IsDBNull(0))
        //                        location.Id = reader.GetInt32(0);

        //                    if (!reader.IsDBNull(1))
        //                        location.Longtitude = reader.GetDouble(1);

        //                    if (!reader.IsDBNull(2))
        //                        location.Latitude = reader.GetDouble(2);
        //                    if (!reader.IsDBNull(3))
        //                        location.Rating = reader.GetInt32(3);

        //                    if (!reader.IsDBNull(4))
        //                        location.Checked = Convert.ToBoolean(reader.GetByte(4));
        //                    if (!reader.IsDBNull(5))
        //                        location.Infomation = reader.GetString(5);
                           
        //                }
        //            }


        //        }
        //        catch (Exception exception)
        //        {
        //            Console.WriteLine(exception.ToString());
        //            return null;
        //        }
        //        finally
        //        {
        //            con.Close();
        //        }
        //    return location;
        //}

        public List<LocationDTO> GetAllLocations()
        {
            List<LocationDTO> locations = new List<LocationDTO>();
            using (SqlConnection con = DatabaseConnection.CreateConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM location", con))
                    {
                        con.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            LocationDTO location = new LocationDTO();
                            if (!reader.IsDBNull(0))
                                location.Id = reader.GetInt32(0);

                            if (!reader.IsDBNull(1))
                                location.Longtitude = reader.GetDouble(1);

                            if (!reader.IsDBNull(2))
                                location.Latitude = reader.GetDouble(2);
                            if (!reader.IsDBNull(3))
                                location.Rating = reader.GetInt32(3);

                            if (!reader.IsDBNull(4))
                                location.Checked = !reader.IsDBNull(4) ? reader.GetByte(4) == 1 : false;
                            if (!reader.IsDBNull(5))
                                location.Infomation = reader.GetString(5);

                            locations.Add(location);
                        }
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.ToString());
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }
            return locations;
        }

        public void Post(LocationDTO locationDTO)
        {
            using (SqlConnection con = DatabaseConnection.CreateConnection())

                try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Location(Longtitude, Latitude, Rating, Checked,Infomation) VALUES(@Longtitude, @Latitude, @Rating, @Checked, @Infomation)", con))
                    {
                        cmd.Parameters.AddWithValue("@Longtitude", locationDTO.Longtitude);
                        cmd.Parameters.AddWithValue("@Latitude", locationDTO.Latitude);
                        cmd.Parameters.AddWithValue("@Rating", locationDTO.Rating);
                        cmd.Parameters.AddWithValue("@Checked", locationDTO.Checked);
                        cmd.Parameters.AddWithValue("@Infomation", locationDTO.Infomation);

                        con.Open();
                        var reader = cmd.ExecuteReader();
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.ToString());
                }
                finally
                {
                    con.Close();
                }
        }
    }
}
