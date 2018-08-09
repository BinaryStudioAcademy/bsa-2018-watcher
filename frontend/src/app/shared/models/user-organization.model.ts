
import { User } from './user.model';
import { Organization } from './organization.model';

export interface UserOrganization  {
   userId: number;
   user: User;
   organizationId: number;
   organization: Organization;
}



