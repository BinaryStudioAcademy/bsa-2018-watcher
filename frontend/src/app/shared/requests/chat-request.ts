import { ChatType } from '../models/chat-type.enum';
import { User } from '../models/user.model';

export interface ChatRequest {
  name: string;
  type: ChatType;
  createdById: string;
  organizationId: number;
  users: User[];
}
