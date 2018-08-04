import { Component, OnInit } from '@angular/core';
import {NotificationsService} from '../services/notifications.service';

@Component({
  selector: 'app-notification',
  templateUrl: './notification.component.html',
  styleUrls: ['./notification.component.sass']
})
export class NotificationComponent implements OnInit {

  constructor(private notificationsService: NotificationsService) { }

  ngOnInit() {
  }

  send() {
    this.notificationsService.send('Qew');
  }
  sendMessage() {
    this.notificationsService.sendMessage('Qew');
  }
}
