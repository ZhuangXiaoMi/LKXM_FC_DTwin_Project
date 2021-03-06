using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LKXM.FCDTwin.WebApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class DemoController : BaseController
    {
        // GET: api/<DemoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DemoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DemoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DemoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DemoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
