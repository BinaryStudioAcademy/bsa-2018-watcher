using System;
using System.Collections.Generic;

namespace DataAccumulator.Shared.Models
{
    public class AzureMLAnomalyReport
    {
        public DateTime Date { get; set; }

        public CollectedDataType CollectedDataTypeOfReport { get; set; }

        public List<AzureMLAnomalyGroup> AnomalyGroups { get; set; }
    }

    public class AzureMLAnomalyGroup
    {
        public string Name { get; set; }
        public List<AzureMLAnomaly> Warnings { get; set; }
        public List<AzureMLAnomaly> Anomalies { get; set; }
        public int Total { get; set; }
    }

    public class AzureMLAnomaly
    {
        public DateTime Time { get; set; }
        public float Data { get; set; }
    }
}
