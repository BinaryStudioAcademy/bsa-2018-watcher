namespace ServiceBus.Shared.Messages
{
    using System;

    class InstanceSettingsMessage : InstanceMessage
    {
        public InstanceSettingsMessage(Guid instanceId, 
                                       bool hourAggregation,
                                       bool dayAggregation,
                                       bool monthAggregation,
                                       float cpuMax,
                                       float ramMax,
                                       float diskMax): base(instanceId)
        {
            AggregationForHour = hourAggregation;
            AggregationForDay = dayAggregation;
            AggregationForMonth = monthAggregation;
            CpuMaxPercent = cpuMax;
            RamMaxPercent = ramMax;
            DiskMaxPercent = diskMax;
        }
        public bool AggregationForHour { get; set; }
        public bool AggregationForDay { get; set; }
        public bool AggregationForMonth { get; set; }

        public float CpuMaxPercent { get; set; }
        public float RamMaxPercent { get; set; }
        public float DiskMaxPercent { get; set; }
    }
}
