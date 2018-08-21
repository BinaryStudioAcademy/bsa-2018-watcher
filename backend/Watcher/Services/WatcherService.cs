﻿namespace Watcher.Services
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using AutoMapper;

    using DataAccumulator.DataAccessLayer.Entities;
    using DataAccumulator.DataAccessLayer.Interfaces;

    using Microsoft.AspNetCore.SignalR;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    using Watcher.Common.Dtos;
    using Watcher.Common.Dtos.Plots;
    using Watcher.Core.Hubs;
    using Watcher.Core.Interfaces;
    using Watcher.Core.Services;
    using Watcher.Hubs;
    using Watcher.Utils;

    public class WatcherService : BackgroundService
    {
        private readonly IHubContext<DashboardsHub> _hubContext;
        private readonly ITransientService _service;
        private readonly ILogger<WatcherService> _logger;
        private readonly IOptions<TimeServiceConfiguration> _options;
        private readonly IServiceScopeFactory _scopeFactory;
        private readonly IServiceBusProvider _serviceBusProvider;

        public WatcherService(IHubContext<DashboardsHub> hubContext, 
                              ITransientService service, 
                              ILogger<WatcherService> logger,
                              IOptions<TimeServiceConfiguration> options,
                              IServiceScopeFactory scopeFactory,
                              IServiceBusProvider serviceBusProvider)
        {
            _scopeFactory = scopeFactory;
            _hubContext = hubContext;
            _service = service;
            _logger = logger;
            _options = options;
            _serviceBusProvider = serviceBusProvider;
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
                    foreach (var id in _serviceBusProvider.SubscribedIncstancesIds)
                    {
                        await SS(id, stoppingToken);
                    }
                    // await _hubContext.Clients.Group("Market Data Feed").SendAsync("MarketTick", mp);

                    // var sample = await _service.GenerateRandomSampleDtoAsync();

                    // _logger.LogInformation($"Sending generated sample id: {sample.Id}.");

                    // Method Name on Angular Client: "DataFeedTick",
                    // Single argument of that method is SampleDto
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                }

                // Repeat this message feed every period seconds
                // await Task.Delay(TimeSpan.FromMilliseconds(_options.Value.Period), stoppingToken);
                await Task.Delay(10000, stoppingToken);
            }

            _logger.LogError("Watcher Service stopped! Unexpected error occurred!");
        }

        private async Task SS(int instanceId, CancellationToken stoppingToken)
        {
            CollectedDataDto dto = null;
            using (var scope = _scopeFactory.CreateScope())
            {
                var repo = scope.ServiceProvider.GetRequiredService<IDataAccumulatorRepository<CollectedData>>();
                var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

                var data = CollectedDataService.GetFakeData(instanceId);

                await repo.AddEntity(data);

                data = await repo.GetEntity(data.InternalId);

                dto = mapper.Map<CollectedData, CollectedDataDto>(data);
            }

            var info = new PercentageInfo
            {
                Id = dto.Id,
                Time = dto.Time,
                RamUsagePercent = dto.RamUsagePercent,
                InterruptsTimePercent = dto.InterruptsTimePercent,
                LocalDiskFreeSpacePercent = dto.LocalDiskFreeSpacePercent,
                CpuUsagePercent = dto.CpuUsagePercent
            };

            MarketPrice.UpdateMarket();
            var mp = MarketPrice.MarketPositions[0];

            await _hubContext.Clients.Group(instanceId.ToString()).SendAsync("InstanceDataTick", info, stoppingToken); // TODO: change to dto
            // await _hubContext.Group("").SendAsync("CollectedPercentageInfoTick", info, cancellationToken: stoppingToken);

            await _hubContext.Clients.All.SendAsync("MarketTick", mp, cancellationToken: stoppingToken);
        }
    }
}
