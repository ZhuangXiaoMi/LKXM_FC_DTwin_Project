using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LKXM.FCDTwin.Collect.Controllers.Demo
{
    //[Route("api/[controller]")]
    [Route("api/ids4")]
    [ApiController]
    [Authorize]
    public class IdentityServer4Controller : ControllerBase
    {
        // GET: api/<IdentityServer4Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<IdentityServer4Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IdentityServer4Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IdentityServer4Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IdentityServer4Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
