import { ChartType } from '../enums/chartType';
import { Dashboard } from './dashboard';

export class Chart {
  constructor(
    public id: number,
    public type: ChartType,
    public source: string,
    public showCommon: string,
    public threshold: number,
    public mostLoaded: string,
    public dashboardId: number,
    public dashboard: Dashboard) {
  }
}
























