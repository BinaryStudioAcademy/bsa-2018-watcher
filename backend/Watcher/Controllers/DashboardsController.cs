using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;
using Watcher.Core.Interfaces;

namespace Watcher.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class DashboardsController : ControllerBase
    {
        private readonly IDashboardsService _dashboardsService;

        public DashboardsController(IDashboardsService service)
        {
            _dashboardsService = service;
        }

        // GET: /dashboards
        [HttpGet("{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<DashboardDto>>> GetInstanceDashboards(int id)
        {
            var dtos = await _dashboardsService.GetInstanceDashboards(id);
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        // POST: /dashboards
        [HttpPost]
        public virtual async Task<ActionResult<DashboardDto>> Create([FromBody]DashboardRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _dashboardsService.CreateDashboardAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }

            return Ok(dto);
        }

        // PUT: /dashboards/:id
        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update([FromRoute] int id, [FromBody] DashboardRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _dashboardsService.UpdateDashboardByIdAsync(request, id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }

        // DELETE: /dashboards/:id
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(int id)
        {
            var result = await _dashboardsService.DeleteDashboardByIdAsync(id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }
    }
}