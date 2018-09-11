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
    public class FeedbacksController : ControllerBase
    {
        /// <summary>
        /// The Feedbacks Service service
        /// </summary>
        private readonly IFeedbackService _feedbackService;
        private readonly IEmailProvider _emailProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbacksController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Feedbacks service
        /// </param>
        public FeedbacksController(IFeedbackService service, IEmailProvider provider)
        {
            _feedbackService = service;
            _emailProvider = provider;
        }

        /// <summary>
        /// Get Feedbacks
        /// </summary>
        /// <returns>
        /// List of Dtos of Feedbacks
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Feedbacks not found</response>
        /// <response code="403">You don`t have permission to create watch Feedbacks</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<FeedbackDto>>> Get()
        {
            var dtos = await _feedbackService.GetAllEntitiesAsync();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        /// <summary>
        /// Get range of Feedbacks for pagination
        /// </summary>
        /// <returns>
        /// List of Dtos of Feedbacks
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Organizations not found</response>
        /// <response code="403">You don`t have permission to create watch Organizations</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("table")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<FeedbackDto>>> GetRange(int page, int pageSize)
        {
            var dtos = await _feedbackService.GetRangeOfEntitiesAsync(page, pageSize);
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        /// <summary>
        /// Get number of Feedbacks
        /// </summary>
        /// <returns>
        /// Number of Feedbacks
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Organizations not found</response>
        /// <response code="403">You don`t have permission to create watch Organizations</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("number")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<OrganizationDto>>> GetNumberOfOrganizations()
        {
            var dtos = await _feedbackService.GetNumberOfEntitiesAsync();
            if (dtos < 0)
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        /// <summary>
        /// Get Feedback by id
        /// </summary>
        /// <param name="id">Feedback identifier</param>
        /// <returns>
        /// Dto of Feedback
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Feedbacks not found</response>
        /// <response code="403">You don`t have permission to create watch Feedback</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<FeedbackDto>> GetById(int id)
        {
            var dto = await _feedbackService.GetEntityByIdAsync(id);
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        /// <summary>
        /// Add new Feedback
        /// </summary>
        /// <param name="request">Feedback create request</param>
        /// <returns>
        /// Dto of Feedback
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Feedback not found</response>
        /// <response code="403">You don`t have permission to create Feedback</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPost]
        public virtual async Task<ActionResult<FeedbackDto>> Create([FromBody] FeedbackRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var dto = await _feedbackService.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }
            
            if (!string.IsNullOrEmpty(request.User.Email))
            {
                await _emailProvider.SendMessageOneToOne("watcher@net.com", "Thanks for feedback", request.User.Email,
                    "Hello, " + request.User.DisplayName +
                    ". Thank you for taking the time to type feedback. " +
                    "Best regards, Watcher.", "");
            }
            
            return CreatedAtAction("GetById", new { id = dto.Id }, dto);
        }
    }
}
