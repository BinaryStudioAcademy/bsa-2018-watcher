
 import { User } from './user';
import { Organization } from './organization';

    export interface UserOrganization  { 
        userId: number;
        user: User;
        organizationId: number;
        organization: Organization;
    }



