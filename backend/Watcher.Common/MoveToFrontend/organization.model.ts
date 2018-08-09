
import { Theme } from './theme.model';
import { Notification } from './notification.model';

export interface Organization  {
   id: number;
   name: string;
   description: string;
   email: string;
   webSite: string;
   contactNumber: string;
   isActive: boolean;
   theme: Theme;
   chatId: number;
   createdByUserId: string;
   usersId: string[];
   instancesId: number[];
   notifications: Notification[];
}



