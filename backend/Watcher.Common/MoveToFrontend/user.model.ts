
 import { Role } from './role';
import { NotificationSetting } from './notification-setting';
import { UserOrganization } from './user-organization';
import { Notification } from './notification';
import { Feedback } from './feedback';
import { Response } from './response';
import { Message } from './message';
import { Chat } from './chat';

    export interface User  { 
        id: number;
        firstName: string;
        secondName: string;
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



