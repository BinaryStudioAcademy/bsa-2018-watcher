namespace ServiceBus.Shared.Messages
{
    using System;

    public class InstanceMessage
    {
        public InstanceMessage() { }

        public InstanceMessage(Guid instanceId)
        {
            InstanceId = instanceId;
        }

        public Guid InstanceId { get; set; }
    }
}
