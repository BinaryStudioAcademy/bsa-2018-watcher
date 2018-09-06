import {DashboardChartType, CustomData} from '../charts/models';
import {DataProperty} from '../../shared/models/data-property.enum';

export interface DashboardChart {
  view: any;
  id: number;
  showCommon: boolean;
  threshold: number;
  mostLoaded: string;
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
  yScaleMax: number;
  yScaleMin: number;
  autoScale: boolean;
  showGridLines: boolean;
  rangeFillOpacity: number;
  roundDomains: boolean;
  tooltipDisabled: boolean;
  showSeriesOnHover: boolean;
  curve: any;
  curveClosed: any;
  title: string;
  dataSources: DataProperty[];
  data: CustomData[];
  activeEntries: CustomData[];
  chartType: DashboardChartType;
  theme: string;
}
