
import { Theme } from './theme.model';
import { Chat } from './chat.model';
import { UserOrganization } from './user-organization.model';
import { Instance } from './instance.model';
import { Notification } from './notification.model';

export interface Organization  {
   id: number;
   name: string;
   themeId: number;
   theme: Theme;
   chat: Chat;
   userOrganizations: UserOrganization[];
   instances: Instance[];
   notifications: Notification[];
}



