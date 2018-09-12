import { NotificationSetting } from './notification-setting.model';

export interface Notification  {
   id: number;
   text: string;
   createdAt: Date;
   wasRead: boolean;
   userId: string;
   instanceId?: number;
   instanceGuidId?: string;
   notificationSettingId: Number;
   notificationSetting: NotificationSetting;
}
