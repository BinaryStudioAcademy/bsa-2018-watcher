namespace Watcher.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    
    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;

    /// <summary>   
    /// Controller to Manage Organizations
    /// </summary>
    // [Authorize]
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        /// <summary>
        /// The Organizations Service service
        /// </summary>
        private readonly IOrganizationService _organizationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationsController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Organizations service
        /// </param>
        public OrganizationsController(IOrganizationService service)
        {
            _organizationService = service;
        }

        /// <summary>
        /// Get Organizations
        /// </summary>
        /// <returns>
        /// List of Dtos of Organizations
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Organizations not found</response>
        /// <response code="403">You don`t have permission to create watch Organizations</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<OrganizationDto>>> Get()
        {
            var dtos = await _organizationService.GetAllEntitiesAsync();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        /// <summary>
        /// Get Organization by id
        /// </summary>
        /// <param name="id">Organization identifier</param>
        /// <returns>
        /// Dto of Organization
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Organizations not found</response>
        /// <response code="403">You don`t have permission to create watch Organization</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<OrganizationDto>> GetById(int id)
        {
            var dto = await _organizationService.GetEntityByIdAsync(id);
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        /// <summary>
        /// Add new Organization
        /// </summary>
        /// <param name="request">Organization create request</param>
        /// <returns>
        /// Dto of Organization
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Organization not found</response>
        /// <response code="403">You don`t have permission to create Organization</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPost]
        public virtual async Task<ActionResult<OrganizationDto>> Create([FromBody] OrganizationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _organizationService.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }

            return CreatedAtAction("GetById", new { id = dto.Id }, dto);
        }

        /// <summary>
        /// Update Organization
        /// </summary>
        /// <param name="id">Organization identifier</param>
        /// <param name="request">Organization update request</param>
        /// <returns>
        /// Action Result
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Organization not found</response>
        /// <response code="403">You don`t have permission to update Organization</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update([FromRoute] int id, [FromBody] OrganizationUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _organizationService.UpdateEntityByIdAsync(request, id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }

        /// <summary>
        /// Delete Organization
        /// </summary>
        /// <param name="id">Organization identifier</param>
        /// <returns>
        /// Action Result
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Organization not found</response>
        /// <response code="403">You don`t have permission to delete Organization</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(int id)
        {
            var result = await _organizationService.DeleteEntityByIdAsync(id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }
    }
}
