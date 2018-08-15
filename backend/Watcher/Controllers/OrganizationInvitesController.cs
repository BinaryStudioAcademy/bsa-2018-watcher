
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
        private readonly IOrganizationInvitesService _organizationInvitesService;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInvitesController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Organizations service
        /// </param>
        public OrganizationInvitesController(IOrganizationInvitesService service)
        {
            _organizationInvitesService = service;
        }
    }
}
