﻿
import { ChatType } from './chat-type.enum';
import { User } from './user.model';
import { Organization } from './organization.model';
import { Message } from './message.model';

export interface Chat  {
   id: number;
   name: string;
   type: ChatType;
   createdById: number;
   createdBy: User;
   organizationId: number;
   organization: Organization;
   messages: Message[];
}



