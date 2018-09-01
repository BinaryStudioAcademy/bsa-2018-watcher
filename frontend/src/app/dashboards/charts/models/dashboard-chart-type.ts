import {ChartType} from '../../../shared/models/chart-type.enum';

export interface CustomChartType {
  name: string;
  type: ChartType;
  title: string;
  dimLabels: string[];
  chartLabels: Function;
}
