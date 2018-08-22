import { Component,
         OnInit,
         ViewChild,
         ComponentFactoryResolver,
         ViewContainerRef,
         ComponentRef } from '@angular/core';

import { NotificationComponent } from '../notification/notification.component';
import { NotificationsHubService } from '../../core/hubs/notifications.hub';
import { Notification } from '../../shared/models/notification.model';
import { NotificationType } from '../../shared/models/notification-type.enum';

@Component({
  selector: 'app-notification-block',
  templateUrl: './notification-block.component.html',
  styleUrls: ['./notification-block.component.sass']
})
export class NotificationBlockComponent implements OnInit {

  @ViewChild('parent', { read: ViewContainerRef }) container: ViewContainerRef;

  constructor(private _cfr: ComponentFactoryResolver,
    private notificationsHubService: NotificationsHubService) {
      this.subscribeToNotificationsEvents();
  }

  ngOnInit() {
  }

  private subscribeToNotificationsEvents(): void {
    this.notificationsHubService.notificationReceived.subscribe((value: Notification) => {
      console.log('message');
      value.type = NotificationType[value.notificationSetting.type].toLowerCase();

      if (value.type === 'chat') {
        return;
      }

      const component = this.addComponent(value);
      this.destroyTimeout(component);
    });
  }

  addComponent(notification: Notification): ComponentRef<NotificationComponent> {
      const comp = this._cfr.resolveComponentFactory(NotificationComponent);
      const expComponent = this.container.createComponent(comp);
      expComponent.instance.notification = notification;

      return expComponent;
  }

  destroyTimeout(component: ComponentRef<NotificationComponent>): void {
    setTimeout(() => {
      component.destroy();
    }, 3000);
  }

}
