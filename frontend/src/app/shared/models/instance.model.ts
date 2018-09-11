import { Organization } from './organization.model';
import { Dashboard } from './dashboard.model';

export interface Instance  {
   id?: number;
   title: string;
   address: string;
   platform: string;
   isActive: boolean;

   aggregationForHour: boolean;
   aggregationForDay: boolean;
   aggregationForMonth: boolean;
   aggregationForWeek: boolean;

   cpuMaxPercent: number;
   ramMaxPercent: number;
   diskMaxPercent: number;

   guidId?: string;
   organization?: Organization;
   dashboards?: Dashboard[];
}



