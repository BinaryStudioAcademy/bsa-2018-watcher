using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using DataAccumulator.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace DataAccumulator.WebAPI.Controllers
{
    using System.Diagnostics;

    using DataAccumulator.BusinessLayer.Interfaces;

    using Microsoft.Extensions.Logging;

    [Route("api/v1/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;
        private readonly IDataAccumulatorRepository<CollectedData> _repository;

        public ValuesController(ILogger<ValuesController> logger, 
                                IDataAccumulatorRepository<CollectedData> repository,
                                IServiceBusProvider serviceBusProvider)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("AllInOrder")]
        public IEnumerable<string> LogAllInOrder()
        {
            Debug.WriteLine("*************************************************************VALUES**********************************************");
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

        // Call an initialization - GET api/v1/values/init
        [HttpGet("{setting}")]
        public async Task<IActionResult> Get(string setting)
        {
            try
            {
                if (setting == "init")
                {
                    await _repository.RemoveAllEntities();
                    var name = _repository.CreateIndex();

                    await _repository.AddEntity(new CollectedData()
                    {
                        Id = Guid.NewGuid(),
                        ClientId = new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),

                        CollectedDataType = CollectedDataType.Accumulation,

                        ProcessesCount = 2,
                        Processes = new List<ProcessData>()
                        {
                            new ProcessData()
                            {
                                Name = "chrome",
                                RamMBytes = 20,
                                PRam = 5,
                                PCpu = 7
                            },
                            new ProcessData()
                            {
                                Name = "ie",
                                RamMBytes = 10,
                                PRam = 3,
                                PCpu = 5
                            },
                        },

                        UsageRamMBytes = 18,
                        TotalRamMBytes = 20,
                        RamUsagePercentage = 20,

                        InterruptsPerSeconds = 80,

                        LocalDiskUsageMBytes = 80,
                        LocalDiskTotalMBytes = 10,
                        LocalDiskUsagePercentage = 20,

                        CpuUsagePercentage = 10,

                        Time = DateTime.Now
                    });

                    await _repository.AddEntity(new CollectedData()
                    {
                        Id = Guid.NewGuid(),
                        ClientId = new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),

                        CollectedDataType = CollectedDataType.Accumulation,

                        ProcessesCount = 2,
                        Processes = new List<ProcessData>()
                        {
                            new ProcessData()
                            {
                                Name = "chrome",
                                RamMBytes = 20,
                                PRam = 5,
                                PCpu = 7
                            },
                            new ProcessData()
                            {
                                Name = "ie",
                                RamMBytes = 10,
                                PRam = 3,
                                PCpu = 5
                            },
                        },

                        UsageRamMBytes = 18,
                        TotalRamMBytes = 20,
                        RamUsagePercentage = 20,

                        InterruptsPerSeconds = 80,

                        LocalDiskUsageMBytes = 80,
                        LocalDiskTotalMBytes = 10,
                        LocalDiskUsagePercentage = 20,

                        CpuUsagePercentage = 10,

                        Time = DateTime.Now
                    });

                    await _repository.AddEntity(new CollectedData()
                    {
                        Id = Guid.NewGuid(),
                        ClientId = new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),

                        CollectedDataType = CollectedDataType.Accumulation,

                        ProcessesCount = 2,
                        Processes = new List<ProcessData>()
                        {
                            new ProcessData()
                            {
                                Name = "chrome",
                                RamMBytes = 20,
                                PRam = 5,
                                PCpu = 7
                            },
                            new ProcessData()
                            {
                                Name = "ie",
                                RamMBytes = 10,
                                PRam = 3,
                                PCpu = 5
                            },
                        },

                        UsageRamMBytes = 33,
                        TotalRamMBytes = 20,
                        RamUsagePercentage = 20,

                        InterruptsPerSeconds = 80,

                        LocalDiskUsageMBytes = 80,
                        LocalDiskTotalMBytes = 10,
                        LocalDiskUsagePercentage = 20,

                        CpuUsagePercentage = 10,

                        Time = DateTime.Now
                    });

                    await _repository.AddEntity(new CollectedData()
                    {
                        Id = Guid.NewGuid(),
                        ClientId = new Guid("76053df4-6687-4353-8937-b45556748abe"),

                        CollectedDataType = CollectedDataType.Accumulation,

                        ProcessesCount = 2,
                        Processes = new List<ProcessData>()
                        {
                            new ProcessData()
                            {
                                Name = "chrome",
                                RamMBytes = 20,
                                PRam = 5,
                                PCpu = 7
                            },
                            new ProcessData()
                            {
                                Name = "ie",
                                RamMBytes = 10,
                                PRam = 3,
                                PCpu = 5
                            },
                        },

                        UsageRamMBytes = 18,
                        TotalRamMBytes = 20,
                        RamUsagePercentage = 20,

                        InterruptsPerSeconds = 80,

                        LocalDiskUsageMBytes = 80,
                        LocalDiskTotalMBytes = 10,
                        LocalDiskUsagePercentage = 20,

                        CpuUsagePercentage = 10,

                        Time = DateTime.Now
                    });

                    await _repository.AddEntity(new CollectedData()
                    {
                        Id = Guid.NewGuid(),
                        ClientId = new Guid("76053df4-6687-4353-8937-b45556748abe"),

                        CollectedDataType = CollectedDataType.Accumulation,

                        ProcessesCount = 2,
                        Processes = new List<ProcessData>()
                        {
                            new ProcessData()
                            {
                                Name = "chrome",
                                RamMBytes = 20,
                                PRam = 5,
                                PCpu = 7
                            },
                            new ProcessData()
                            {
                                Name = "ie",
                                RamMBytes = 10,
                                PRam = 3,
                                PCpu = 5
                            },
                        },

                        UsageRamMBytes = 18,
                        TotalRamMBytes = 20,
                        RamUsagePercentage = 20,

                        InterruptsPerSeconds = 80,

                        LocalDiskUsageMBytes = 80,
                        LocalDiskTotalMBytes = 10,
                        LocalDiskUsagePercentage = 20,

                        CpuUsagePercentage = 10,

                        Time = DateTime.Now
                    });

                    return Ok("Database DataAccumulator was created, and collection 'CollectedData' was filled with 5 sample items");
                }

                return BadRequest();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500);
            }
        }
    }
}
