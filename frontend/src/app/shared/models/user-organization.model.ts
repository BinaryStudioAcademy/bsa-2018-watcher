
import { User } from './user.model';
import { Organization } from './organization.model';
import { OrganizationRole } from './organization-role.model';

export interface UserOrganization  {
   user: User;
   organization: Organization;
   organizationRole: OrganizationRole;
}



