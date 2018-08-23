using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccumulator.DataAccessLayer.Entities;
using DataAccumulator.DataAccessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DataAccumulator.WebAPI.Controllers
{
    using DataAccumulator.Interfaces;

    [Route("api/v1/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IDataAccumulatorRepository<CollectedData> _repository;
        private readonly IServiceBusProvider _serviceBusProvider;

        public ValuesController(IDataAccumulatorRepository<CollectedData> repository,
                                IServiceBusProvider serviceBusProvider)
        {
            _repository = repository;
            _serviceBusProvider = serviceBusProvider;
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
                        ProcessesCount = 2,
                        CpuUsagePercent = 3,
                        RamUsagePercent = 4,
                        InterruptsTimePercent = 100,
                        LocalDiskFreeSpacePercent = 80,
                        AvaliableRamBytes = 60,
                        InterruptsPerSeconds = 10,
                        LocalDiskFreeMBytes = 90,
                        Time = DateTime.Now,
                        ProcessesCPU = new Dictionary<string, float>
                        {
                            { "ProcessesCPU1", 1 },
                            { "ProcessesCPU2", 2 }
                        },
                        ProcessesRAM = new Dictionary<string, float>
                        {
                            { "ProcessesRAM1", 1 },
                            { "ProcessesRAM2", 2 }
                        }
                    });

                    await _repository.AddEntity(new CollectedData()
                    {
                        Id = Guid.NewGuid(),
                        ClientId = new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),
                        ProcessesCount = 2,
                        CpuUsagePercent = 3,
                        RamUsagePercent = 4,
                        InterruptsTimePercent = 100,
                        LocalDiskFreeSpacePercent = 80,
                        AvaliableRamBytes = 60,
                        InterruptsPerSeconds = 10,
                        LocalDiskFreeMBytes = 90,
                        Time = DateTime.Now,
                        ProcessesCPU = new Dictionary<string, float>
                        {
                            { "ProcessesCPU1", 1 },
                            { "ProcessesCPU2", 2 }
                        },
                        ProcessesRAM = new Dictionary<string, float>
                        {
                            { "ProcessesRAM1", 1 },
                            { "ProcessesRAM2", 2 }
                        }
                    });

                    await _repository.AddEntity(new CollectedData()
                    {
                        Id = Guid.NewGuid(),
                        ClientId = new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),
                        ProcessesCount = 2,
                        CpuUsagePercent = 3,
                        RamUsagePercent = 4,
                        InterruptsTimePercent = 100,
                        LocalDiskFreeSpacePercent = 80,
                        AvaliableRamBytes = 60,
                        InterruptsPerSeconds = 10,
                        LocalDiskFreeMBytes = 90,
                        Time = DateTime.Now,
                        ProcessesCPU = new Dictionary<string, float>
                        {
                            { "ProcessesCPU1", 1 },
                            { "ProcessesCPU2", 2 }
                        },
                        ProcessesRAM = new Dictionary<string, float>
                        {
                            { "ProcessesRAM1", 1 },
                            { "ProcessesRAM2", 2 }
                        }
                    });

                    await _repository.AddEntity(new CollectedData()
                    {
                        Id = Guid.NewGuid(),
                        ClientId = new Guid("76053df4-6687-4353-8937-b45556748abe"),
                        ProcessesCount = 2,
                        CpuUsagePercent = 3,
                        RamUsagePercent = 4,
                        InterruptsTimePercent = 100,
                        LocalDiskFreeSpacePercent = 80,
                        AvaliableRamBytes = 60,
                        InterruptsPerSeconds = 10,
                        LocalDiskFreeMBytes = 90,
                        Time = DateTime.Now,
                        ProcessesCPU = new Dictionary<string, float>
                        {
                            { "ProcessesCPU1", 1 },
                            { "ProcessesCPU2", 2 }
                        },
                        ProcessesRAM = new Dictionary<string, float>
                        {
                            { "ProcessesRAM1", 1 },
                            { "ProcessesRAM2", 2 }
                        }
                    });

                    await _repository.AddEntity(new CollectedData()
                    {
                        Id = Guid.NewGuid(),
                        ClientId = new Guid("76053df4-6687-4353-8937-b45556748abe"),
                        ProcessesCount = 5,
                        CpuUsagePercent = 6,
                        RamUsagePercent = 9,
                        InterruptsTimePercent = 99,
                        LocalDiskFreeSpacePercent = 60,
                        AvaliableRamBytes = 60,
                        InterruptsPerSeconds = 10,
                        LocalDiskFreeMBytes = 90,
                        Time = DateTime.Now,
                        ProcessesCPU = new Dictionary<string, float>
                        {
                            { "ProcessesCPU21", 3 },
                            { "ProcessesCPU22", 4 }
                        },
                        ProcessesRAM = new Dictionary<string, float>
                        {
                            { "ProcessesRAM21", 3 },
                            { "ProcessesRAM22", 4 }
                        }
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

        [HttpGet("Bus")]
        public async Task<IActionResult> SendMessageToServiceBus([FromQuery] string message)
        {
            try
            {
                await _serviceBusProvider.SendMessageToServiceBus(message);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

            return Ok();
        }
    }
}
