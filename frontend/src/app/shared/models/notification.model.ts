import { NotificationSetting } from './notification-setting.model';
import { NotificationType } from './notification-type.enum';

export interface Notification  {
   id: number;
   text: string;
   createdAt: Date;
   wasRead: boolean;
   userId: Number;
   notificationSettingId: Number;
   notificationSetting: NotificationSetting;
   type: NotificationType;
}



