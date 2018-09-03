namespace Watcher.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using DataAccumulator.DataAccessLayer.Entities;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using MongoDB.Bson;

    using Watcher.Common.Dtos;
    using Watcher.Common.Dtos.Plots;
    using Watcher.Core.Interfaces;
    using Watcher.Core.Services;

    using IMapper = AutoMapper.IMapper;

    /// <summary>   
    /// Controller to Manage Samples
    /// </summary>
    // [Authorize]
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CollectedDataController : ControllerBase
    {
        /// <summary>
        /// The Samples Service service
        /// </summary>
        private readonly ICollectedDataService _collectedDataService;

        private readonly IInstanceService _instanceService;

        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectedDataController"/> class. 
        /// </summary>
        /// <param name="service">
        /// The service.
        /// </param>
        /// <param name="instanceService"></param>
        public CollectedDataController(ICollectedDataService service,
                                       IMapper mapper,
                                       IInstanceService instanceService)
        {
            _collectedDataService = service;
            _mapper = mapper;
            _instanceService = instanceService;
        }

        /// <summary>
        /// Get Samples
        /// </summary>
        /// <returns>
        /// List of Dtos of Samples
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Samples not found</response>
        /// <response code="403">You don`t have permission to create watch Samples</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<InstanceDto>>> Get()
        {
            var dtos = await _collectedDataService.GetAllInstancesInfo();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        [HttpGet("Memory/{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<MemoryInfo>> GetInstanceMemoryInfo(Guid id)
        {
            var dto = await _collectedDataService.GetInstanceMemoryInfo(id);
            if (dto == null)
            {
                return NoContent();
            }

            return Ok(dto);
        }

        [HttpGet("Data/{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<PercentageInfo>> GetCollectedDataByInstanceId([FromRoute] Guid id, [FromQuery] int count)
        {
            var dtos = await _collectedDataService.GetCollectedDataByInstanceId(id, count);
            if (dtos == null)
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        [HttpGet("Percentage/{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<PercentageInfo>> GetInstancePercentageInfo([FromRoute] int id, [FromQuery] int count)
        {
            var entity = await _instanceService.GetEntityByIdAsync(id);

            var dto = await _collectedDataService.GetInstancePercentageInfo(entity.GuidId, count);
            if (dto == null)
            {
                return NoContent();
            }

            return Ok(dto);
        }

        [HttpGet("processes/cpu/{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<ProcessesCpuInfo>> GetProcessesCpuInfo(Guid id)
        {
            var dto = await _collectedDataService.GetInstanceProcessCpuInfo(id);
            if (dto == null)
            {
                return NoContent();
            }

            return Ok(dto);
        }

        [HttpGet("processes/ram/{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<ProcessesRamInfo>> GetProcessesRamInfo(Guid id)
        {
            var dto = await _collectedDataService.GetInstanceProcessRamInfo(id);
            if (dto == null)
            {
                return NoContent();
            }

            return Ok(dto);
        }

        [HttpGet("Builder")]
        [AllowAnonymous]
        public virtual ActionResult<IEnumerable<CollectedDataDto>> GetDataForBuilder()
        {
            var data = new List<CollectedDataDto>(20);
            var dateTime = DateTime.UtcNow;
            for (var i = 0; i < 20; i++)
            {
                var entity = CollectedDataService.GetFakeData(Guid.Empty, dateTime.AddSeconds(15 * i));
                entity.Id = Guid.NewGuid();
                var dto = _mapper.Map<CollectedData, CollectedDataDto>(entity);
                data.Add(dto);
            }

            return Ok(data);
        }
    }
}
