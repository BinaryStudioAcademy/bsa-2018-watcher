using System;
using System.Threading.Tasks;
using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.Shared.Exceptions;
using DataAccumulator.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataAccumulator.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/dataaccumulator")]
    public class DataAccumulatorController : Controller
    {
        private readonly IDataAccumulatorService<CollectedDataDto> _dataAccumulatorService;

        public DataAccumulatorController(IDataAccumulatorService<CollectedDataDto> dataAccumulatorService)
        {
            _dataAccumulatorService = dataAccumulatorService;
        }

        // GET: api/v1/dataaccumulator
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var collectedDataDtos = await _dataAccumulatorService.GetEntitiesAsync();
                return Ok(collectedDataDtos);
            }
            catch (BadRequestException e)
            {
                return BadRequest();
            }
            catch (NotFoundException e)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        // GET: api/v1/dataaccumulator/5
        [HttpGet("{id}", Name = "GetDataAccumulator")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var collectedDataDto = await _dataAccumulatorService.GetEntityAsync(id);
                return Ok(collectedDataDto);
            }
            catch (NotFoundException e)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        // POST: api/v1/dataaccumulator
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CollectedDataDto collectedDataDto)
        {
            try
            {
                var collectedData = await _dataAccumulatorService.AddEntityAsync(collectedDataDto);
                return CreatedAtRoute("GetDataAccumulator", new { id = 213 }, collectedData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        // POST: api/v1/dataaccumulator
        [HttpPost("TestCreation")]
        public async Task<IActionResult> TestPost()
        {
            try
            {
                var collectedData = await _dataAccumulatorService.AddEntityAsync();
                return CreatedAtRoute("GetDataAccumulator", new { id = 213 }, collectedData);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        // PUT: api/v1/dataaccumulator/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody]CollectedDataDto collectedDataDto)
        {
            try
            {
                collectedDataDto.Id = id;
                await _dataAccumulatorService.UpdateEntityAsync(collectedDataDto);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        // DELETE: api/v1/dataaccumulator/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _dataAccumulatorService.DeleteEntityAsync(id);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }
    }
}
