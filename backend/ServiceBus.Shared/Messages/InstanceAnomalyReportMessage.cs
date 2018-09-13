namespace ServiceBus.Shared.Messages
{
    using System;

    public class InstanceAnomalyReportMessage : InstanceMessage
    {
        public InstanceAnomalyReportMessage() { }

        public InstanceAnomalyReportMessage(Guid instanceId, Guid reportId) : base(instanceId)
        {
            AnomalyReportId = reportId;
        }

        public Guid AnomalyReportId { get; set; }
    }
}
