export interface UserRegisterRequest {
  uid: string;
  email: string;
  displayName: string;
  photoURL: string;
  refreshToken: string;
  isNewUser: boolean;
  companyName: string;
  lastName: string;
  firstName: string;
}
