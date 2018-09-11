namespace DataAccumulator.BusinessLayer.Interfaces
{
    using System;
    using System.Threading.Tasks;

    using ServiceBus.Shared.Messages;

    public interface IServiceBusProvider
    {
        Task SendDataMessage(InstanceCollectedDataMessage message);

        Task SendDataMessage(Guid instanceId, Guid dataId);
        Task SendErrorMessage(InstanceErrorMessage message);

        Task SendErrorMessage(Guid instanceId, string errorMessage);
        Task SendNotificationMessage(InstanceNotificationMessage message);
    }
}
