

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
   createdByUserId: string;
   usersId: string[];
   instancesId: number[];
   notificationsId: number[];
}



