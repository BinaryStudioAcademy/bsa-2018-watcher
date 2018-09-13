import {Component, OnInit} from '@angular/core';
import {AfterContentChecked, AfterViewChecked} from '@angular/core';
import {NavigationStart} from '@angular/router';
import {Router, RouterEvent} from '@angular/router';
import {MenuItem} from 'primeng/api';

@Component({
  selector: 'app-left-side-menu',
  templateUrl: './left-side-menu.component.html',
  styleUrls: ['./left-side-menu.component.sass']
})

export class LeftSideMenuComponent implements OnInit, AfterContentChecked, AfterViewChecked {
  private activeUrl: string;
  private previousSettingUrl: string;
  private settingsItems: MenuItem[];
  private adminItems: MenuItem[];

  private regexSettingsUrl: RegExp = /\/user\/settings/;
  private regexFeedbackUrl: RegExp = /\/user\/feedback/;
  private regexAdminUrl: RegExp = /\/admin/;

  isComponentInvisible: boolean;
  menuItems: MenuItem[];

  constructor(private router: Router) {
    router.events.forEach((event) => {
      if (event instanceof NavigationStart) {
        this.clearSettings(this.activeUrl);
      }
    });
  }

  ngOnInit(): void {
    this.activeUrl = this.router.url;
    this.initMenuItems();
    this.changeMenu();
    this.subscribeRouteChanges();
  }

  ngAfterContentChecked(): void {
    this.highlightCurrentSetting();
  }

  ngAfterViewChecked(): void {
    this.highlightCurrentSetting();
  }

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
      label: 'Members',
      icon: 'fa fa-fw fa-users',
      routerLink: [`/user/settings/organization-members`],
    }, {
      label: 'Notification Settings',
      icon: 'fa fa-fw fa-send',
      routerLink: ['/user/settings/notification-settings']
    }];

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
    }, {
      label: 'DataCollector',
      icon: 'fa fa-fw fa-download',
      routerLink: ['/admin/data-collector-apps']
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
    if (this.checkRoute(this.regexSettingsUrl)) {
      this.menuItems = this.settingsItems;
      this.isComponentInvisible = false;
      return;
    }

    if (this.checkRoute(this.regexAdminUrl)) {
      this.menuItems = this.adminItems;
      this.isComponentInvisible = false;
      return;
    }

    if (this.checkRoute(this.regexFeedbackUrl)) {
      this.isComponentInvisible = true;
      this.menuItems = this.settingsItems;
      return;
    }
  }

  private checkRoute(regex: RegExp): boolean {
    return !!(this.activeUrl.match(regex));
  }

  private clearSettings(url: string): void {
    if (this.activeUrl !== this.previousSettingUrl) {

      const setting = this.getSettingByUrl(url);

      if (setting) {
        setting.classList.remove('ui-state-active');
        setting.parentElement.classList.remove('ui-state-active');
        this.previousSettingUrl = this.activeUrl;
      }
    }
  }

  private highlightCurrentSetting(): void {
    const setting = this.getSettingByUrl(this.activeUrl);

    if (setting) {
      this.clearSettings(this.previousSettingUrl);

      setting.classList.add('ui-state-active');
      setting.parentElement.classList.add('ui-state-active');
    }
  }

  private getSettingByUrl(url: string): Element {
    return document.querySelector(`div.ui-panelmenu-header a[href="${url}"]`);
  }
}
