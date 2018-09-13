import { NotificationSetting } from './notification-setting.model';

export interface Notification  {
   id: number;
   text: string;
   createdAt: Date;
   wasRead: boolean;
   userId: string;
   instanceGuidId?: string;
   instanceId?: number;
   notificationSettingId: Number;
   notificationSetting: NotificationSetting;
}
