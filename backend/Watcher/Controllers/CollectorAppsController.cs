namespace Watcher.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;

    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CollectorAppsController : ControllerBase
    {
        private readonly ICollectorAppsService _collectorAppsService;
        public CollectorAppsController(ICollectorAppsService collectorAppsService)
        {
            _collectorAppsService = collectorAppsService;
        }
        
        [HttpPost("uploadApp"), DisableRequestSizeLimit]
        public virtual async Task<ActionResult> UploadFile()
        {
            try
            {
                var file = Request.Form.Files[0];
                if (file.Length > 0)
                {
                    return Ok(await _collectorAppsService.UploadFileToStorage(file));
                }
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }
            return BadRequest();
        }


        /// <summary>
        /// Get Active CollectorAppVersion 
        /// </summary>
        /// <returns>
        /// Dtos of CollectorAppVersion
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Organizations not found</response>
        /// <response code="403">You don`t have permission to create watch Organizations</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet("active")]
        [AllowAnonymous]
        public virtual async Task<ActionResult> GetActive()
        {
            var dto = await _collectorAppsService.GetActiveEntityAsync();
            if (dto == null)
            {
                return NoContent();
            }

            return Ok(dto);
        }

        /// <summary>
        /// Get All CollectorAppVersion
        /// </summary>
        /// <returns>
        /// List of Dtos of CollectorAppVersion
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Organizations not found</response>
        /// <response code="403">You don`t have permission to create watch Organizations</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet]
        [AllowAnonymous]
        public virtual async Task<ActionResult> GetAll()
        {
            var dtos = await _collectorAppsService.GetAllEntityesAsync();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }


        /// <summary>
        /// Add new CollectorAppVersion
        /// </summary>
        /// <param name="request">CollectorAppVersion create request</param>
        /// <returns>
        /// Dto of CollectorAppVersion
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Organization not found</response>
        /// <response code="403">You don`t have permission to create Organization</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPost]
        public virtual async Task<ActionResult> Create([FromBody] CollectorAppVersionRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _collectorAppsService.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }

            return Ok(dto);
        }
    }
}
