import { NotificationType } from '../enums/notificationType';

export class NotificationSetting {
    constructor(
        public id: number,
        public type: NotificationType,
        public isMute: boolean,
        public isDisable: boolean) {
    }
}  
