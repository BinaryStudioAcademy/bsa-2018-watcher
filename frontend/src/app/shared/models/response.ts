import { User } from './user';
import { Feedback } from './feedback';

export interface Response {
  id: number;
  text: string;
  createdAt: Date;
  userId: number;
  user: User;
  feedbackId: number;
  feedback: Feedback;
}
