import { Component, OnChanges, OnInit, AfterContentInit, AfterContentChecked, AfterViewInit,
  AfterViewChecked, OnDestroy } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { NavigationStart, Router, RouterEvent } from '@angular/router';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-left-side-menu',
  templateUrl: './left-side-menu.component.html',
  styleUrls: ['./left-side-menu.component.sass']
})

export class LeftSideMenuComponent implements OnInit, AfterContentInit, AfterContentChecked,
  AfterViewInit, AfterViewChecked {

  constructor(private router: Router) {
    router.events.forEach((event) => {
      if (event instanceof NavigationStart ) {
        this.clearCurrentSetting();
      }
    });
   }

  private activeUrl: String;
  private previousSettingUrl: String;
  private settingsItems: MenuItem[];
  private dashboardItems: MenuItem[];

  private navigationSub: Subscription;

  private regexSettingsUrl = /\/user\/settings/;
  private regexFeedbackUrl = /\/user\/feedback/;
  private regexDashboardUrl = /\/user(\/dashboards)?/;

  isSearching: boolean;
  isFeedback: boolean;
  menuItems: MenuItem[];

  ngOnInit() {
    this.activeUrl = this.router.url;
    this.initMenuItems();

    this.changeMenu();

    this.subscribeRouteChanges();



  }

  ngAfterContentInit()  {
    // const element = document.querySelector(`div.ui-panelmenu-header a[href="${this.activeUrl}"]`);

    // if ( element !== null && element !== undefined) {
    //   this.clearPreviousSetting();
    //   // debugger;
    //   element.classList.add('ui-state-active');
    //   element.parentElement.classList.add('ui-state-active');
    // }
  }

  ngAfterContentChecked()  {
    const element = document.querySelector(`div.ui-panelmenu-header a[href="${this.activeUrl}"]`);

    if ( element !== null && element !== undefined) {
      this.clearPreviousSetting();
      // debugger;
      element.classList.add('ui-state-active');
      element.parentElement.classList.add('ui-state-active');
    }
  }

  ngAfterViewInit () {
    // const element = document.querySelector(`div.ui-panelmenu-header a[href="${this.activeUrl}"]`);

    // if ( element !== null && element !== undefined) {
    //   this.clearPreviousSetting();
    //   // debugger;
    //   element.classList.add('ui-state-active');
    //   element.parentElement.classList.add('ui-state-active');
    // }
  }

  ngAfterViewChecked()  {
    // const element = document.querySelector(`div.ui-panelmenu-header a[href="${this.activeUrl}"]`);

    // if ( element !== null && element !== undefined) {
    //   this.clearPreviousSetting();
    //   // debugger;
    //   element.classList.add('ui-state-active');
    //   element.parentElement.classList.add('ui-state-active');
    // }
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
      this.isFeedback = false;
    } else if (this.activeUrl.match(this.regexFeedbackUrl)) {
      this.isFeedback = true;
    } else if (this.activeUrl.match(this.regexDashboardUrl)) {
      this.menuItems = this.dashboardItems;
      this.isSearching = true;
      this.isFeedback = false;
    }
  }

  private clearCurrentSetting() {
    const element = document.querySelector(`div.ui-panelmenu-header a[href="${this.activeUrl}"]`);
    if ( element !== null) {
      debugger;
      this.previousSettingUrl = this.activeUrl;
      this.clearSettings(element);
    }
  }

  private clearPreviousSetting() {
    const element = document.querySelector(`div.ui-panelmenu-header a[href="${this.previousSettingUrl}"]`);
    if ( element !== null) {
      debugger;
      this.clearSettings(element);
    }
  }

  private clearSettings(element: Element) {
    element.classList.remove('ui-state-active');
    element.parentElement.classList.remove('ui-state-active');
  }

}
