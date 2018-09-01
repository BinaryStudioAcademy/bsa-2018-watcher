using System;
using System.Collections.Generic;

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
        private readonly IEmailProvider _emailProvider;
        private readonly IUsersService _usersService;
        private readonly IOrganizationService _organizationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvitesController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Organizations service
        /// </param>
        public OrganizationInvitesController(IOrganizationInvitesService service, IEmailProvider emailProvider, IUsersService usersService, IOrganizationService organizationService)
        {
            _service = service;
            _emailProvider = emailProvider;
            _usersService = usersService;
            _organizationService = organizationService;
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

        /// <summary>
        /// Get Invites by user id
        /// </summary>
        /// <param name="id">User identifier</param>
        /// <returns>
        /// Collection of OrganizationInviteDto
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Invites not found</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet("getByUser/{id}")]
        public virtual async Task<ActionResult<IEnumerable<OrganizationInviteDto>>> GetByUserId(string id)
        {
            var dtos = await _service.GetEntitiesByUserIdAsync(id);
            if (dtos == null)
            {
                return NotFound();
            }

            return Ok(dtos);
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

        [Route("CreatedAndSend")]
        [HttpPost]
        public virtual async Task<ActionResult<OrganizationInviteDto>> CreatedAndSend([FromBody] OrganizationInviteRequest request)
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
            if (String.IsNullOrWhiteSpace(request.InviteEmail) != true)
            {
                var fromUser = await _usersService.GetEntityByIdAsync(request.CreatedByUserId);
                var company = await _organizationService.GetEntityByIdAsync(request.OrganizationId);
                string body = $"User {fromUser.DisplayName} granted you access to the organization {company.Name}. \n ";
                body += $"Your invite link: https://bsa-watcher.azurewebsites.net/invite/{request.Link}";
                await _emailProvider.SendMessageOneToOne("invite@watcher.com", "WATCHER Invite", request.InviteEmail, body, "");
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

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteEntityAsync(id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }
    }
}
