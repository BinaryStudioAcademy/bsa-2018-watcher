
import { ChatType } from './chat-type.enum';
import { Organization } from './organization.model';
import { Message } from './message.model';
import { User } from './user.model';
import { NotificationSetting } from './notification-setting.model';

export interface Chat  {
   id: number;
   name: string;
   unreadMessagesCount: number;
   type: ChatType;
   createdById: string;
   organization: Organization;
   messages: Message[];
   users: User[];
   usersSettings: NotificationSetting[];
}



