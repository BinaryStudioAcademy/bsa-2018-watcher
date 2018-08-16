import { ChatType } from '../models/chat-type.enum';

export interface ChatRequest {
  name: string;
  chatType: ChatType;
  createdById: string;
  organizationId: number;
}
