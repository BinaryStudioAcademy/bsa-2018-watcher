namespace Watcher.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Watcher.Common.Dtos;
    using Watcher.Core.Interfaces;

    /// <summary>   
    /// Controller to Manage Feedbacks
    /// </summary>
    // [Authorize]
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class OrganizationRolesController : ControllerBase
    {
        /// <summary>
        /// The Role Service service
        /// </summary>
        private readonly IOrganizationRoleService _roleService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RolesController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Role service
        /// </param>
        public OrganizationRolesController(IOrganizationRoleService service)
        {
            _roleService = service;
        }

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
    }
}
