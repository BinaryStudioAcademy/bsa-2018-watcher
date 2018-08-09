
 import { Instance } from './instance';
import { Notification } from './notification';

    export interface Organization  { 
        id: number;
        name: string;
        description: string;
        email: string;
        webSite: string;
        contactNumber: string;
        isActive: boolean;
        themeId: number;
        chatId: number;
        createdByUserId: number;
        usersId: number[];
        instances: Instance[];
        notifications: Notification[];
    }



