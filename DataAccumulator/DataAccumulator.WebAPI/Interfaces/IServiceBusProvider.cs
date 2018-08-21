using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccumulator.Interfaces
{
    public interface IServiceBusProvider
    {
        Task SendMessageToServiceBus(string message);
    }
}
