import { ChatType } from '../models/chat-type.enum';
import { User } from '../models/user.model';

export interface ChatRequest {
  name: string;
  chatType: ChatType;
  createdById: string;
  organizationId: number;
  users: User[];
}
