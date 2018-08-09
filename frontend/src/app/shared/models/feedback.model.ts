import { Response } from './response.model';

export interface Feedback  {
   id: number;
   text: string;
   createdAt: Date;
   userId: number;
   user: User;
   responseId: number;
   response: Response;
}



