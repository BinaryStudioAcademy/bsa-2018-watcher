import { Role } from './role';
import { NotificationSetting } from './notificationSetting';
import { UserOrganization } from './userOrganization';
import { Feedback } from './feedback';
import { Response } from './response';
import { Message } from './message';
import { Chat } from './chat';

export class User {
  constructor(
    public id: number,
    public firstName: string,
    public secondName: string,
    public email: string,
    public isActive: boolean,
    public createdAt: Date,
    public roleId: number,
    public role: Role,
    public notificationSettingId: number,
    public notificationSetting: NotificationSetting,
    public userOrganizations: UserOrganization[],
    public notifications: Notification[],
    public feedbacks: Feedback[],
    public responses: Response[],
    public messages: Message[],
    public createdChats: Chat[]) {
  }
}
