using DataAccumulator.BusinessLayer.Interfaces;
using DataAccumulator.Shared.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Serilog.Context;
using System;
using System.Threading.Tasks;

namespace DataAccumulator.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/dataaccumulator/log")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> _logger;
        private readonly ILogService _service;

        public LogController(ILogger<LogController> logger, ILogService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public async Task SaveActionLog([FromBody] ActionLogDto actionLogDto)
        {
            try
            {
                await _service.SaveActionLog(actionLogDto);
            }
            catch (Exception e)
            {
                LogError(e);
                Console.WriteLine(e);
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