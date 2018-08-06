import { User } from './user';
import { Organization } from './organization';

export class UserOrganization {
    constructor(
        public userId: number,
        public user: User,
        public organizationId: number,
        public organization: Organization) {
    }
}
