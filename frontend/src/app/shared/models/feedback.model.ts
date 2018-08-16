
import { ShortAnswerType } from './short-answer-type.enum';
import { LongAnswerType } from './long-answer-type.enum';
import { User } from './user.model';
import { Response } from './response.model';

export interface Feedback  {
   id: number;
   text: string;
   willUse: ShortAnswerType;
   informatively: LongAnswerType;
   friendliness: LongAnswerType;
   quickness: LongAnswerType;
   createdAt: Date;
   user: User;
   response: Response;
}



