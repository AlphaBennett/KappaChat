using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KappaChat.ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    public class RoomsController : Controller
    {
        // GET api/rooms
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values/getrooms
        [HttpPost("getrooms")]
        public void Post([FromBody]string value)
        {
        }
    }
}
