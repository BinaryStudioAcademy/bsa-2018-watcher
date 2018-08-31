import {Filter} from './filter';
import {CustomData} from './custom-data';
import {CustomChartType} from './custom-chart-type';

export interface CustomChart {
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
  rangeFillOpacity: 0.5;
  roundDomains: boolean;
  tooltipDisabled: boolean;
  showSeriesOnHover: boolean;
  curve: any;
  curveClosed: any;

  title: string;

  dataDims: string[];
  xQuery: any;
  yQuery: any;
  xFilter: Filter;
  yFilter: Filter;

  data: CustomData[];
  activeEntries: CustomData[];
  chartType: CustomChartType;
  theme: string;
}

