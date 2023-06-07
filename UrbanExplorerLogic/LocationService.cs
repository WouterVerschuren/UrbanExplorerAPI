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

        public void CreateLocation(LocationDTO location)
        {
            _Dataservice.CreateLocation(location);
        }
        public void DeleteLocation(LocationDTO location)
        {
            _Dataservice.DeleteLocation(location);
        }

        public void UpdateLocation(LocationDTO location)
        {
            _Dataservice.UpdateLocation(location);
        }

        public LocationDTO GetLocationById(int id) 
        { 
            return _Dataservice.GetLocationById(id);
        }

        public List<LocationDTO> GetAllLocations()
        {
            return _Dataservice.GetAllLocations();
        }
        public void Post(LocationDTO location)
        {
            _Dataservice.CreateLocation(location);
        }


    }
}
