using Microsoft.AspNetCore.Routing;
using System.Data;
using System.Data.SqlClient;
using UrbanExplorerDAL;
using UrbanExplorerDTO;
using UrbanExplorerInterfaces;
using UrbanExplorerLogic;

namespace UrbanExplorerWebAPIUnitTest
{
    [TestClass]
    public class UnitTest
    {
        string connectionString = "Server=tcp:urbanexplorerserver.database.windows.net,1433;Initial Catalog=urbanexplorerdb;Persist Security Info=False;User ID=UrbanExplorer;Password=QRHHpe4y;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        [TestMethod]
        public void LocationDTO_CheckIfDataGetsCorrectlyFetchedFromDataBase()
        {
            // Arrange
            LocationDTO locationDTO = new LocationDTO();
            LocationDTO locationDTO2 = new LocationDTO();
            LocationService locationService = new LocationService(new LocationDataService(new LocationDBContext()));
            var expectedId = 1;
            var expectedLongitude = 436;
            var expectedLatitude = 34634;
            var expectedInformation = "eyery";
            var expectedRating = 3;
            var expectedChecked = false;

            // Act
            locationDTO.Id = expectedId;
            locationDTO.Longtitude = expectedLongitude;
            locationDTO.Latitude = expectedLatitude;
            locationDTO.Information = expectedInformation;
            locationDTO.Rating = expectedRating;
            locationDTO.Checked = expectedChecked;
            locationDTO2 = locationService.GetLocationById(1);

            // Assert
            Assert.AreEqual(locationDTO.Id, locationDTO2.Id);
            Assert.AreEqual(locationDTO.Longtitude, locationDTO2.Longtitude);
            Assert.AreEqual(locationDTO.Latitude, locationDTO2.Latitude);
            Assert.AreEqual(locationDTO.Information, locationDTO2.Information);
            Assert.AreEqual(locationDTO.Rating, locationDTO2.Rating);
            Assert.AreEqual(locationDTO.Checked, locationDTO2.Checked);
        }


        

        [TestMethod]
        public void TestDatabaseConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Assert.AreEqual(System.Data.ConnectionState.Open, connection.State);
                }
                catch (SqlException)
                {
                    Assert.Fail("Failed to establish a connection with the database.");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}