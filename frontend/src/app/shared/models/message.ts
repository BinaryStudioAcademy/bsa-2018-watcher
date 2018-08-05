import { User } from './user';
import { Chat } from './chat';

export class Message {
  constructor(
    public id: number,
    public text: string,
    public createdAt: Date,
    public wasRead: boolean,
    public userId: number,
    public user: User,
    public chatId: number,
    public chat: Chat) {
  }
}
