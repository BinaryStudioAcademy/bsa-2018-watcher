import { Component, OnInit } from '@angular/core';
import { MenuItem, Message } from 'primeng/api';
import { SampleRequest } from '../../shared/models/sample-request.model';
import { SampleEnum } from '../../shared/models/sample-enum.enum';
import { SampleDto } from '../../shared/models/sample-dto.model';
import { MessageService } from 'primeng/api';
import { AuthService } from '../../core/services/auth.service';
import { Organization } from '../../shared/models/organization.model';
import { UserService } from '../../core/services/user.service';
import { User } from '../../shared/models/user.model';
import { ToastrService } from '../../core/services/toastr.service';
import { Router, RouterEvent, ActivatedRoute } from '@angular/router';
import { NotificationService } from '../../core/services/notification.service';
import { Notification } from '../../shared/models/notification.model';
import { NotificationType } from '../../shared/models/notification-type.enum';
import {NotificationsHubService} from '../../core/hubs/notifications.hub';
import { PathService } from '../../core/services/path.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.sass'],
  providers: [MessageService]
})
export class HeaderComponent implements OnInit {
  canCreateSample = false;
  msgs: Message[] = [];
  samples: SampleDto[] = [];
  notificationsNumber = 0;
  messagesNumber = 2;
  isNotificationShow: boolean;

  currentUser: User;

  userItems: MenuItem[];
  cogItems: MenuItem[];
  orgItems: MenuItem[];
  notifications: Notification[];
  displayAddNewOrganization = false;

  constructor(private notificationsHubService: NotificationsHubService,
    private messageService: MessageService,
    private userService: UserService,
    private toastrService: ToastrService,
    private router: Router,
    private authService: AuthService,
    private notificationsService: NotificationService,
    private pathService: PathService) {
      this.conectToNotificationsHub();
      this.subscribeToNotificationsEvents();
  }

  onFeedback(): void {
    this.router.navigate(['/user/feedback']);
  }

  private conectToNotificationsHub(): void {
    this.notificationsHubService.connectToSignalR();
  }

  private subscribeToNotificationsEvents(): void {
    this.notificationsHubService.notificationReceived.subscribe((value: Notification) => {
      value.type = NotificationType[value.notificationSetting.type].toLowerCase();

      if (NotificationType[value.notificationSetting.type] !== 'Chat' && !value.notificationSetting.isMute) {
        this.notificationsNumber++;
      }
      this.notifications.unshift(value);
    });
  }

  bellClick(): void {
    this.isNotificationShow = !this.isNotificationShow;
    if (!this.isNotificationShow) { return; }

    this.notificationsToItems();
  }

  notificationsToItems(): void {
    this.notifications = [];
    this.notificationsService.getAll(this.authService.getCurrentUser().id).subscribe((value: Notification[]) => {
      this.notificationsNumber = this.calcNotReadNotification(value);

      value.forEach(item => {
        item.type = NotificationType[item.notificationSetting.type].toLowerCase();
        if (item.type !== 'chat')  {
          this.notifications.unshift(item);
        }
      });
    });
  }

  calcNotReadNotification(allNotifications: Notification[]): number {
    return allNotifications.filter(item => item.wasRead === false &&
                                  item.notificationSetting.isMute === false &&
                                  NotificationType[item.notificationSetting.type] !== 'Chat').length;
  }

  markAsRead(): void {
    let notReadNotifications: Notification[];

    notReadNotifications = this.notifications.filter(item => item.wasRead === false);
    notReadNotifications.forEach(item => {
      item.wasRead = true;
      this.notificationsService.update(item.id, item).subscribe(value => this.notificationsNumber--);
    });
  }

  close(): void {
    this.isNotificationShow = false;
  }

  // TODO: methods for SignalR Tests
  createSample(): void {
    const req: SampleRequest = {
      name: 'Test',
      count: 12,
      dateOfCreation: new Date(2017, 1, 1),
      sampleField: SampleEnum.FirstItem
    };

    this.notificationsHubService.createSample(req);
  }

  echoToServer() {
    this.notificationsHubService.echo();
  }

  sendMess() {
    this.notificationsHubService.send('in2Kvey8O0dK1LACXH6HYMaPG102', 'From Sdadadafsd message');
  }

  connectToServer() {
    this.notificationsHubService.connectToSignalR();
  }

  ngOnInit() {
    this.userItems = [
      {
        label: 'Admin',
        icon: 'fa fa-fw fa-user',
        routerLink: ['/admin/organization-list'],
      },
      {
        label: 'Logout',
        icon: 'fa fa-fw fa-sign-out',
        command: (onclick) => {
          if (this.authService.isLoggedIn()) {
            this.authService.logout();
          }
        }
      }
    ];

    this.cogItems = [{
      label: 'Profile',
      icon: 'fa fa-fw fa-user',
      routerLink: ['/user/settings/user-profile'],
    },
    {
      label: 'Organization',
      icon: 'fa fa-fw fa-building',
      routerLink: ['/user/settings/organization-profile'],
    },
    {
      label: 'Notifications',
      icon: 'fa fa-fw fa-send',
      routerLink: ['/user/settings/notification-settings'],
    }
    ];

    this.authService.currentUser.subscribe(
      userData => {
        this.currentUser = { ...userData };
        // this.currentUser.photoURL = this.pathService.convertToUrl(this.currentUser.photoURL);   // error
        this.fillOrganizations();
      }
    );

    this.notificationsToItems();
  }

  private fillOrganizations(): void {
    this.orgItems = new Array<MenuItem>();

    this.currentUser.organizations.forEach(element => {
      this.orgItems.push({
        label: element.name,
        id: element.id.toString(),
        icon: 'fa fa-fw fa-building',
        command: (onclick) => { this.chengeLastPicOrganizations(element); },
        styleClass: (element.id === this.currentUser.lastPickedOrganizationId) ? 'selectedMenuItem' : '',
        disabled: (element.id === this.currentUser.lastPickedOrganizationId)
      });
    });
    this.orgItems.push({
      label: 'Add new',
      icon: 'fa fa-fw fa-plus',
      command: (onclick) => { this.addNewOrganization(); },
    });

  }

  onDisplayChange(event: boolean) {
    this.displayAddNewOrganization = event;
  }

  addNewOrganization() {
    this.displayAddNewOrganization = true;
  }


  private chengeLastPicOrganizations(item: Organization): void {
    // update user in beckend
    this.userService.updateLastPickedOrganization(this.currentUser.id, item.id)
      .subscribe(value => {
        // update user in frontend

        this.currentUser.lastPickedOrganizationId = item.id;
        this.currentUser.lastPickedOrganization = item;
        this.authService.updateCurrentUser(this.currentUser); // update user in localStorage
        // notify user about changes
        this.toastrService.success(`Organization by defaul was updated. Curent organization: "${item.name}"`);
      },
        err => {
          this.toastrService.error('Organization by defaul was not updated.');
      });
  }
}
