namespace Watcher.Common.Requests
{
    using Watcher.Common.Enums;

    public class CreateChartRequest
    {
        // public object View { get; set; }
        
        public ColorSchemeTypeName ColorScheme { get; set; }

        public string SchemeType { get; set; }

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
        
        public CurveType CurveType { get; set; }

        public CurveClosedType IsCurveClosed { get; set; }
            
        public string Title { get; set; }

        public string[] DataDims { get; set; }

        //public object XQuery { get; set; }
        //public object YQuery { get; set; } // Query 
        //public object XFilter { get; set; } // Filter
        //public object YFilter { get; set; }

        // data: CustomData[];
        // activeEntries: CustomData[];
        public ChartType ChartType { get; set; }

        public bool IsLightTheme { get; set; }
    }
}
