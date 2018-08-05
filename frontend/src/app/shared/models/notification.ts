import { Organization } from './organization';
import { User } from './user';

export class Notification {
  constructor(
    public id: number,
    public text: string,
    public createdAt: Date,
    public organizationId: number,
    public organization: Organization,
    public userId: number,
    public user: User) {
  }
}
