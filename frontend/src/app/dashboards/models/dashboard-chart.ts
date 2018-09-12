import {CustomData} from '../charts/models';
import {DataProperty} from '../../shared/models/data-property.enum';
import {ColorScheme} from '../../shared/models/color-scheme.model';

import {CollectedData} from '../../shared/models/collected-data.model';
import {ChartType} from '../../shared/models/chart-type.enum';


export interface DashboardChart {
  view: any;
  id: number;
  showCommon: boolean;
  threshold: number;
  mostLoaded: number;
  historyTime: number; // 5 - 60
  colorScheme: ColorScheme;
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
  colectedData: CollectedData;
  type: ChartType;
  theme: string;
  isIncluded: boolean;
}
