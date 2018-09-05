
import { Role } from './role.model';
import { Organization } from './organization.model';
import { NotificationSetting } from './notification-setting.model';
import { Organization } from './organization.model';
import { Notification } from './notification.model';
import { Feedback } from './feedback.model';
import { Response } from './response.model';
import { Message } from './message.model';

export interface User  {
   id: string;
   displayName: string;
   firstName: string;
   lastName: string;
   bio: string;
   email: string;
   emailForNotifications: string;
   isActive: boolean;
   photoURL: string;
   createdAt: Date;
   role: Role;
   lastPickedOrganizationId: number;
   lastPickedOrganization: Organization;
   notificationSettings: NotificationSetting[];
   organizations: Organization[];
   notifications: Notification[];
   feedbacks: Feedback[];
   responses: Response[];
   messages: Message[];
   chatsId: number[];
}



