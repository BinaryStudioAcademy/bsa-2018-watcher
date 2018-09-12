namespace ServiceBus.Shared.Messages
{
    using System;

    using DataAccumulator.Shared.Models;

    public class InstanceAnomalyReportMessage : InstanceMessage
    {
        public InstanceAnomalyReportMessage() { }

        public InstanceAnomalyReportMessage(Guid instanceId, AzureMLAnomalyReport report) : base(instanceId)
        {
            AnomalyReport = report;
        }

        public AzureMLAnomalyReport AnomalyReport { get; set; }
    }
}
