namespace DataAccumulator.Shared.Models
{
    using System;
    using System.Collections.Generic;

    public class InstanceAnomalyReportDto
    {
        public Guid Id { get; set; }
        
        public Guid ClientId { get; set; }

        public DateTime Date { get; set; }

        public CollectedDataType CollectedDataTypeOfReport { get; set; }

        public List<AzureMLAnomalyGroup> AnomalyGroups { get; set; }
    }
}
