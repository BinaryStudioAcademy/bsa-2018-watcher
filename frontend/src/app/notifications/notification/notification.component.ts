import { Component, OnInit } from '@angular/core';
import {NotificationsService} from '../../core/services/notifications.service';

@Component({
  selector: 'app-notification',
  templateUrl: './notification.component.html',
  styleUrls: ['./notification.component.sass']
})
export class NotificationComponent implements OnInit {

  constructor(private notificationsService: NotificationsService) { }

  ngOnInit() {
  }

  send(): void {
    this.notificationsService.send('someUserId', 'Message');
  }
  sendMessage(): void {
    this.notificationsService.sendMessage('Qew');
  }
}
