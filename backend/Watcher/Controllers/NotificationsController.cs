

namespace Watcher.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.Internal;

    using Watcher.Common.Dtos;
    using Watcher.Core.Interfaces;

    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class NotificationsController : Controller
    {
        private readonly INotificationService _notificationService;

        public NotificationsController(INotificationService service)
        {
            _notificationService = service;
        }

        /// <summary>
        /// Get Notifications by User id
        /// </summary>
        /// <param name="userId">Sample identifier</param>
        /// <returns>
        /// Dto of Sample
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Samples not found</response>
        /// <response code="403">You don`t have permission to create watch Sample</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet("{userId}")]
        public virtual async Task<ActionResult<IEnumerable<NotificationDto>>> GetEntitiesByUserId(string userId)
        {
            var dtos = await _notificationService.GetEntitiesByUserIdAsync(userId);
            if (!dtos.Any())
            {
                return NotFound();
            }

            return Ok(dtos);
        }
    }
}
