using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanExplorerDTO;
using UrbanExplorerInterfaces;

namespace UrbanExplorerLogic
{
    public class ExplorerService
    {
        private readonly IExplorerDataService _Dataservice;

        public ExplorerService(IExplorerDataService userdataservice)
        {
            this._Dataservice = userdataservice;
        }

        public void Post(ExplorerDTO user)
        {
            _Dataservice.Post(user);
        }
    }
}
