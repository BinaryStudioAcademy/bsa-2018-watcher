using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace Watcher.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;
    
    /// <summary>   
    /// Controller to Manage Samples
    /// </summary>
    // [Authorize]
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class InstanceController : ControllerBase
    {
        /// <summary>
        /// The Samples Service service
        /// </summary>
        private readonly IInstanceService _instanceService;

        /// <summary>
        /// Notifications Hub Context
        /// </summary>
        /// <summary>
        /// Initializes a new instance of the <see cref="SamplesController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Samples service

        public InstanceController(IInstanceService service)
        {
            _instanceService = service;
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
            var dtos = await _instanceService.GetAllEntitiesAsync();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        /// <summary>
        /// Get Sample by id
        /// </summary>
        /// <param name="id">Sample identifier</param>
        /// <returns>
        /// Dto of Sample
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Samples not found</response>
        /// <response code="403">You don`t have permission to create watch Sample</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<InstanceDto>>> GetByOrganizationId(int id)
        {
            var dto = await _instanceService.GetEntitiesByOrganizationIdAsync(id);
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        /// <summary>
        /// Add new Sample
        /// </summary>
        /// <param name="request">Sample create request</param>
        /// <returns>
        /// Dto of Sample
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Sample not found</response>
        /// <response code="403">You don`t have permission to create Sample</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPost]
        public virtual async Task<ActionResult<SampleDto>> Create([FromBody] InstanceRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _instanceService.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }

            return Ok(dto);
        }

        /// <summary>
        /// Update Sample
        /// </summary>
        /// <param name="id">Sample identifier</param>
        /// <param name="request">Sample update request</param>
        /// <returns>
        /// Action Result
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Sample not found</response>
        /// <response code="403">You don`t have permission to update Sample</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update([FromRoute] int id, [FromBody] InstanceRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _instanceService.UpdateEntityByIdAsync(request, id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }

        /// <summary>
        /// Delete Sample
        /// </summary>
        /// <param name="id">Sample identifier</param>
        /// <returns>
        /// Action Result
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Sample not found</response>
        /// <response code="403">You don`t have permission to delete Sample</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(int id)
        {
            var result = await _instanceService.DeleteEntityByIdAsync(id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }
    }
}
