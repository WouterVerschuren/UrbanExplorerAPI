using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanExplorerDTO;
using UrbanExplorerInterfaces;

namespace UrbanExplorerLogic
{
    public class LocationService
    {
        private readonly IlocationDataService _Dataservice;

        public LocationService(IlocationDataService ilocation)
        {
            this._Dataservice = ilocation;
        }

        public void Post(LocationDTO location)
        {
            _Dataservice.Post(location);
        }

        public LocationDTO GetLocationById(int id) 
        { 
            return _Dataservice.GetLocationById(id);
        }

        public List<LocationDTO> GetAllLocations()
        {
            return _Dataservice.GetAllLocations();
        }
    }
}
