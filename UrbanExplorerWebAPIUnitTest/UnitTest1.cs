using UrbanExplorerDAL;
using UrbanExplorerDTO;
using UrbanExplorerInterfaces;
using UrbanExplorerLogic;

namespace UrbanExplorerWebAPIUnitTest
{
    [TestClass]
    public class UnitTest1
    {
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
            var expectedInformation = "ey";
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
    }
}