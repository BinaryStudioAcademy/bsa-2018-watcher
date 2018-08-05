import { Organization } from './organization';
import { Dashboard } from './dashboard';

export class Instance {
  constructor(
    public id: number,
    public address: string,
    public platform: string,
    public organizationId: number,
    public organization: Organization,
    public dashboards: Dashboard[]) {
  }
}
