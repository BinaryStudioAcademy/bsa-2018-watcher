using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;
using Watcher.Core.Interfaces;

namespace Watcher.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class MessagesController : Controller
    {
        private readonly IMessagesService _messagesService;

        public MessagesController(IMessagesService service)
        {
            _messagesService = service;
        }

        // GET: /messages
        [HttpGet()]
        public virtual async Task<ActionResult<IEnumerable<MessageDto>>> Get()
        {
            var dtos = await _messagesService.GetAllEntitiesAsync();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        // GET: /messages/:id
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<ChatDto>> GetById(int id)
        {
            var dto = await _messagesService.GetEntityByIdAsync(id);
            if (dto == null)
            {
                return NoContent();
            }

            return Ok(dto);
        }

        // POST: /messages
        [HttpPost]
        public virtual async Task<ActionResult<ChatDto>> Create([FromBody] MessageRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _messagesService.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }

            return CreatedAtAction("GetById", new { id = dto.Id }, dto);
        }

        // PUT: /messages/:id
        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update([FromRoute] int id, [FromBody] MessageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _messagesService.UpdateEntityByIdAsync(request, id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }

        // DELETE: /messages/:id
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(int id)
        {
            var result = await _messagesService.DeleteEntityByIdAsync(id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }
    }
}
