import { Theme } from './theme.model';
import { Instance } from './instance.model';
import { Notification } from './notification.model';

export interface Organization  {
   id: number;
   name: string;
   description: string;
   email: string;
   webSite: string;
   contactNumber: string;
   isActive: boolean;
   imageURL: string;
   themeId: number;
   theme: Theme;
   chatId: number;
   createdByUserId: string;
   usersId: string[];
   instances: Instance[];
   notifications: Notification[];
}



