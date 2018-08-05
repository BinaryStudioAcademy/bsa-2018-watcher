import { Response } from './response';
import { User } from './user';

export class Feedback {
  constructor(
    public id: number,
    public text: string,
    public createdAt: Date,
    public userId: number,
    public user: User,
    public responseId: number,
    public response: Response) {
  }
}
