import { Feedback } from '../shared/models/feedback.model';

export interface ForShow {
    main: Feedback;
    willuse: string;
    info: string;
    quickness: string;
    friendliness: string;
}
