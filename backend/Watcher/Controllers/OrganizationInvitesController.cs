namespace Watcher.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;

    /// <summary>   
    /// Controller to Manage OrganizationsInvites
    /// </summary>
    // [Authorize]
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class OrganizationInvitesController : ControllerBase
    {
        /// <summary>
        /// The Organizations Service service
        /// </summary>
        private readonly IOrganizationInvitesService _service;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvitesController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Organizations service
        /// </param>
        public OrganizationInvitesController(IOrganizationInvitesService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get Organization by id
        /// </summary>
        /// <param name="link">Organization identifier</param>
        /// <returns>
        /// Dto of Organization
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Organizations not found</response>
        /// <response code="403">You don`t have permission to create watch Organization</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet("{link}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<OrganizationInviteDto>> GetByLink(string link)
        {
            var dto = await _service.GetEntityByLinkAsync(link);
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        [HttpPost]
        public virtual async Task<ActionResult<OrganizationInviteDto>> Create([FromBody] OrganizationInviteRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _service.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }

            return Ok(dto);
        }

        /// <summary>
        /// Update OrganizationInvite by id
        /// </summary>
        /// <param name="id">OrganizationInvite identifier</param> 
        /// <param name="userId">OrganizationInvite identifier</param>
        /// <returns>
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">OrganizationInvite not found</response>
        /// <response code="403">You don`t have permission to create watch OrganizationInvite</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update([FromRoute] int id, [FromBody] OrganizationInviteRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _service.UpdateEntityByIdAsync(request, id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }
    }
}
