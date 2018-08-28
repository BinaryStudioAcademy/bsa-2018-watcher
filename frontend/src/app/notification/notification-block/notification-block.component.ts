import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

import { NotificationsHubService } from '../../core/hubs/notifications.hub';
import { NotificationService } from '../../core/services/notification.service';
import { AuthService } from '../../core/services/auth.service';

import { NotificationType } from '../../shared/models/notification-type.enum';
import { Notification } from '../../shared/models/notification.model';


@Component({
  selector: 'app-notification-block',
  templateUrl: './notification-block.component.html',
  styleUrls: [
    './notification-block.component.sass',
    '../system-notification/system-notification.component.sass'
  ]
})
export class NotificationBlockComponent implements OnInit {

  @Input() onDisplay: EventEmitter<boolean>;
  @Output() counterChanged = new EventEmitter<number>();

  private _unreadedNotifications = 0;
  visible: boolean;

  notifications: Notification[] = [];
  type = NotificationType;

  constructor(private notificationsHubService: NotificationsHubService,
    private authService: AuthService,
    private notificationsService: NotificationService) { }

  ngOnInit() {
    this.loadNotifications();
    this.notificationsHubService.connectToSignalR();
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
    this.onDisplay.subscribe((data: boolean) => {
      this.visible = data;
    });

    this.notificationsHubService.notificationReceived.subscribe((value: Notification) => {
      if (!value.notificationSetting.isDisable) {
        this.notificationCounter++;
      }
      this.notifications.unshift(value);
    });
  }

  loadNotifications(): void {
    this.notificationsService.getAll(this.authService.getCurrentUser().id).subscribe((value: Notification[]) => {
      this.notifications = value;
      this.notificationCounter = this.calcNotReadNotifications(value);
    });

    const not: Notification = {
      id: 2,
      createdAt: new Date(),
      text: 'Simple notify',
      type: NotificationType.Info,
      wasRead: false
    } as Notification;

    const not2: Notification = {
      id: 1,
      createdAt: new Date(),
      text: 'Simple notify2',
      type: NotificationType.Error,
      wasRead: true
    } as Notification;

    const not3: Notification = {
      id: 3,
      createdAt: new Date(),
      text: 'Simple notify3',
      type: NotificationType.Warning,
      wasRead: false
    } as Notification;

    this.notifications.push(not, not2, not3);
    this.notificationCounter = this.calcNotReadNotifications(this.notifications);
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
    const index = this.notifications.findIndex(item => item.id === id);
    if (!this.notifications[index].wasRead) {
      this.notificationCounter--;
    }
    this.notifications.splice(index, 1);
    // TODO: need add logic for operation
    // this.notificationsService.remove(id);
  }
}
