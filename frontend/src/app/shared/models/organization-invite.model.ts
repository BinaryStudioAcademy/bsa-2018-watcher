
import { Organization } from './organization.model';
import { User } from 'firebase';
import { OrganizationInviteState } from './organization-invite-state.enum';

export interface OrganizationInvite  {
   id: number;
   link: string;
   organizationId: number;
   organization: Organization;
   createdByUserId: string;
   createdByUser: User;
   inviteEmail: string;
   createdDate: string;
   experationDate: string;
   state: OrganizationInviteState;
}
