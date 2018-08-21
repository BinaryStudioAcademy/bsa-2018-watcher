import { Organization } from './organization.model';
import { Dashboard } from './dashboard.model';

export interface Instance  {
   id?: number;
   title: string;
   address: string;
   platform: string;
   isActive: boolean;
   guidId: string;
   organization?: Organization;
   dashboards?: Dashboard[];
}



