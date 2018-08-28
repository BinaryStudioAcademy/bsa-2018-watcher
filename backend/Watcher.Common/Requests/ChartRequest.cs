using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Requests
{
    using Watcher.Common.Enums;

    [ExportClassToTypescript]
    public class ChartRequest
    {
        public ChartRequest() { }

        public ChartType Type { get; set; }

        public string Source { get; set; }

        public string ShowCommon { get; set; }

        public int Threshold { get; set; }

        public string MostLoaded { get; set; }

        public int DashboardId { get; set; }
    }
}
