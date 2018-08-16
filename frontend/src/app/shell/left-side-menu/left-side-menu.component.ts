import { Component, OnChanges, OnInit, AfterContentInit, AfterContentChecked , AfterViewInit, AfterViewChecked} from '@angular/core';
import { MenuItem } from 'primeng/api';
import { NavigationStart, Router, RouterEvent } from '@angular/router';

@Component({
  selector: 'app-left-side-menu',
  templateUrl: './left-side-menu.component.html',
  styleUrls: ['./left-side-menu.component.sass']
})

export class LeftSideMenuComponent implements OnChanges, OnInit, AfterContentInit, AfterContentChecked , AfterViewInit, AfterViewChecked {

  constructor(private router: Router) {
    router.events.forEach((event) => {
      if (event instanceof NavigationStart ) {
        this.clearCurrentSetting();
      }
    });
   }

  private activeUrl: string;
  private previousSettingUrl: string;
  private settingsItems: MenuItem[];
  private dashboardItems: MenuItem[];

  private regexSettingsUrl = /\/user\/settings/;
  private regexFeedbackUrl = /\/user\/feedback/;
  private regexDashboardUrl = /\/user(\/dashboards)?/;

  isSearching: boolean;
  isFeedback: boolean;
  menuItems: MenuItem[];

   ngOnChanges() { debugger; }

  ngOnInit() {
    this.activeUrl = this.router.url;
    this.initMenuItems();

    this.changeMenu();

    this.subscribeRouteChanges();
  }

  ngAfterContentInit() { debugger; }

  ngAfterContentChecked()  { this.highlightCurrentSetting(); }

  ngAfterViewInit() { debugger; }

  ngAfterViewChecked() { this.highlightCurrentSetting(); }

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
    if (this.activeUrl !== this.previousSettingUrl) {
      const element = this.getSettingByUrl(this.activeUrl);
      if ( element !== null ) {
        this.clearSettings(element);
        this.previousSettingUrl = this.activeUrl;
      }
    }
  }

  private clearPreviousSetting() {
    const element = this.getSettingByUrl(this.previousSettingUrl);
    if ( element !== null && element !== null && this.activeUrl !== this.previousSettingUrl) {
      this.clearSettings(element);
    }
  }

  private clearSettings(element: Element) {
    element.classList.remove('ui-state-active');
    element.parentElement.classList.remove('ui-state-active');
  }

  private highlightCurrentSetting(): void {
    const element = this.getSettingByUrl(this.activeUrl);

    if ( element !== null && element !== undefined) {
      this.clearPreviousSetting();

      element.classList.add('ui-state-active');
      element.parentElement.classList.add('ui-state-active');
    }
  }

  private getSettingByUrl(url: string): Element {
    return document.querySelector(`div.ui-panelmenu-header a[href="${url}"]`);
  }
}
