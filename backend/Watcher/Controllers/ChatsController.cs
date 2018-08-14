using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Watcher.Common.Dtos;
using Watcher.Common.Requests;
using Watcher.Core.Interfaces;

namespace Watcher.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ChatsController : Controller
    {
        private readonly IChatsService _chatsService;

        public ChatsController(IChatsService service)
        {
            _chatsService = service;
        }

        // GET: /chats
        [HttpGet()]
        public virtual async Task<ActionResult<IEnumerable<ChatDto>>> Get()
        {
            var dtos = await _chatsService.GetAllEntitiesAsync();
            if (!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        // GET: /chats/:id
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<ChatDto>> GetById(int id)
        {
            var dto = await _chatsService.GetEntityByIdAsync(id);
            if (dto == null)
            {
                return NoContent();
            }

            return Ok(dto);
        }

        // GET: /chats/user/:id
        [Route("chats/user/{id}")]
        public virtual async Task<ActionResult<ChatDto>> GetByUserId(int id)
        {
            var dto = await _chatsService.GetEntityByIdAsync(id);
            if (dto == null)
            {
                return NoContent();
            }

            return Ok(dto);
        }

        // POST: /chats
        [HttpPost]
        public virtual async Task<ActionResult<ChatDto>> Create([FromBody] ChatRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _chatsService.CreateEntityAsync(request);
            if (dto == null)
            {
                return StatusCode(500);
            }

            return CreatedAtAction("GetById", new { id = dto.Id }, dto);
        }

        // PUT: /chats/:id
        [HttpPut("{id}")]
        public virtual async Task<ActionResult> Update([FromRoute] int id, [FromBody] ChatUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _chatsService.UpdateEntityByIdAsync(request, id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }

        // DELETE: /chats/:id
        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> Delete(int id)
        {
            var result = await _chatsService.DeleteEntityByIdAsync(id);
            if (!result)
            {
                return StatusCode(500);
            }

            return NoContent();
        }
    }
}
