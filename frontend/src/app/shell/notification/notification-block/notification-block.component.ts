import { Component,
         OnInit,
         ViewChild,
         ComponentFactoryResolver,
         ViewContainerRef } from '@angular/core';

import { NotificationComponent } from '../notification/notification.component';
import { NotificationsHubService } from '../../../core/hubs/notifications.hub';

@Component({
  selector: 'app-notification-block',
  templateUrl: './notification-block.component.html',
  styleUrls: ['./notification-block.component.sass']
})
export class NotificationBlockComponent implements OnInit {

  @ViewChild('parent', { read: ViewContainerRef }) container: ViewContainerRef;

  constructor(private _cfr: ComponentFactoryResolver,
              private notificationHub: NotificationsHubService) { }

  ngOnInit() {
  }

  addComponent() {
      const comp = this._cfr.resolveComponentFactory(NotificationComponent);
      const expComponent = this.container.createComponent(comp);
      expComponent.instance._ref = expComponent;
  }

}
