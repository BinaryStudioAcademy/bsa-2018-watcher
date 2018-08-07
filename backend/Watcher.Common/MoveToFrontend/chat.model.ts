
 import { ChatType } from './chat-type';
import { User } from './user';
import { Organization } from './organization';
import { Message } from './message';

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



