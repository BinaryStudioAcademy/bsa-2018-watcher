export interface UserModel {
    uid: string;
    email: string;
    displayName: string;
    photoURL: string;
    refreshToken: string;
    isNewUser: boolean;
}