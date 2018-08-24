namespace ServiceBus.Shared.Messages
{
    using System;

    public class InstanceCollectedDataMessage
    {
        public Guid CollectedDataId { get; set; }
        public Guid InstanceId { get; set; }
    }
}
