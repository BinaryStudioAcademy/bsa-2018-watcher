
import { Role } from './role.model';
import { NotificationSetting } from './notification-setting.model';
import { UserOrganization } from './user-organization.model';
import { Notification } from './notification.model';
import { Feedback } from './feedback.model';
import { Response } from './response.model';
import { Message } from './message.model';
import { Chat } from './chat.model';

export interface User  {
   id: number;
   firstName: string;
   secondName: string;
   displayName: string;
   email: string;
   isActive: boolean;
   createdAt: Date;
   roleId: number;
   role: Role;
   notificationSettingId: number;
   notificationSetting: NotificationSetting;
   userOrganizations: UserOrganization[];
   notifications: Notification[];
   feedbacks: Feedback[];
   responses: Response[];
   messages: Message[];
   createdChats: Chat[];
}



