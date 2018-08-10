using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace Watcher.Controllers
{
    using System.Net;

    using Watcher.Common.Errors;
    using Watcher.Utils;

    [Route("[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [WatcherAuthorize("Admin")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var a = User;
            return new string[] { "value1", "value2" };
        }
        
        [HttpGet("Admin")]
        public string Getdmin(int id)
        {
            var a = User;
            return "value";
        }
        
        [HttpGet("Get")]
        public string Get(int id)
        {
            throw new HttpStatusCodeException(HttpStatusCode.BadRequest, "Qwewtreter");
        }
        
        [HttpGet("Post")]
        public void Post([FromBody] string value)
        {
            var a = User;
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
