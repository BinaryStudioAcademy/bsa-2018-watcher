namespace Watcher.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using Watcher.Common.Enums;
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
    public class ResponsesController : ControllerBase
    {
        /// <summary>
        /// The Responses Service service
        /// </summary>
        private readonly IResponseService _responseService;
        private readonly INotificationService _notificationService;
        private readonly IEmailProvider _emailProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Responses service
        /// </param>
        /// <param name="provider"></param>
        public ResponsesController(IResponseService service, INotificationService notificationService, IEmailProvider provider)
        {
            _responseService = service;
            _notificationService = notificationService;
            _emailProvider = provider;
        }

        /// <summary>
        /// Get Responses
        /// </summary>
        /// <returns>
        /// List of Dtos of Responses
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Responses not found</response>
        /// <response code="403">You don`t have permission to create watch Responses</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<ResponseDto>>> Get()
        {
            var dtos = await _responseService.GetAllEntitiesAsync();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        /// <summary>
        /// Get Response by id
        /// </summary>
        /// <param name="id">Response identifier</param>
        /// <returns>
        /// Dto of Response
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Response not found</response>
        /// <response code="403">You don`t have permission to create watch Response</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<ResponseDto>> GetById(int id)
        {
            var dto = await _responseService.GetEntityByIdAsync(id);
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        /// <summary>
        /// Add new Response
        /// </summary>
        /// <param name="request">Response create request</param>
        /// <returns>
        /// Dto of Response
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Response not found</response>
        /// <response code="403">You don`t have permission to create Response</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPost]
        public virtual async Task<ActionResult<ResponseDto>> Create([FromBody] ResponseRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var dto = await _responseService.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }
            var userFeedback = request.Feedback.User;
            if(userFeedback!=null) {
                var notificationDto = new NotificationDto();
                notificationDto.CreatedAt = request.CreatedAt;
                notificationDto.Text = request.Text;
                notificationDto.UserId = userFeedback.Id;
                notificationDto.OrganizationId = userFeedback.LastPickedOrganizationId;
                await _notificationService.CreateEntityAsync(notificationDto, NotificationType.Info);
            }
            else
            {
                await _emailProvider.SendMessageOneToOne("watcher@net.com", "Thanks for feedback", request.Feedback.Email,
                    request.Text, "");
            }
            return CreatedAtAction("GetById", new { id = dto.Id }, dto);
        }
    }
}
