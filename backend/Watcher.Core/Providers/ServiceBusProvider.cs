﻿using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Logging;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Providers
{
    public class ServiceBusProvider : IServiceBusProvider, IDisposable
    {
        private readonly IQueueClient _queueClient;
        private readonly ILogger<ServiceBusProvider> _logger;

        public ServiceBusProvider(IQueueClient queueClient, ILoggerFactory loggerFactory)
        {
            _queueClient = queueClient;
            _logger = loggerFactory?.CreateLogger<ServiceBusProvider>() ?? throw new ArgumentNullException(nameof(loggerFactory));
        }

        #region Subscribe

        public void RegisterOnMessageHandlerAndReceiveMessages()
        {
            // Configure the MessageHandler Options in terms of exception handling, number of concurrent messages to deliver etc.
            var messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
            {
                // Maximum number of Concurrent calls to the callback `ProcessMessagesAsync`, set to 1 for simplicity.
                // Set it according to how many messages the application wants to process in parallel.
                MaxConcurrentCalls = 1,

                // Indicates whether MessagePump should automatically complete the messages after returning from User Callback.
                // False below indicates the Complete will be handled by the User Callback as in `ProcessMessagesAsync` below.
                AutoComplete = false
            };

            // Register the function that will process messages
            _queueClient.RegisterMessageHandler(ProcessMessagesAsync, messageHandlerOptions);
        }

        private async Task<string> ProcessMessagesAsync(Message message, CancellationToken token)
        {
            // Process the message
            var m = Encoding.UTF8.GetString(message.Body);
            // Handle Message From Service Bus
            
            // Complete the message so that it is not received again.
            // This can be done only if the queueClient is created in ReceiveMode.PeekLock mode (which is default).
            await _queueClient.CompleteAsync(message.SystemProperties.LockToken);

            return m;
        }

        #endregion

        #region Publish
        public async Task SendMessageToServiceBus(string message)
        {
            try
            {
                var messageBody = new Message(Encoding.UTF8.GetBytes(message));
                await _queueClient.SendAsync(messageBody);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        {
            _logger.LogError($"Message handler encountered an exception {exceptionReceivedEventArgs.Exception}.");
            var context = exceptionReceivedEventArgs.ExceptionReceivedContext;
            _logger.LogError("Exception context for troubleshooting:");
            _logger.LogError($"- Endpoint: {context.Endpoint}");
            _logger.LogError($"- Entity Path: {context.EntityPath}");
            _logger.LogError($"- Executing Action: {context.Action}");
            return Task.CompletedTask;
        }

        #region IDisposable Support
        // To detect redundant calls
        private bool disposedValue; 
                
        public async Task CloseClient()
        {
            if (!disposedValue)
            {
                await _queueClient.CloseAsync();

                disposedValue = true;
            }
        }
        
        public void Dispose() => CloseClient().GetAwaiter().GetResult();
        #endregion        
    }
}
