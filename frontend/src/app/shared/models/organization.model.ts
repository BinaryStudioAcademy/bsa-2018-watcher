import { Notification } from './notification.model';
import { Theme } from './theme.model';

export interface Organization  {
   id: number;
   name: string;
   description: string;
   email: string;
   webSite: string;
   contactNumber: string;
   isActive: boolean;
   themeId: number;
   theme: Theme;
   chatId: number;
   createdByUserId: string;
   usersId: string[];
   instancesId: number[];
   notifications: Notification[];
}



