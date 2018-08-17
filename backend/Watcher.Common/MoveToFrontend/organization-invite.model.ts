
import { Organization } from './organization.model';
import { User } from './user.model';
import { User } from './user.model';
import { OrganizationInviteState } from './organization-invite-state.enum';

export interface OrganizationInvite  {
   id: number;
   link: string;
   organizationId: number;
   organization: Organization;
   createdDate: Date;
   experationDate: Date;
   inviteEmail: string;
   invitedUserId: string;
   invitedUser: User;
   createdByUserId: string;
   createdByUser: User;
   state: OrganizationInviteState;
}



