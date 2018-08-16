import { NotificationType } from './notification-type.enum';


export interface NotificationSetting {
    id: number;
    type: NotificationType;
    isMute: boolean;
    isDisable: boolean;
    isEmailable: boolean;
    userId: string;
}
