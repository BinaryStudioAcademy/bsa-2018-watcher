using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using DataAccumulator.Interfaces;

namespace DataAccumulator.Providers
{
    public class ServiceBusProvider : IServiceBusProvider
    {
        private readonly IConfiguration _configuration;

        public ServiceBusProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendMessageToServiceBus(string message)
        {
            
                var connection = _configuration.GetSection("SERVICE_BUS_CONNECTION_STRING").Value;
                var name = _configuration.GetSection("SERVICE_BUS_QUEUE_NAME").Value;

            var queueClient = new QueueClient(connection, name);

            try
            {
                var messageBody = new Message(Encoding.UTF8.GetBytes(message));
                await queueClient.SendAsync(messageBody);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                await queueClient.CloseAsync();
            }
        }
    }
}
