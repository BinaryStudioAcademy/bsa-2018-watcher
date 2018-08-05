namespace Watcher.Services
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.SignalR;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;

    using Watcher.Core.Interfaces;
    using Watcher.Hubs;

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
        public WatcherService(IHubContext<NotificationsHub> hubContext, ITransientService service, ILogger<WatcherService> logger)
        {
            _hubContext = hubContext;
            _service = service;
            _logger = logger;
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
                    var sample = _service.GenerateRandomSampleDtoAsync();

                    // Method Name on Angular Client: "DataFeedTick",
                    // Single argument of that method is SampleDto
                    await _hubContext.Clients.All.SendAsync("DataFeedTick", sample, cancellationToken: stoppingToken);
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message);
                }
                
                // Repeat this message feed every 0.5 seconds
                await Task.Delay(500, stoppingToken);
            }

            _logger.LogError("Watcher Service stopped! Unexpected error occurred!");
        }
    }
}
