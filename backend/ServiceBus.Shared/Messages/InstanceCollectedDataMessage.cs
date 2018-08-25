namespace ServiceBus.Shared.Messages
{
    using System;

    public class InstanceCollectedDataMessage : InstanceMessage
    {
        public InstanceCollectedDataMessage() { }

        public InstanceCollectedDataMessage(Guid collectedDataId, Guid instanceId) : base(instanceId)
        {
            CollectedDataId = collectedDataId;
        }

        public Guid CollectedDataId { get; set; }
    }
}
