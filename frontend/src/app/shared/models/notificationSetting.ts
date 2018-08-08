import { NotificationType } from '../enums/notificationType';

export interface NotificationSetting {
    id: number;
    type: NotificationType;
    isMute: boolean;
    isDisable: boolean;
}
