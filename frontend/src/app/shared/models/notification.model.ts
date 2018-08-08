
import { Organization } from './organization.model';
import { User } from './user.model';

export interface Notification  {
   id: number;
   text: string;
   createdAt: Date;
   organizationId: number;
   organization: Organization;
   userId: number;
   user: User;
}



