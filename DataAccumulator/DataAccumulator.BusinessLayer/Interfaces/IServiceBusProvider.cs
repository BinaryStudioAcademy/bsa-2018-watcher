namespace DataAccumulator.BusinessLayer.Interfaces
{
    using System;
    using System.Threading.Tasks;

    using ServiceBus.Shared.Messages;

    public interface IServiceBusProvider
    {
        Task SendDataMessage(InstanceCollectedDataMessage message);

        Task SendDataMessage(Guid instanceId, Guid dataId);
        Task SendDataMessage(InstanceValidatorMessage message);

        Task SendErrorMessage(InstanceErrorMessage message);

        Task SendErrorMessage(Guid instanceId, string errorMessage);
        Task SendValidatorMessage(InstanceValidatorMessage message);
    }
}
