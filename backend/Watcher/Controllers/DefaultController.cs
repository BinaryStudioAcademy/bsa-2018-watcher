using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Watcher.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        // GET: api/Default
        [Authorize]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var a = User;
            return new string[] { "value1", "value2" };
        }

        // GET: api/Default/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Default/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
