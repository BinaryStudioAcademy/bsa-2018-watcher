
import { Organization } from './organization.model';
import { User } from './user.model';

export interface Notification  {
   id: number;
   text: string;
   createdAt: Date;
   organizationId: Number;
   userId: Number;
   notificationSettingId: Number;
}



