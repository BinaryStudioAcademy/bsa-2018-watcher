using Watcher.Common.MoveToFrontend;

namespace Watcher.Common.Requests
{
    using Watcher.Common.Enums;

    [ExportClassToTypescript]
    public class ChartRequest
    {
        public ChartRequest() { }

        public bool ShowCommon { get; set; }

        public int Threshold { get; set; }

        public string MostLoaded { get; set; }

        public int DashboardId { get; set; }

        // public ColorSchemeTypeName ColorScheme { get; set; }

        public string SchemeType { get; set; } = "ordinal";

        public bool ShowLegend { get; set; }

        public string LegendTitle { get; set; }

        public bool Gradient { get; set; }

        public bool ShowXAxis { get; set; }

        public bool ShowYAxis { get; set; }

        public bool ShowXAxisLabel { get; set; }

        public bool ShowYAxisLabel { get; set; }

        public string YAxisLabel { get; set; }

        public string XAxisLabel { get; set; }

        public bool AutoScale { get; set; }

        public bool ShowGridLines { get; set; }

        public double RangeFillOpacity { get; set; }

        public bool RoundDomains { get; set; }

        public bool IsTooltipDisabled { get; set; }

        public bool IsShowSeriesOnHover { get; set; }

        //public CurveType CurveType { get; set; }

        //public CurveClosedType CurveClosedType { get; set; }

        public string Title { get; set; }

        public ChartType Type { get; set; }

        public string Sources { get; set; }

        public bool IsLightTheme { get; set; }
    }
}
