
 import { NotificationType } from './notification-type';

    export interface NotificationSetting  { 
        id: number;
        type: NotificationType;
        isMute: boolean;
        isDisable: boolean;
    }



