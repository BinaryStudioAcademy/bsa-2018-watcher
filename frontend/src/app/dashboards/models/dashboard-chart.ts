import {CustomChartType, CustomData, Filter} from '../charts/models';

export interface DashboardChart {
  view: any;
  colorScheme: any;
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
  tooltipDisabled: boolean;
  showSeriesOnHover: boolean;
  curve: any;
  curveClosed: any;

  title: string;

  data: CustomData[];
  activeEntries: CustomData[];
  chartType: CustomChartType;
  theme: string;
}
