using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanExplorerDTO;

namespace UrbanExplorerInterfaces
{
    public interface IExplorerDataService
    {
        public void Post(ExplorerDTO userDTO);
    }
}
