namespace Watcher.Common.Requests
{
    using System.ComponentModel.DataAnnotations;

    using Watcher.Common.Enums;

    public class ChartRequest
    {
        [Required]
        public ChartType Type { get; set; }

        [Required]
        public string Source { get; set; }

        public string ShowCommon { get; set; }

        [Required]
        public int Threshold { get; set; }

        public string MostLoaded { get; set; }

        public int DashboardId { get; set; }
    }
}
