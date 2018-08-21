using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace Watcher.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Watcher.Common.Dtos;
    using Watcher.Common.Dtos.Plots;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    
    /// <summary>   
    /// Controller to Manage Samples
    /// </summary>
    // [Authorize]
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CollectedDataController: ControllerBase
    {
        /// <summary>
        /// The Samples Service service
        /// </summary>
        private readonly ICollectedDataService _collectedDataService;

        /// <summary>
        /// Notifications Hub Context
        /// </summary>
        /// <summary>
        /// Initializes a new instance of the <see cref="SamplesController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Samples service

        public CollectedDataController(ICollectedDataService service)
        {
            _collectedDataService = service;
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
            var kek = await _collectedDataService.GetFakeData();
            return Ok(dtos);
        }

        [HttpGet("memory/{id}")]
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

        [HttpGet("percentage/{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<PercentageInfo>> GetInstancePercentageInfo(Guid id)
        {
            var dto = await _collectedDataService.GetInstancePercentageInfo(id);
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
    }
}
