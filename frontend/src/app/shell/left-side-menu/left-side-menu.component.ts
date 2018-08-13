import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { Router, RouterEvent, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-left-side-menu',
  templateUrl: './left-side-menu.component.html',
  styleUrls: ['./left-side-menu.component.sass']
})
export class LeftSideMenuComponent implements OnInit {

  constructor(private router: Router) { }

  private activeUrl: String;
  private settingsItems: MenuItem[];
  private dashboardItems: MenuItem[];

  private regexSettingsUrl = /\/user\/settings/;
  private regexDashboardUrl = /\/user(\/dashboards)?/;

  isSearching: boolean;
  menuItems: MenuItem[];

  ngOnInit() {
    this.activeUrl = this.router.url;
    this.initMenuItems();

    this.changeMenu();

    this.subscribeRouteChanges();
  }

  initMenuItems() {
    this.settingsItems = [{
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

    this.dashboardItems = [{
      label: 'Create Instance',
      icon: 'pi pi-pw pi-plus',
    }, {
      label: 'Instance1',
      icon: 'fa fa-fw fa-hdd-o'
    }, {
      label: 'Instance2',
      icon: 'fa fa-fw fa-hdd-o'
    }];
  }

  subscribeRouteChanges() {
    this.router.events.subscribe((event: RouterEvent) => {
      if (event.url) {
          this.activeUrl = event.url;
          this.changeMenu();
      }
  });
  }

  changeMenu() {
    if (this.activeUrl.match(this.regexSettingsUrl)) {
      this.menuItems = this.settingsItems;
      this.isSearching = false;
    } else if (this.activeUrl.match(this.regexDashboardUrl)) {
      this.menuItems = this.dashboardItems;
      this.isSearching = true;
    }
  }

}
