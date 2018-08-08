import { Role } from './role';
import { NotificationSetting } from './notificationSetting';
import { UserOrganization } from './userOrganization';
import { Feedback } from './feedback';
import { Response } from './response';
import { Message } from './message';
import { Chat } from './chat';

export interface User {
  id: string;
  firstName: string;
  secondName: string;
  email: string;
  isActive: boolean;
  createdAt: Date;
  roleId: number;
  role: Role;
  nickName: string;
  bio: string;
}
