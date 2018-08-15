import { ChatType } from './chat-type.enum';
import { User } from './user.model';
import { Organization } from './organization.model';
import { Message } from './message.model';

export interface Chat  {
   id: number;
   name: string;
   type: ChatType;
   createdById: string;
   createdBy: User;
   organization: Organization;
   messages: Message[];
}



