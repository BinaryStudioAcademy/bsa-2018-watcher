
 import { Organization } from './organization';
import { User } from './user';

    export interface Notification  { 
        id: number;
        text: string;
        createdAt: Date;
        organizationId: number;
        organization: Organization;
        userId: number;
        user: User;
    }



