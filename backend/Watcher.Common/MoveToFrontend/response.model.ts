
import { User } from './user.model';
import { Feedback } from './feedback.model';

export interface Response  {
   id: number;
   text: string;
   createdAt: Date;
   userId: number;
   user: User;
   feedbackId: number;
   feedback: Feedback;
}



