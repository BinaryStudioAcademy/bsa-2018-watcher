namespace Watcher.Common.Dtos
{
    using Watcher.Common.Enums;
    using Watcher.Common.Interfaces.Entities;
    using Watcher.Common.MoveToFrontend;

    [ExportClassToTypescript]
    public class ChartDto : IEntity<int>
    {
        public int Id { get; set; }

        public bool ShowCommon { get; set; } // = true;

        public int Threshold { get; set; } // = 1;

        public int MostLoaded { get; set; } // = 1'

        public int DashboardId { get; set; }

        public string SchemeType { get; set; } // = "ordinal"; // by default it will change depend on user choise

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

        public string Title { get; set; }

        public ChartType Type { get; set; }

        public string Sources { get; set; } // 0,1 or 15

        public bool IsLightTheme { get; set; }
    }
}
