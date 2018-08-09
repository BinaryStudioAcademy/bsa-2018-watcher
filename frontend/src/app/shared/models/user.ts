import { Role } from './role';

export interface User {
  id: string;
  firstName: string;
  secondName: string;
  displayName: string;
  email: string;
  isActive: boolean;
  createdAt: Date;
  roleId: number;
  role: Role;
  bio: string;
}
