
import { ChartType } from './chart-type.enum';

export interface ChartRequest  {
   type: ChartType;
   source: string;
   showCommon: string;
   threshold: number;
   mostLoaded: string;
   dashboardId: number;
}



