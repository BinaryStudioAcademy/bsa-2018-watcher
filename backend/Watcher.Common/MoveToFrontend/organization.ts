
 
    export interface Organization { 
        id: number;
        name: string;
        themeId: number;
        theme: Theme;
        chat: Chat;
        userOrganizations: UserOrganization[];
        instances: Instance[];
        notifications: Notification[];
    }



