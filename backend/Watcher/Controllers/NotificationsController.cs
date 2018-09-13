namespace Watcher.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DataAccumulator.Shared.Models;

    using Microsoft.AspNetCore.Mvc;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
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

            return Ok(dtos);
        }

        /// <summary>
        /// Add new notification
        /// </summary>
        /// <param name="request">Notification create request</param>
        /// <returns>
        /// Dto of Notification
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPost]
        public virtual async Task<ActionResult<NotificationDto>> Create([FromBody] NotificationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dtos = await _notificationService.CreateEntityAsync(request);
            if (dtos == null)
            {
                return StatusCode(500);
            }

            return Ok(dtos);
        }

        [HttpPost("Report")]
        public virtual async Task<ActionResult<NotificationDto>> CreateReport([FromBody] NotificationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
            //var report = new AzureMLAnomalyReport
            //    {
            //        Date = DateTime.UtcNow,
            //        AnomalyGroups = new List<AzureMLAnomalyGroup>(),
            //        CollectedDataTypeOfReport = CollectedDataType.AggregationForHour
            //    };

            //var dtos = await _notificationService.CreateAnomalyReportNotificationAsync(request, report);
            //if (dtos == null)
            //{
            //    return StatusCode(500);
            //}

            //return Ok(dtos);
        }

        /// <summary>
        /// Add new notification for everyone user
        /// </summary>
        /// <param name="request">Notification create request</param>
        /// <returns>
        /// Dto of Notifications
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPost("everyone")]
        public virtual async Task<ActionResult<NotificationDto>> CreateForAll([FromBody] NotificationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dtos = await _notificationService.CreateEntityForAllAsync(request);
            if (dtos == null)
            {
                return StatusCode(500);
            }

            return Ok(dtos);
        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update([FromRoute] int id, [FromBody] NotificationUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _notificationService.UpdateEntityByIdAsync(request, id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }

        [HttpPut(Name = "UpdateManyNotifications")]
        public virtual async Task<ActionResult> Update([FromBody] IEnumerable<NotificationUpdateRequest> requests)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _notificationService.UpdateEntitiesAsync(requests);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }


        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var result = await _notificationService.DeleteEntityByIdAsync(id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }
    }
}
