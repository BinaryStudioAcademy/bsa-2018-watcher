
import { ChatType } from './chat-type.enum';
import { User } from './user.model';
import { Organization } from './organization.model';
import { Message } from './message.model';
import { User } from './user.model';

export interface Chat  {
   id: number;
   name: string;
   type: ChatType;
   createdBy: User;
   organization: Organization;
   messages: Message[];
   users: User[];
}



