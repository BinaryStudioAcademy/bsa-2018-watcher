
import { Role } from './role.model';
import { NotificationSetting } from './notification-setting.model';
import { UserOrganization } from './user-organization.model';
import { Notification } from './notification.model';
import { Feedback } from './feedback.model';
import { Response } from './response.model';
import { Message } from './message.model';
import { Chat } from './chat.model';
import { Organization } from './organization.model';

export interface UserDto {
    id: string;
    displayName: string;
    firstName: string;
    secondName: string;
    email: string;
    isActive: boolean;
    createdAt: Date;
    role: Role;
    lastPickedOrganizationId: number;
    lastPickedOrganization: Organization;
    notificationSettings: NotificationSetting[];
    userOrganizations: UserOrganization[];
    notifications: Notification[];
    feedbacks: Feedback[];
    responses: Response[];
    messages: Message[];
    createdChats: Chat[];
}
