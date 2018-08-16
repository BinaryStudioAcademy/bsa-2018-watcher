import { Component, OnInit, AfterContentChecked, AfterViewChecked} from '@angular/core';
import { MenuItem } from 'primeng/api';
import { NavigationStart, Router, RouterEvent } from '@angular/router';

@Component({
  selector: 'app-left-side-menu',
  templateUrl: './left-side-menu.component.html',
  styleUrls: ['./left-side-menu.component.sass']
})

export class LeftSideMenuComponent implements OnInit, AfterContentChecked , AfterViewChecked {

  constructor(private router: Router) {
    router.events.forEach((event) => {
      if (event instanceof NavigationStart ) {
        this.clearSettings(this.activeUrl);
      }
    });
   }

  private activeUrl: string;
  private previousSettingUrl: string;
  private settingsItems: MenuItem[];
  private dashboardItems: MenuItem[];

  private regexSettingsUrl: RegExp = /\/user\/settings/;
  private regexFeedbackUrl: RegExp = /\/user\/feedback/;
  private regexDashboardUrl: RegExp = /\/user(\/dashboards)?/;

  isSearching: boolean;
  isFeedback: boolean;
  menuItems: MenuItem[];

  ngOnInit(): void {
    this.activeUrl = this.router.url;
    this.initMenuItems();

    this.changeMenu();

    this.subscribeRouteChanges();
  }

  ngAfterContentChecked(): void { this.highlightCurrentSetting(); }

  ngAfterViewChecked(): void { this.highlightCurrentSetting(); }

  private initMenuItems(): void {
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

  private subscribeRouteChanges(): void {
    this.router.events.subscribe((event: RouterEvent) => {
      if (event.url) {
        this.activeUrl = event.url;
        this.changeMenu();
      }
    });
  }

  private changeMenu(): void {
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

  private clearSettings(url: string): void {
    if (this.activeUrl !== this.previousSettingUrl) {

      const setting = this.getSettingByUrl(url);

      if ( setting !== null ) {
        setting.classList.remove('ui-state-active');
        setting.parentElement.classList.remove('ui-state-active');
        this.previousSettingUrl = this.activeUrl;
      }
    }
  }

  private highlightCurrentSetting(): void {
    const setting = this.getSettingByUrl(this.activeUrl);

    if ( setting !== null ) {
      this.clearSettings(this.previousSettingUrl);

      setting.classList.add('ui-state-active');
      setting.parentElement.classList.add('ui-state-active');
    }
  }

  private getSettingByUrl(url: string): Element {
    return document.querySelector(`div.ui-panelmenu-header a[href="${url}"]`);
  }
}
