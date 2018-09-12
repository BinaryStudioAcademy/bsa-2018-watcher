namespace ServiceBus.Shared.Messages
{
    using System;

    public class InstanceSettingsMessage : InstanceMessage
    {
        public InstanceSettingsMessage()
        {
        }

        public InstanceSettingsMessage(Guid instanceId, 
                                       bool isActive,
                                       bool hourAggregation,
                                       bool dayAggregation,
                                       bool weekAggregation,
                                       bool monthAggregation,
                                       bool weekAggregation,
                                       float cpuMax,
                                       float ramMax,
                                       float diskMax): base(instanceId)
        {
            IsActive = isActive;
            AggregationForHour = hourAggregation;
            AggregationForDay = dayAggregation;
            AggregationForWeek = weekAggregation;
            AggregationForMonth = monthAggregation;
            AggregationForWeek = weekAggregation;
            CpuMaxPercent = cpuMax;
            RamMaxPercent = ramMax;
            DiskMaxPercent = diskMax;
        }

        public bool IsActive { get; set; }

        public bool AggregationForHour { get; set; }
        public bool AggregationForDay { get; set; }
        public bool AggregationForWeek { get; set; }
        public bool AggregationForMonth { get; set; }
        public bool AggregationForWeek { get; set; }

        public float CpuMaxPercent { get; set; }
        public float RamMaxPercent { get; set; }
        public float DiskMaxPercent { get; set; }
    }
}
