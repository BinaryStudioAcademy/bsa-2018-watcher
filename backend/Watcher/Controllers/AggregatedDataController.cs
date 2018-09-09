using System.Collections.Generic;
using System.Linq;
using DataAccumulator.Shared.Models;
using Watcher.Common.Requests;
using Watcher.Core.Interfaces;

namespace Watcher.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class AggregatedDataController : Controller
    {
        private readonly IAggregateDataService _aggregateDataService;

        public AggregatedDataController(IAggregateDataService aggregateDataService)
        {
            _aggregateDataService = aggregateDataService;
        }

        [HttpGet("{id}/{type}/{from}/{to}")]
        public virtual async Task<ActionResult<IEnumerable<CollectedDataDto>>> GetDataByInstance(Guid id, CollectedDataType type, DateTime from, DateTime to)
        {
            var dtos = await _aggregateDataService.GetAggregatedDataInTime(id, type, from, to, 1, int.MaxValue);

            return Ok(dtos);
        }

        [HttpGet("{id}/{type}/{from}/{to}/{page}/{count}")]
        public virtual async Task<ActionResult<IEnumerable<CollectedDataDto>>> GetDataByInstancePagination(Guid id, CollectedDataType type, DateTime from, DateTime to,
                                                                                                                                            int page, int count)
        {
            var dtos = await _aggregateDataService.GetAggregatedDataInTime(id, type, from, to, 1, int.MaxValue);

            return Ok(dtos);
        }
    }
}
