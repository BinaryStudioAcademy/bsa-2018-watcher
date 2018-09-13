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
        private readonly IEmailProvider _emailProvider;

        public InstanceAnomalyReportsController(IInstanceAnomalyReportsService service, IEmailProvider provider)
        {
            _service = service;
            _emailProvider = provider;
        }

        // /InstanceAnomalyReports/Report/774186a3-2850-4792-a648-53b07db62af2
        [HttpGet("Report/{instanceId}")]
        [AllowAnonymous]
        public virtual ActionResult<InstanceAnomalyReport> GetReport([FromRoute] Guid instanceId)
        {
            var report = InstanceAnomalyReportsService.GetAnomalyReport(instanceId);
            var html = InstanceAnomalyReportsService.GetHtml(report);
            _emailProvider.SendMessageOneToOne("watcher@net.com", "Analyze", "target.com", "", html);
            return Ok(report);
        }
    }
}
