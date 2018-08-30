import { ChatType } from '../models/chat-type.enum';
import { User } from '../models/user.model';
import { NotificationSetting } from '../models/notification-setting.model';

export interface ChatRequest {
  name: string;
  type: ChatType;
  createdById: string;
  organizationId: number;
  users: User[];
  usersSettings: NotificationSetting[];
}
