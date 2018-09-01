
import { ChatType } from './chat-type.enum';
import { User } from './user.model';
import { Organization } from './organization.model';
import { Message } from './message.model';
import { User } from './user.model';
import { NotificationSetting } from './notification-setting.model';

export interface Chat  {
   id: number;
   name: string;
   unreadMessagesCount: number;
   type: ChatType;
   createdBy: User;
   organization: Organization;
   messages: Message[];
   users: User[];
   usersSettings: NotificationSetting[];
}



