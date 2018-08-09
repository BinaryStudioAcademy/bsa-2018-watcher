
import { User } from './user.model';
import { Feedback } from './feedback.model';

export interface Response  {
   id: number;
   text: string;
   createdAt: Date;
   user: User;
   feedback: Feedback;
}



