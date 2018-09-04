import { Injectable } from '@angular/core';
import { MessageService } from 'primeng/api';

import { Message } from '../../shared/models/message.model';
import { Notification } from '../../shared/models/notification.model';

@Injectable()
export class SystemToastrService {

    constructor(private messageService: MessageService) { }

    send(notification: Notification) {
        this.messageService.add(
            {
                key: 'system-message',
                life: 8000,
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
}
