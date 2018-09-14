using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watcher.Common.Dtos;
using Watcher.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Watcher.Controllers
{
    [Route("[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ThemesController : ControllerBase
    {
        private readonly IThemeService _themeService;

        public ThemesController(IThemeService themeService)
        {
            _themeService = themeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThemeDto>>> GetAllThemes()
        {
            var dtos = await _themeService.GetAllEntitiesAsync();
            if(!dtos.Any())
            {
                return NoContent();
            }

            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var dto = await _themeService.GetById(id);

            if (dto == null)
            {
                return NotFound();
            }

            return Ok(dto);
        }
 

        [HttpPost]
        public async Task<ActionResult<ThemeDto>> CreateTheme([FromBody] ThemeDto themeDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _themeService.CreateEntityAsync(themeDto);
            if (dto == null)
            {
                return StatusCode(500);
            }

            return Ok(dto);
        }
    }
}