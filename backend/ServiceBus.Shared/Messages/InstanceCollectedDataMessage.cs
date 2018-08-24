namespace ServiceBus.Shared.Messages
{
    using System;

    public class InstanceCollectedDataMessage
    {
        public InstanceCollectedDataMessage() { }

        public InstanceCollectedDataMessage(Guid collectedDataId, Guid instanceId)
        {
            CollectedDataId = collectedDataId;
            InstanceId = instanceId;
        }

        public Guid CollectedDataId { get; set; }
        public Guid InstanceId { get; set; }
    }
}
