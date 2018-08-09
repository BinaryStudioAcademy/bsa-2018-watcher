
import { ChartType } from './chart-type.enum';
import { Dashboard } from './dashboard.model';

export interface Chart  {
   id: number;
   type: ChartType;
   source: string;
   showCommon: string;
   threshold: number;
   mostLoaded: string;
   dashboardId: number;
   dashboard: Dashboard;
}



