import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

import { NotificationsHubService } from '../../core/hubs/notifications.hub';
import { NotificationService } from '../../core/services/notification.service';
import { AuthService } from '../../core/services/auth.service';
import { SystemToastrService } from '../../core/services/system-toastr.service';

import { NotificationType } from '../../shared/models/notification-type.enum';
import { Notification } from '../../shared/models/notification.model';
import { Router } from '@angular/router';


@Component({
  selector: 'app-notification-block',
  templateUrl: './notification-block.component.html',
  styleUrls: [
    './notification-block.component.sass',
    '../system-notification/system-notification.component.sass'
  ]
})
export class NotificationBlockComponent implements OnInit {

  @Output() counterChanged = new EventEmitter<number>();

  private _unreadedNotifications = 0;

  notifications: Notification[] = [];
  type = NotificationType;
  isLoading: Boolean = false;

  constructor(
    private notificationsHubService: NotificationsHubService,
    private authService: AuthService,
    private notificationsService: NotificationService,
    private systemToastrService: SystemToastrService,
    private router: Router) { }

  ngOnInit() {
    this.loadNotifications();
    this.subscribeToEvents();
  }

  get notificationCounter() {
    return this._unreadedNotifications;
  }

  set notificationCounter(value: number) {
    this._unreadedNotifications = value;
    this.counterChanged.emit(value);
  }

  private subscribeToEvents(): void {
    this.notificationsHubService.notificationReceived.subscribe((value: Notification) => {
      if (!value.notificationSetting.isDisable) {
        this.notificationCounter++;
        if (!value.notificationSetting.isMute) {
          this.systemToastrService.send(value);
        }
      }
      this.notifications.unshift(value);
    });

    this.notificationsHubService.notificationDeleted.subscribe((value: Notification) => {
      const index = this.notifications.findIndex(item => item.id === value.id);
      this.notifications.splice(index, 1);
    });
  }

  loadNotifications(): void {
    this.isLoading = true;
    this.notificationsService.getAll(this.authService.getCurrentUser().id).subscribe((value: Notification[]) => {
      this.notifications = value;
      this.notificationCounter = this.calcNotReadNotifications(value);
      this.isLoading = false;
      console.log(this.isLoading);
    });
  }

  calcNotReadNotifications(allNotifications: Notification[]): number {
    return allNotifications.filter(item => !item.wasRead).length;
  }

  markAsReadAll(): void {
    this.notificationCounter = 0;
    let notReadNotifications: Notification[];

    notReadNotifications = this.notifications.filter(item => !item.wasRead);
    notReadNotifications.forEach(item => item.wasRead = true);

    this.notificationsService.updateAll(notReadNotifications).subscribe();
  }

  markAsRead(id: number): void {
    this.notificationCounter--;
    const notify = this.notifications.find(item => item.id === id);
    notify.wasRead = true;
    this.notificationsService.update(id, notify).subscribe();
  }

  remove(id: number): void {
    const notify = this.notifications.find(item => item.id === id);
    if (!notify.wasRead) {
      this.notificationCounter--;
    }

    const index = this.notifications.findIndex(item => item.id === id);
    this.notifications.splice(index, 1);
    this.notificationsHubService.delete(notify);
  }

  redirectToInstance(notification): void {
    const url = [`/user/instances/${notification.instanceId}/${notification.instanceGuidId}/dashboards`];
    this.router.navigate(url);
  }
}
