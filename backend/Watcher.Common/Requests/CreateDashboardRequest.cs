namespace Watcher.Common.Requests
{
    using System.Collections.Generic;

    public class CreateDashboardRequest : DashboardRequest
    {
        public IEnumerable<ChartRequest> ChartRequests { get; set; }
    }
}
