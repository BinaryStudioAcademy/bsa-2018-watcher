using System;
using Microsoft.AspNetCore.SignalR;
using Watcher.Common.Enums;
using Watcher.Hubs;

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
    /// Controller to Manage Feedbacks
    /// </summary>
    // [Authorize]
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        /// <summary>
        /// The Role Service service
        /// </summary>
        private readonly IRoleService _roleService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RolesController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Role service
        /// </param>
        public RolesController(IRoleService service)
        {
            _roleService = service;
        }

        /// <summary>
        /// Get Roles
        /// </summary>
        /// <returns>
        /// List of Dtos of Roles
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Roles not found</response>
        /// <response code="403">You don`t have permission to create watch Roles</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<RoleDto>>> Get()
        {
            var dtos = await _roleService.GetAllEntitiesAsync();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        /// <summary>
        /// Get Role by id
        /// </summary>
        /// <param name="id">Role identifier</param>
        /// <returns>
        /// Dto of Role
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Role not found</response>
        /// <response code="403">You don`t have permission to create watch Role</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<RoleDto>> GetById(int id)
        {
            var dto = await _roleService.GetEntityByIdAsync(id);
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        /// <summary>
        /// Add new Role
        /// </summary>
        /// <param name="request">Role create request</param>
        /// <returns>
        /// Dto of Role
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Role not found</response>
        /// <response code="403">You don`t have permission to create Role</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPost]
        public virtual async Task<ActionResult<RoleDto>> Create([FromBody] RoleRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var dto = await _roleService.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }
           
            return CreatedAtAction("GetById", new { id = dto.Id }, dto);
        }
    }
}
