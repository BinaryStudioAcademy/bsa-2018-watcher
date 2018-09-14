namespace Watcher.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;

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
        private readonly IEmailProvider _emailProvider;
        private readonly IMapper _mapper;

        public InstanceAnomalyReportsController(IInstanceAnomalyReportsService service, 
                                                IEmailProvider provider,
                                                IMapper mapper)
        {
            _service = service;
            _emailProvider = provider;
            _mapper = mapper;
        }

        // /InstanceAnomalyReports/Report/774186a3-2850-4792-a648-53b07db62af2

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
            var dto = _mapper.Map<InstanceAnomalyReport, InstanceAnomalyReportDto>(report);
            var html = InstanceAnomalyReportsService.GetHtml(dto);
            var htmlLetter = InstanceAnomalyReportsService.GetHtmlForLetter("userName", html, "bsa-watcher.azurewebsites.net");
            _emailProvider.SendMessageOneToOne("watcher@net.com", "Analyze", "target.com", "", htmlLetter);
            return Ok(report);
        }
    }
}
