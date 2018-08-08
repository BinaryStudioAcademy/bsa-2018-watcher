import { UserModel } from './user.model';

export interface PostInfo {
    user: UserModel;
    token: string;
}
