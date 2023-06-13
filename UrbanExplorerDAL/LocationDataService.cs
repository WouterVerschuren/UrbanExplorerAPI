using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System.Collections.Generic;
using System.Linq;
using UrbanExplorerDTO;
using UrbanExplorerInterfaces;

namespace UrbanExplorerDAL
{
    public class LocationDataService : IlocationDataService
    {
        private readonly LocationDBContext _context;

        public LocationDataService()
        {

        }

        public LocationDataService(LocationDBContext context)
        {
            _context = context;
        }

        public void CreateLocation(LocationDTO locationDTO)
        {
            _context.Locations.Add(locationDTO);
            _context.SaveChanges();
        }

        public void DeleteLocation(LocationDTO locationDTO)
        {
            throw new NotImplementedException();
        }

        public List<LocationDTO> GetAllLocations()
        {
            return _context.Locations.ToList();
        }

        public LocationDTO GetLocationById(int id)
        {
            return _context.Locations.Find(id);
        }

        public void UpdateLocation(LocationDTO locationDTO)
        {
            throw new NotImplementedException();
        }
    }
}
