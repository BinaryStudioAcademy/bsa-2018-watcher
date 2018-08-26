﻿using System;
using System.Threading.Tasks;
using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.Shared.Exceptions;
using DataAccumulator.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataAccumulator.WebAPI.Controllers
{
    using Microsoft.Extensions.Logging;

    using Serilog.Context;

    using ServiceBus.Shared.Messages;

    [Produces("application/json")]
    [Route("api/v1/dataaccumulator")]
    public class DataAccumulatorController : ControllerBase
    {
        private readonly ILogger<DataAccumulatorController> _logger;
        private readonly IDataAccumulatorService<CollectedDataDto> _dataAccumulatorService;
        private readonly IServiceBusProvider _serviceBusProvider;

        public DataAccumulatorController(ILogger<DataAccumulatorController> logger,
                                         IDataAccumulatorService<CollectedDataDto> dataAccumulatorService,
                                         IServiceBusProvider serviceBusProvider)
        {
            _logger = logger;
            _dataAccumulatorService = dataAccumulatorService;
            _serviceBusProvider = serviceBusProvider;
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
                LogError(e);
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
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
                LogError(e);
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
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
                LogError(e);
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

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
                LogError(e);
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost("TestError")]
        public async Task<IActionResult> TestError()
        {
            var mess = new InstanceErrorMessage("Error Message from Accummulator", Guid.Parse("7dafb96f-46f3-48c4-9e97-787ec268136a"));
            await _serviceBusProvider.SendErrorMessage(mess);

            return Ok();
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
                LogError(e);
                return StatusCode(500, e.Message);
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
                LogError(e);
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
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
