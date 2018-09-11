using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DataAccumulator.Shared.Models;

using Microsoft.AspNetCore.Mvc;

using Watcher.Core.Interfaces;

namespace Watcher.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CollectorLogController : Controller
    {
        private readonly ICollectorActionLogService _service;

        public CollectorLogController(ICollectorActionLogService service)
        {
            _service = service;
        }



        // GET: api/<controller>
        [HttpGet("{instanceId}")]
        public virtual async Task<ActionResult<IEnumerable<ActionLogDto>>> GetAllLogsByInstanceId(Guid instanceId)
        {
            var dtos = await _service.GetAllLogs(instanceId);
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }
    }
}
