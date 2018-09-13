namespace Watcher.Controllers
{
    using System;

    using DataAccumulator.DataAccessLayer.Entities;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Watcher.Core.Interfaces;
    using Watcher.Core.Services;

    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class InstanceAnomalyReportsController : ControllerBase
    {
        private readonly IInstanceAnomalyReportsService _service;

        public InstanceAnomalyReportsController(IInstanceAnomalyReportsService service)
        {
            _service = service;
        }

        [HttpGet("Report/{instanceId}")]
        [AllowAnonymous]
        public virtual ActionResult<InstanceAnomalyReport> GetReport([FromRoute] Guid instanceId)
        {
            var report = InstanceAnomalyReportsService.GetAnomalyReport(instanceId);
            return Ok(report);
        }
    }
}
