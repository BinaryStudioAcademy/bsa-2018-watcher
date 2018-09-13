namespace Watcher.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.Shared.Models;

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


        [HttpGet("{id}/{type}/{from}/{to}")]
        public virtual async Task<ActionResult<IEnumerable<CollectedDataDto>>> GetDataByInstance(Guid id, 
                                                                                                 CollectedDataType type, 
                                                                                                 DateTime from, 
                                                                                                 DateTime to)
        {
            var dtos = await _service.GetReportsInTimeAsync(id, type, from, to, 1, int.MaxValue);

            return Ok(dtos);
        }

        [HttpGet("getCount/{id}/{type}/{from}/{to}")]
        public virtual async Task<ActionResult<int>> GetCount(Guid id, CollectedDataType type, DateTime from, DateTime to)
        {
            var dtos = await _service.GetCountOfReportsAsync(id, type, @from, to);

            return Ok(dtos);
        }

        [HttpGet("{id}/{type}/{from}/{to}/{page}/{count}")]
        public virtual async Task<ActionResult<IEnumerable<CollectedDataDto>>> GetDataByInstancePagination(Guid id, 
                                                                                                           CollectedDataType type,
                                                                                                           DateTime from, 
                                                                                                           DateTime to,
                                                                                                           int page, 
                                                                                                           int count)
        {
            var dtos = await _service.GetReportsInTimeAsync(id, type, from, to, page, count);

            return Ok(dtos);
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
