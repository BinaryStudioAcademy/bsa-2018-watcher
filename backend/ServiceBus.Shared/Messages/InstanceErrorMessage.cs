
namespace ServiceBus.Shared.Messages
{
    using System;

    public class InstanceErrorMessage : InstanceMessage
    {
        public InstanceErrorMessage(string errorMessage, Guid instanceId) : base(instanceId)
        {
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; set; }
    }
}
