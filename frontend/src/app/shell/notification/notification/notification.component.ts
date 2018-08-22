import { Component, OnInit, OnDestroy } from '@angular/core';
import { NotificationsHubService } from '../../../core/hubs/notifications.hub';
import { Notification } from '../../../shared/models/notification.model';

@Component({
  selector: 'app-notification',
  templateUrl: './notification.component.html',
  styleUrls: ['./notification.component.sass']
})
export class NotificationComponent implements OnInit, OnDestroy {

  fadeOut: boolean;
  notification: Notification;

  ngOnInit() {
  }

  ngOnDestroy() {
  }

}
