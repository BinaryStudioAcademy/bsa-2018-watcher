
import { UserDto } from './user-dto';
import { Response } from './response.model';

export interface Feedback  {
   id: number;
   text: string;
   createdAt: Date;
   user: UserDto;
   response: Response;
}



