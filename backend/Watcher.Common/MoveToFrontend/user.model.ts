﻿
import { Role } from './role.model';
import { Organization } from './organization.model';
import { NotificationSetting } from './notification-setting.model';
import { Organization } from './organization.model';
import { Notification } from './notification.model';
import { Feedback } from './feedback.model';
import { Response } from './response.model';
import { Message } from './message.model';
import { Chat } from './chat.model';
import { Chat } from './chat.model';

export interface User  {
   id: string;
   displayName: string;
   firstName: string;
   lastName: string;
   bio: string;
   email: string;
   isActive: boolean;
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
   createdChats: Chat[];
   chats: Chat[];
}



