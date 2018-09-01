import {ChartType} from '../../../shared/models/chart-type.enum';

export interface DashboardChartType {
  name: string;
  type: ChartType;
  title: string;
  dimLabels: string[];
  chartLabels: Function;
}
