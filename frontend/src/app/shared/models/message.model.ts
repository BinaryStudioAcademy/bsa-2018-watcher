import { User } from './user.model';

export interface Message  {
   id: number;
   text: string;
   createdAt: Date;
   wasRead: boolean;
   user: User;
   userId: number;
   chatId: number;
}
