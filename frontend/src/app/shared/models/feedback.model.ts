
import { User } from './user.model';
import { Response } from './response.model';

export interface Feedback  {
   id: number;
   text: string;
   createdAt: Date;
   user: User;
   response: Response;
}



