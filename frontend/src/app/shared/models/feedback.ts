import { Response } from './response';
import { User } from './user';

export interface Feedback { 
  id: number;
  text: string;
  createdAt: Date;
  userId: number;
  user: User;
  responseId: number;
  response: Response;
}
