import { User } from './user';
import { Feedback } from './feedback';

export class Response {
  constructor(
    public id: number,
    public text: string,
    public createdAt: Date,
    public userId: number,
    public user: User,
    public feedbackId: number,
    public feedback: Feedback) {
  }
}
