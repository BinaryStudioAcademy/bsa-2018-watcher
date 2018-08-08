
import { Organization } from './organization.model';
import { Dashboard } from './dashboard.model';

export interface Instance  {
   id: number;
   address: string;
   platform: string;
   organizationId: number;
   organization: Organization;
   dashboards: Dashboard[];
}



