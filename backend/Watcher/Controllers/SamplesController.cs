using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace Watcher.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Watcher.Common.Dtos;
    using Watcher.Common.Requests;
    using Watcher.Core.Interfaces;

    [Route("api/[controller]")]
    [ApiController]
    public class SamplesController : ControllerBase
    {
        private readonly ISamplesService _samplesService;

        protected SamplesController(ISamplesService service)
        {
            _samplesService = service;
        }

        // GET: api/Samples
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<SampleDto>>> Get()
        {
            var dtos = await _samplesService.GetAllEntitiesAsync();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        // GET: api/Samples/5
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<SampleDto>> GetById(int id)
        {
            var dto = await _samplesService.GetEntityByIdAsync(id);
            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        // POST: api/Samples
        [HttpPost]
        public virtual async Task<ActionResult<SampleDto>> Create([FromBody] SampleRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _samplesService.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }

            return CreatedAtAction("GetById", new { id = dto.Id }, dto);
        }

        // PUT: api/Samples/5
        [HttpPut("{id}")]
        public virtual async Task<ActionResult<SampleDto>> Update([FromRoute] int id, [FromBody] SampleRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _samplesService.UpdateEntityByIdAsync(request, id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }

        // DELETE: api/Samples/5
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await _samplesService.DeleteEntityByIdAsync(id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }
    }
}
