using System;
using System.Threading.Tasks;
using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.Shared.Exceptions;
using DataAccumulator.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataAccumulator.WebAPI.Controllers
{
    using Microsoft.Extensions.Logging;

    using Serilog.Context;

    [Produces("application/json")]
    [Route("api/v1/dataaggregator")]
    public class DataAggregatorController : ControllerBase
    {
        private readonly ILogger<DataAggregatorController> _logger;
        private readonly IDataAggregatorService<CollectedDataDto> _dataAggregatorService;

        public DataAggregatorController(ILogger<DataAggregatorController> logger,
                                        IDataAggregatorService<CollectedDataDto> dataAggregatorService)
        {
            _logger = logger;
            _dataAggregatorService = dataAggregatorService;
        }

        // GET: api/v1/dataaccumulator
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var collectedDataDtos = await _dataAggregatorService.GetEntitiesAsync();
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
                LogError(e);
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        // GET: api/v1/dataaccumulator/5
        [HttpGet("{id}", Name = "GetDataAggregator")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var collectedDataDto = await _dataAggregatorService.GetEntityAsync(id);
                return Ok(collectedDataDto);
            }
            catch (NotFoundException e)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                LogError(e);
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
                var collectedData = await _dataAggregatorService.AddEntityAsync(collectedDataDto);
                return CreatedAtRoute("GetDataAggregator", new { id = collectedDataDto.Id }, collectedData);
            }
            catch (Exception e)
            {
                LogError(e);
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
                await _dataAggregatorService.UpdateEntityAsync(collectedDataDto);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                LogError(e);
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
                await _dataAggregatorService.DeleteEntityAsync(id);
                return NoContent();
            }
            catch (NotFoundException e)
            {
                return NotFound();
            }
            catch (Exception e)
            {
                LogError(e);
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }

        private void LogError(Exception ex)
        {
            var eventId = new EventId(500, "An unhandled exception");
            using (LogContext.PushProperty("LogEventId", eventId.Id))
            {
                _logger.LogError(eventId, ex, "An unhandled exception has occurred: " + ex.Message);
            }
        }
    }
}
