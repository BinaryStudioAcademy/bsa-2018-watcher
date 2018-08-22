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

    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// The Users Service service
        /// </summary>
        private readonly IUsersService _usersService;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Users service
        /// </param>
        public UsersController(IUsersService service)
        {
            _usersService = service;
        }
        /// <summary>
        /// Get Users
        /// </summary>
        /// <returns>
        /// List of Dtos of Users
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Users not found</response>
        /// <response code="403">You don`t have permission to create watch User</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<UserDto>>> Get()
        {
            var dtos = await _usersService.GetAllEntitiesAsync();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        /// <summary>
        /// Find Users by display name, first name, last name or email
        /// </summary>
        /// <returns>
        /// List of Dtos of Users
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Users not found</response>
        /// <response code="403">You don`t have permission to create watch Users</response>
        /// <response code="200">Success</response>
        [HttpGet("find/{query}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<UserDto>>> Find(string query)
        {
            var dtos = await _usersService.FindEntitiesAsync(query);
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        /// <summary>
        /// Get User by id
        /// </summary>
        /// <param name="id">User identifier</param>
        /// <returns>
        /// Dto of User
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">User not found</response>
        /// <response code="403">You don`t have permission to create watch User</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<UserDto>> GetById(string id)
        {
            var dto = await _usersService.GetEntityByIdAsync(id);
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        /// <summary>
        /// Add new User
        /// </summary>
        /// <param name="request">User create request</param>
        /// <returns>
        /// Dto of User
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">User not found</response>
        /// <response code="403">You don`t have permission to create User</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPost]
        public virtual async Task<ActionResult<UserDto>> Create([FromBody] UserRegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _usersService.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }

            return CreatedAtAction("GetById", new { id = dto.Id }, dto);
        }

        /// <summary>
        /// Temporary realization of Login method
        /// </summary>
        /// <param name="firebaseUserDto">User create request</param>
        /// <returns>
        /// Parameter
        /// </returns>
        [Authorize]
        [Route("login")]
        [HttpPost]
        public virtual async Task<ActionResult<FirebaseUserDto>> Login([FromBody] FirebaseUserDto firebaseUserDto)
        {
            return Ok(firebaseUserDto);
        }

        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="id">User identifier</param>
        /// <param name="request">User update request</param>
        /// <returns>
        /// Action Result
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">User not found</response>
        /// <response code="403">You don`t have permission to update User</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update([FromRoute] string id, [FromBody] UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _usersService.UpdateEntityByIdAsync(request, id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="id">User identifier</param>
        /// <returns>
        /// Action Result
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">User not found</response>
        /// <response code="403">You don`t have permission to delete User</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(string id)
        {
            var result = await _usersService.DeleteEntityByIdAsync(id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }


        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="userId">User identifier</param>
        /// <param name="organizationId">User update request</param>
        /// <returns>
        /// Action Result
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">User not found</response>
        /// <response code="403">You don`t have permission to update User</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPut("UpdateLastPickedOrganization/{userId}/{organizationId}")]
        public virtual async Task<ActionResult> UpdateLastPickedOrganization([FromRoute] string userId, [FromRoute] int organizationId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _usersService.UpdateLastPickedOrganizationAsync(userId, organizationId);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }
    }
}