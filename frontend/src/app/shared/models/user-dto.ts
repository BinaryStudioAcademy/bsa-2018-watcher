import { Role } from './role.model';

export interface UserDto {
    id: string;
    displayName: string;
    firstName: string;
    lastName: string;
    email: string;
    isActive: boolean;
    createdAt: Date;
    role: Role;
    lastPickedOrganizationId: number;
}
