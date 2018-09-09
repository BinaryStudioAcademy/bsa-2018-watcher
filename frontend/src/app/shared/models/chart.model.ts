import { ChartType } from './chart-type.enum';
import { ColorScheme } from './color-scheme.model';

export interface Chart  {
   id: number;
   showCommon: boolean;
   threshold: number;
   mostLoaded: number;
   dashboardId: number;
   schemeType: string;
   showLegend: boolean;
   legendTitle: string;
   gradient: boolean;
   showXAxis: boolean;
   showYAxis: boolean;
   showXAxisLabel: boolean;
   showYAxisLabel: boolean;
   yAxisLabel: string;
   xAxisLabel: string;
   autoScale: boolean;
   showGridLines: boolean;
   rangeFillOpacity: number;
   roundDomains: boolean;
   isTooltipDisabled: boolean;
   isShowSeriesOnHover: boolean;
   title: string;
   type: ChartType;
   sources: string;
   isLightTheme: boolean;
   scheme: ColorScheme;
}
