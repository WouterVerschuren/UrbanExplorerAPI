using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanExplorerDTO;

namespace UrbanExplorerInterfaces
{
    public interface IlocationDataService
    {
        public void Post(LocationDTO locationDTO);
        public LocationDTO GetLocationById(int id);
        public List<LocationDTO> GetAllLocations();
    }
}
