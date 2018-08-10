import { Role } from './role.model';

export interface UserDto {
    id: string;
    firstName: string;
    secondName: string;
    email: string;
    isActive: boolean;
    createdAt: Date;
    role: Role;
    lastPickedOrganizationId: number;
}
