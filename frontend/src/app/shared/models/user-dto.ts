import {Role} from './role';

export interface UserDto {
    id: string;
    firstName: string;
    secondName: string;
    email: string;
    isActive: boolean;
    createdAt: Date;
    role: Role;
}
