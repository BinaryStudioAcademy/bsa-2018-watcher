namespace Watcher.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;

    using Microsoft.AspNetCore.SignalR;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    using Watcher.Common.Dtos;
    using Watcher.Core.Interfaces;
    using Watcher.Hubs;
    using Watcher.Utils;

    public class WatcherService : BackgroundService
    {
        /// <summary>
        /// The Notifications Hub context.
        /// </summary>
        private readonly IHubContext<NotificationsHub> _hubContext;

        /// <summary>
        /// The Transient Service.
        /// </summary>
        private readonly ITransientService _service;

        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILogger<WatcherService> _logger;

        /// <summary>
        /// Configurations for watcher service
        /// </summary>
        private readonly IOptions<TimeServiceConfiguration> _options;

        /// <summary>
        /// The Service Scope Factory 
        /// </summary>
        private readonly IServiceScopeFactory _scopeFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="WatcherService"/> class.
        /// </summary>
        /// <param name="hubContext">
        /// The hub Context.
        /// </param>
        /// <param name="service">
        /// The Transient Service.
        /// </param>
        /// <param name="logger">
        /// The logger.
        /// </param>
        /// <param name="options">
        /// Options
        /// </param>
        /// <param name="scopeFactory"></param>
        public WatcherService(IHubContext<NotificationsHub> hubContext, 
                              ITransientService service, 
                              ILogger<WatcherService> logger,
                              IOptions<TimeServiceConfiguration> options,
                              IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
            _hubContext = hubContext;
            _service = service;
            _logger = logger;
            _options = options;
        }



        /// <summary>
        /// This method is called when the <see cref="T:Microsoft.Extensions.Hosting.IHostedService" /> starts. The implementation should return a task that represents
        /// the lifetime of the long running operation(s) being performed.
        /// </summary>
        /// <param name="stoppingToken">
        /// Triggered when <see cref="M:Microsoft.Extensions.Hosting.IHostedService.StopAsync(System.Threading.CancellationToken)" /> is called.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Threading.Tasks.Task" /> that represents the long running operations.
        /// </returns>
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Watcher Service Start working!");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using (var scope = _scopeFactory.CreateScope())
                    {
                        var repo = scope.ServiceProvider.GetRequiredService<IDataAccumulatorRepository<CollectedData>>();
                        var data = new CollectedData
                                       {
                                           Id = Guid.NewGuid(),
                                           AvaliableRamBytes = 2505.33325195312f,
                                           CpuUsagePercent = 69.68777465820312f,
                                           InterruptsPerSeconds = 24424.375f,
                                           InterruptsTimePercent = 24426.060546875f,
                                           LocalDiskFreeMBytes = 883704,
                                           ProcessesCount = 123,
                                           Time = DateTime.UtcNow,
                                           LocalDiskFreeSpacePercent = 79.61161041259766f,
                                           ProcessesCPU = new Dictionary<string, float>
                                                              {
                                                                  {"Idle", 121.80587005615234f },
                                                                  {"121.80587005615234", 8.40002727508545f },
                                                                  {"lsass", 2.516136407852173f },
                                                                  {"NotePad", 80.80587005615234f },
                                                                  {"VS Code", 220.80587005615234f }
                                                              },
                                           ProcessesRAM = new Dictionary<string, float>
                                                              {
                                                                  {"Idle", 57.23391342163086f },
                                                                  {"System", 1813.6470947265625f },
                                                                  {"Secure System", 25586.666015625f },
                                                                  { "Registry", 9269.3330078125f },
                                                                  { "NotePad", 3269.3330078125f }
                                                              },
                                           RamUsagePercent = 76.6187973022461f
                                       };
                        await repo.AddEntity(data);
                    }
                    
                    MarketPrice.UpdateMarket();
                    var mp = MarketPrice.MarketPositions[0];
                     // await _hubContext.Clients.Group("Market Data Feed").SendAsync("MarketTick", mp);
                    // var sample = await _service.GenerateRandomSampleDtoAsync();

                    // _logger.LogInformation($"Sending generated sample id: {sample.Id}.");

                    // Method Name on Angular Client: "DataFeedTick",
                    // Single argument of that method is SampleDto
                    await _hubContext.Clients.All.SendAsync("MarketTick", mp, cancellationToken: stoppingToken);
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                }

                // Repeat this message feed every period seconds
                // await Task.Delay(TimeSpan.FromMilliseconds(_options.Value.Period), stoppingToken);
                await Task.Delay(5000, stoppingToken);
            }

            _logger.LogError("Watcher Service stopped! Unexpected error occurred!");
        }
    }
}
