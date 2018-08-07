
 import { Theme } from './theme';
import { Chat } from './chat';
import { UserOrganization } from './user-organization';
import { Instance } from './instance';
import { Notification } from './notification';

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



