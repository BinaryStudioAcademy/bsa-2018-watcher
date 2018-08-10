import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.sass']
})
export class SettingsComponent implements OnInit {

constructor() { }

menuItems: MenuItem[];

  ngOnInit() {
    this.menuItems = [{
        label: 'User Profile',
        icon: 'fa fa-fw fa-user',
        routerLink: ['/user/settings/user-profile']
      }, {
        label: 'Organization Profile',
        icon: 'fa fa-fw fa-building',
        routerLink: ['/user/settings/organization-profile']
      }, {
        label: 'Notification Settings',
        icon: 'fa fa-fw fa-send',
        routerLink: ['/user/settings/notification-settings']
      }];
  }
}
