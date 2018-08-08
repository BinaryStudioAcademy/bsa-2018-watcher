
 import { User } from './user';
import { Response } from './response';

    export interface Feedback  { 
        id: number;
        text: string;
        createdAt: Date;
        userId: number;
        user: User;
        responseId: number;
        response: Response;
    }



