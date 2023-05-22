using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanExplorerDTO
{
    public class LocationDTO
    {
        public int Id { get; set; }
        public double Longtitude { get; set; }
        public double Latitude { get; set; }
        public string? Infomation { get; set; }
        public int Rating { get; set; }
        public bool Checked { get; set; }
        
    }
}
