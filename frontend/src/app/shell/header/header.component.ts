import { Component, OnInit } from '@angular/core';
import { MenuItem, Message } from 'primeng/api';
import { NotificationsHubService } from '../../core/services/notifications-hub.service';
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
  bellItems: MenuItem[];
  orgItems: MenuItem[];

  constructor(private notificationsHubService: NotificationsHubService,
    private messageService: MessageService,
    private userService: UserService,
    private toastrService: ToastrService,
    private router: Router,
    private authService: AuthService,
    private notificationsService: NotificationService) {
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
      this.notificationsNumber++;
      this.bellItems.push({
        label: value.text
      });
    });
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
        this.currentUser = userData;
        if (this.currentUser && this.currentUser.organizations && this.currentUser.organizations.length > 0) {
          this.fillOrganizations();
        }
      }
    );

    this.notificationsToItems();
  }

  bellClick() {
    this.isNotificationShow = !this.isNotificationShow;
    if (!this.isNotificationShow) { return; }

    this.notificationsToItems();
  }

  notificationsToItems() {
    this.bellItems = [];
    this.notificationsService.getAll(this.authService.getCurrentUser().id).subscribe((value: Notification[]) => {
      this.notificationsNumber = value.length;

      value.forEach(item => {
        this.bellItems.push({
          label: item.text
        });
      });
    });
  }

  close() {
    this.isNotificationShow = false;
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
  }

  private chengeLastPicOrganizations(item: Organization): void {
    // update user in beckend
    this.userService.updateLastPickedOrganization(this.currentUser.id, item.id)
      .subscribe(value => {
        // update user in frontend

        this.currentUser.lastPickedOrganizationId = item.id;
        this.currentUser.lastPickedOrganization = item;
        this.authService.updateCurrentUser(this.currentUser); // update user in localStorage
        this.fillOrganizations();
        // notify user about changes
        this.toastrService.success(`Organization by defaul was updated. Curent organization: "${item.name}"`);
      },
        err => {
          this.toastrService.error('Organization by defaul was not updated.');
        });
  }
}
