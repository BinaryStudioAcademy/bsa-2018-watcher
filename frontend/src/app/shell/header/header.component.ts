import { Component, OnInit, EventEmitter } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { Router } from '@angular/router';

import { PathService } from '../../core/services/path.service';
import { MessageService } from 'primeng/api';
import { AuthService } from '../../core/services/auth.service';
import { UserService } from '../../core/services/user.service';
import { ToastrService } from '../../core/services/toastr.service';

import { Organization } from '../../shared/models/organization.model';
import { User } from '../../shared/models/user.model';


@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.sass'],
  providers: [MessageService]
})
export class HeaderComponent implements OnInit {

  onDisplayNotificationBlock = new EventEmitter<boolean>();
  isNotificationBlockShow: boolean;
  unreadedNotification = 0;

  currentUser: User;
  currentOrganizationName: string;

  userItems: MenuItem[];
  adminItems: MenuItem[];
  cogItems: MenuItem[];
  orgItems: MenuItem[];
  displayAddNewOrganization = false;

  constructor(
    private userService: UserService,
    private toastrService: ToastrService,
    private router: Router,
    private authService: AuthService,
    private pathService: PathService) { }

  onFeedback(): void {
    this.router.navigate(['/user/feedback']);
  }

  bellClick(): void {
    this.isNotificationBlockShow = !this.isNotificationBlockShow;
    this.onDisplayNotificationBlock.emit(this.isNotificationBlockShow);

    if (this.isNotificationBlockShow) {
      this.forceActiveButtonState('bell-button');
    } else {
      this.removeActiveButttonState('bell-button');
      return;
    }
  }

  changeCounter(number) {
    this.unreadedNotification = number;
  }

  closeNotificationBlock() {
    this.isNotificationBlockShow = false;
    this.onDisplayNotificationBlock.emit(this.isNotificationBlockShow);
    this.removeActiveButttonState('bell-button');
  }

  forceActiveButtonState(id: string): void {
    const btn = document.getElementById(id);
    btn.style.backgroundColor = '#0088f3';
  }

  removeActiveButttonState(id: string): void {
    const btn = document.getElementById(id);
    btn.style.backgroundColor = '#313232';
  }

  logout(): void {
    if (this.authService.isLoggedIn()) {
      this.authService.logout();
    }
  }

  userpage(): void {
    this.router.navigate(['/user/settings/user-profile']);
  }

  ngOnInit() {
    this.adminItems = [{
      label: 'Organizations',
      icon: 'fa fa-fw fa-list',
      routerLink: ['/admin/organization-list']
    }, {
      label: 'Users',
      icon: 'fa fa-fw fa-group',
      routerLink: ['/admin/user-list']
    }, {
      label: 'Feedbacks',
      icon: 'fa fa-fw fa-bullhorn',
      routerLink: ['/admin/feedback-list']
    }];

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
        this.currentUser.photoURL = this.pathService.convertToUrl(this.currentUser.photoURL);
        this.fillOrganizations();
      }
    );
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

  isAdmin() {
    if (this.currentUser.role.name === 'Admin') {
      return true;
    }
    return false;
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
