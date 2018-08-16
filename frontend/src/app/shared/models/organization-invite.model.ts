
import { Organization } from './organization.model';
import { User } from 'firebase';
import { OrganizationInviteState } from './organization-invite-state.enum';

export interface OrganizationInvites  {
   id: number;
   link: string;
   organizationId: number;
   organization: Organization;
   CreatedByUserId: number;
   CreatedByUser: User;
   email: string;
   CreatedDate: string;
   ExperationDate: string;
   State: OrganizationInviteState;
}
