import { Organization } from './organization';
import { Dashboard } from './dashboard';

export interface Instance { 
  id: number;
  address: string;
  platform: string;
  organizationId: number;
  organization: Organization;
  dashboards: Dashboard[];
}
