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
    /// Controller to Manage Samples
    /// </summary>
    // [Authorize]
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ChartsController : ControllerBase
    {
        /// <summary>
        /// The Charts Service
        /// </summary>
        private readonly IChartsService _chartsService;
       
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartsController"/> class. 
        /// </summary>
        /// <param name="service">
        /// Samples service
        /// </param>
        public ChartsController(IChartsService service)
        {
            _chartsService = service;
        }

        /// <summary>
        /// Get Charts
        /// </summary>
        /// <returns>
        /// List of Dtos of Charts
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Charts not found</response>
        /// <response code="403">You don`t have permission to create watch Charts</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet]
        [AllowAnonymous]
        public virtual async Task<ActionResult<IEnumerable<ChartDto>>> Get()
        {
            var dtos = await _chartsService.GetAllEntitiesAsync();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        /// <summary>
        /// Get Chart by id
        /// </summary>
        /// <param name="id">Chart identifier</param>
        /// <returns>
        /// Dto of Chart
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Chart not found</response>
        /// <response code="403">You don`t have permission to create watch Chart</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public virtual async Task<ActionResult<ChartDto>> GetById(int id)
        {
            var dto = await _chartsService.GetEntityByIdAsync(id);
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        /// <summary>
        /// Add new Chart
        /// </summary>
        /// <param name="request">Chart create request</param>
        /// <returns>
        /// Dto of Chart
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Chart not found</response>
        /// <response code="403">You don`t have permission to create Chart</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPost]
        public virtual async Task<ActionResult<ChartDto>> Create([FromBody] ChartRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _chartsService.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }
            
            return CreatedAtAction("GetById", new { id = dto.Id }, dto);
        }

        /// <summary>
        /// Update Chart
        /// </summary>
        /// <param name="id">Chart identifier</param>
        /// <param name="request">Chart update request</param>
        /// <returns>
        /// Action Result
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Chart not found</response>
        /// <response code="403">You don`t have permission to update Chart</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update([FromRoute] int id, [FromBody] ChartRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _chartsService.UpdateEntityByIdAsync(request, id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }

        /// <summary>
        /// Delete Chart
        /// </summary>
        /// <param name="id">Sample identifier</param>
        /// <returns>
        /// Action Result
        /// </returns>
        /// <response code="500">Internal error on server</response>
        /// <response code="404">Chart not found</response>
        /// <response code="403">You don`t have permission to delete Chart</response>
        /// <response code="400">Model is not valid</response>
        /// <response code="200">Success</response>
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(int id)
        {
            var result = await _chartsService.DeleteEntityByIdAsync(id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }
    }
}
