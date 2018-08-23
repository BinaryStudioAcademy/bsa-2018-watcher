
import { Organization } from './organization.model';
import { User } from './user.model';
import { NotificationSetting } from './notification-setting.model';

export interface Notification  {
   id: number;
   text: string;
   createdAt: Date;
   wasRead: boolean;
   userId: Number;
   notificationSettingId: Number;
   notificationSetting: NotificationSetting;
   type: string;
}



