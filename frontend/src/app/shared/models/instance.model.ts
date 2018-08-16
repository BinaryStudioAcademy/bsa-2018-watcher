
import { Organization } from './organization.model';
import { Dashboard } from './dashboard.model';

export interface Instance  {
   id: number;
   address: string;
   platform: string;
   organization: Organization;
   dashboards: Dashboard[];
}



