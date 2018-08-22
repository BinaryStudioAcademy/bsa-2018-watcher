
import { Organization } from './organization.model';

import { OrganizationInviteState } from './organization-invite-state.enum';
import { User } from './user.model';

export interface OrganizationInvite  {
   id: number;
   link: string;
   organizationId: number;
   organization: Organization;
   createdByUserId: string;
   createdByUser: User;
   inviteEmail: string;
   invitedUserId: string;
   createdDate: string;
   experationDate: string;
   state: OrganizationInviteState;
}
