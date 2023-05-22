using Microsoft.AspNetCore.Mvc;
using UrbanExplorerAPI.Models;
using UrbanExplorerDAL;
using UrbanExplorerDTO;
using UrbanExplorerLogic;
using System.Text.Json;
using System.Web.Http.Cors;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrbanExplorerAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        // GET: api/<LocationController>
        [HttpGet]
        public JsonResult GetAllLocations()
        {
            List<Location> locations = new List<Location>();
            LocationService locationService = new LocationService(new LocationDataService());
            List<LocationDTO> locationsDTO = locationService.GetAllLocations();

            foreach (LocationDTO locationDTO in locationsDTO)
            {
                Location location = new Location();

                location.Id = locationDTO.Id;
                location.Longtitude = locationDTO.Longtitude;
                location.Latitude = locationDTO.Latitude;
                location.Rating = locationDTO.Rating;
                location.Checked = locationDTO.Checked;
                location.Infomation = locationDTO.Infomation;

                locations.Add(location);
            }




            return new JsonResult(locations);
        }

        // GET: api/<LocationController>
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            LocationService locationService = new LocationService(new LocationDataService());
            LocationDTO locationDTO = locationService.GetLocationById(id);
            Location location = new Location();

            location.Id = locationDTO.Id;
            location.Longtitude = locationDTO.Longtitude;
            location.Latitude = locationDTO.Latitude;
            location.Rating = locationDTO.Rating;
            location.Checked = locationDTO.Checked;
            location.Infomation = locationDTO.Infomation;


            return new JsonResult(location);
        }

        // POST api/<LocationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LocationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
