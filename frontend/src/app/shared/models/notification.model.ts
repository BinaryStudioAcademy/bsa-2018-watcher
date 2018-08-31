import { NotificationSetting } from './notification-setting.model';

export interface Notification  {
   id: number;
   text: string;
   createdAt: Date;
   wasRead: boolean;
   userId: string;
   notificationSettingId: Number;
   notificationSetting: NotificationSetting;
}
