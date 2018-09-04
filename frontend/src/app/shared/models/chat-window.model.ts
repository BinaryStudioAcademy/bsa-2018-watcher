import { Chat } from './chat.model';

export interface ChatWindow  {
   chat: Chat;
   isCollapsed: boolean;
   unreadMessages: number;
}
