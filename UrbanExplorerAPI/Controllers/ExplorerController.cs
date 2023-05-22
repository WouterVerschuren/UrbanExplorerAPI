using Microsoft.AspNetCore.Mvc;
using UrbanExplorerDAL;
using UrbanExplorerDTO;
using UrbanExplorerLogic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrbanExplorerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplorerController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post(string name, string email, string password)
        {
            ExplorerService explorerService = new ExplorerService(new ExplorerDataService());
            ExplorerDTO explorer = new ExplorerDTO();
            explorer.Name = name;
            explorer.Email = email;
            explorer.Password = password;
            explorerService.Post(explorer);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
