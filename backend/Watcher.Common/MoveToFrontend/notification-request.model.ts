
import { NotificationType } from './notification-type.enum';

export interface NotificationRequest  {
   text: string;
   createdAt: Date;
   organizationId: number;
   instanceId: string;
   userId: string;
   wasRead: boolean;
   type: NotificationType;
   notificationSettingId: number;
}



