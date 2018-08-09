using Microsoft.AspNetCore.Mvc;

namespace Watcher.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;

    [Route("api/[controller]")]
    [ApiController]
    public class NotificationSettingsController : ControllerBase
    {  
        /// <summary>
       /// The service
       /// </summary>
        private readonly INotificationSettingsService _service;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SamplesController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Samples service
        /// </param>
        public NotificationSettingsController(INotificationSettingsService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get Sample by id
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
        public virtual async Task<ActionResult<IEnumerable<NotificationSettingDto>>> GetByUserId(string userId)
        {
            var dto = await _service.GetEntitysByUserIdAsync(userId);
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        [HttpPost]
        public virtual async Task<ActionResult<SampleDto>> Create([FromBody] NotificationSettingRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _service.CreateEntityAsync(request, "Qwerty");
            if (dto == null)
            {
                return StatusCode(500);
            }
            
            return Ok(dto);
        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update([FromRoute] int id, [FromBody] NotificationSettingRequest request)
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
            var result = await _service.GetEntitysByUserIdAsync("Qwerty");

            return Ok(result);
        }
    }
}