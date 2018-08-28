import { Injectable } from '@angular/core';
import { MessageService } from 'primeng/api';

import { Message } from '../../shared/models/message.model';
import { Notification } from '../../shared/models/notification.model';
import { NotificationType } from '../../shared/models/notification-type.enum';

@Injectable()
export class SystemToastrService {

    constructor(private messageService: MessageService) { }

    private systemNotify(notification: Notification, severity: string) {
        this.messageService.add(
            {
                key: 'system-message',
                life: 8000,
                severity: severity,
                data: notification
            }
        );
    }

    chat(message: Message): void {
        this.messageService.add(
            {
                key: 'system-message',
                life: 8000,
                severity: 'chat',
                data: message
            }
        );
    }

    send(notification: Notification) {
        if (!notification) {
            return;
        }

        switch (notification.notificationSetting.type) {
            case NotificationType.Error:
                this.systemNotify(notification, 'error');
                break;

            case NotificationType.Warning:
                this.systemNotify(notification, 'warning');
                break;

            case NotificationType.Info:
                this.systemNotify(notification, 'info');
                break;

            default:
                this.systemNotify(notification, 'info');
                break;
        }
    }
}
