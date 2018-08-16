
import { User } from './user.model';
import { Chat } from './chat.model';

export interface Message  {
   id: number;
   text: string;
   createdAt: Date;
   wasRead: boolean;
   userId: string;
   chatId: number;
}



