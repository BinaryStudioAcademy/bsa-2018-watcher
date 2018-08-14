using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace Watcher.Controllers
{
    using System.Net;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.Extensions.Logging;

    using Serilog;

    using Watcher.Common.Errors;

    [Route("[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly ILogger<DefaultController> _logger;
        public DefaultController(ILogger<DefaultController> logger)
        {
            _logger = logger;
        }

        // [WatcherAuthorize("Admin")]
        [Authorize(Roles = "User")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var a = User;
            return new string[] { "value1", "value2" };
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("Admin")]
        public string Getdmin(int id)
        {
            var a = User;
            return "value";
        }
        
        [HttpGet("Get")]
        public string Get(int id)
        {
            throw new HttpStatusCodeException(HttpStatusCode.BadRequest, "Qwewtreter");
        }

        [HttpGet("LogScopes")]
        public IEnumerable<string> LogInfo()
        {
            _logger.LogInformation("Before");

            using (_logger.BeginScope("Some name"))
            using (_logger.BeginScope(42))
            using (_logger.BeginScope("Formatted {WithValue}", 12345))
            using (_logger.BeginScope(new Dictionary<string, object> { ["ViaDictionary"] = 100 }))
            {
                _logger.LogInformation("Hello from the Index!");
                _logger.LogDebug("Hello is done");
            }

            _logger.LogInformation("After");

            return new[] { "value1", "value2" };
        }

        [HttpGet("LogStatic")]
        public IEnumerable<string> LogStatic()
        {
            // Directly through Serilog
            Log.Information("This is a handler for {Path}", Request.Path);

            return new[] { "value1", "value2" };
        }

        [HttpGet("AllInOrder")]
        public IEnumerable<string> LogAllInOrder()
        {
            var bgubE = new EventId(100, "Debug Event 1");
            var intoE = new EventId(200, "Information Event 1");
            var warnE = new EventId(300, "Warning Event 1");
            var errE = new EventId(400, "Error Event 1");
            var critE = new EventId(500, "Crit Event 1");


            _logger.LogDebug(bgubE, "Debug");
            _logger.LogInformation(intoE, "Information");
            _logger.LogWarning(warnE, "Warning");
            _logger.LogError(errE, "Error");
            _logger.LogCritical(critE, "Crit");

            return new[] { "value1", "value2" };
        }
    }
}
