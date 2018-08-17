import {Component, OnInit} from '@angular/core';
import {MenuItem} from 'primeng/api';
import {Router, RouterEvent} from '@angular/router';
import {InstanceService} from '../../core/services/instance.service';
import {Instance} from '../../shared/models/instance.model';
import {ToastrService} from '../../core/services/toastr.service';
import {AuthService} from '../../core/services/auth.service';
import {AfterContentChecked, AfterViewChecked} from '@angular/core';
import {NavigationStart} from '@angular/router';

@Component({
  selector: 'app-left-side-menu',
  templateUrl: './left-side-menu.component.html',
  styleUrls: ['./left-side-menu.component.sass']
})

export class LeftSideMenuComponent implements OnInit, AfterContentChecked, AfterViewChecked {
  private activeUrl: string;
  private previousSettingUrl: string;
  private settingsItems: MenuItem[];
  private instanceItems: MenuItem[];
  private adminItems: MenuItem[];
  private organisationId: number;

  private regexSettingsUrl: RegExp = /\/user\/settings/;
  private regexFeedbackUrl: RegExp = /\/user\/feedback/;
  private regexInviteUrl: RegExp = /\/user\/invite/;
  private regexDashboardUrl: RegExp = /\/user(\/dashboards)?/;
  private regexInstancesUrl: RegExp = /\/user(\/instances)?/;
  private regexAdminUrl = /\/admin/;

  isSearching: boolean;
  isFeedback: boolean;
  isInvite: boolean;
  menuItems: MenuItem[];

  constructor(private router: Router,
              private instanceService: InstanceService,
              private toastrService: ToastrService,
              private authService: AuthService) {
    router.events.forEach((event) => {
      if (event instanceof NavigationStart) {
        this.clearSettings(this.activeUrl);
      }
    });
  }

  ngOnInit(): void {
    this.activeUrl = this.router.url;
    this.organisationId = this.authService.getCurrentUser().lastPickedOrganizationId;
    this.instanceService.instanceAdded.subscribe(instance => this.onInstanceAdded(instance));
    this.instanceService.instanceEdited.subscribe(instance => this.onInstanceEdited(instance));
    this.instanceService.instanceRemoved.subscribe(instance => this.onInstanceRemoved(instance));
    this.initMenuItems();
    this.configureInstances(this.organisationId);
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
      label: 'Notification Settings',
      icon: 'fa fa-fw fa-send',
      routerLink: ['/user/settings/notification-settings']
    }];

    this.instanceItems = [{
      label: 'Create Instance',
      icon: 'pi pi-pw pi-plus',
      routerLink: ['instances/create']
    }];

    this.adminItems = [{
      label: 'Organizations',
      icon: 'fa fa-fw fa-list'
      // routerLink: ['/user/settings/user-profile']
    }, {
      label: 'Users',
      icon: 'fa fa-fw fa-group'
      // routerLink: ['/user/settings/organization-profile']
    }, {
      label: 'Feedbacks',
      icon: 'fa fa-fw fa-bullhorn',
      routerLink: ['/admin/feedback-list']
    }];
  }

  configureInstances(organizationId: number) {
    this.instanceService.getAllByOrganization(organizationId).subscribe((data: Instance[]) => {
      if (data) {
        const items = data.map(inst => this.instanceToMenuItem(inst));
        items.forEach(inst => this.instanceItems.push(inst));
        this.toastrService.success('Get instances from server');
      }
    });
  }

  instanceToMenuItem(instance: Instance) {
    const item: MenuItem = {
      label: instance.title,
      title: instance.id.toString(),
      routerLink:  [`instances/${instance.id}/dashboards`],
      command: () => {
        // debugger;
        this.instanceService.instanceChecked.emit(instance);
        // this.router.navigate([`/user/instances/${instance.id}/dashboards`]);
      },
      items: [{
        label: 'Update',
        icon: 'fa fa-refresh',
        routerLink: [`instances/${instance.id}/edit`],
        styleClass: 'instance-options'
      }, {
        label: 'Delete',
        icon: 'fa fa-close',
        command: () => {
          const index = this.instanceItems.findIndex(i => i === item);
          this.deleteInstance(instance.id, index);
        },
        styleClass: 'instance-options'
      }, {
        label: 'Download app',
        icon: 'fa fa-download',
        routerLink: [`instances/${instance.id}/download`],
        styleClass: 'instance-options'
      }]
    };
    return item;
  }

  async deleteInstance(id: number, index: number) {
    if (await this.toastrService.confirm('You sure you want to delete this instance? ')) {
      this.instanceService.delete(id).subscribe((res: Response) => {
        this.instanceService.instanceRemoved.emit(id);
        this.toastrService.success('Deleted instance');
        this.instanceItems.splice(index, 1);
      });
    }
  }

  onInstanceAdded(instance: Instance) {
    const item: MenuItem = this.instanceToMenuItem(instance);
    this.instanceItems.push(item);
  }

  onInstanceRemoved(id: number) {
    // console.log(`id is ${id}`);
    // const index: number = this.instanceItems.findIndex(inst => inst.title === id.toString());
    // console.log(`index is ${index}`);
  }

  onInstanceEdited(instance: Instance) {
    const item: MenuItem = this.instanceToMenuItem(instance);
    const index: number = this.instanceItems.findIndex(inst => inst.title === instance.id.toString());
    this.instanceItems[index] = item;
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
      this.isInvite = false;
    } else if (this.activeUrl.match(this.regexFeedbackUrl)) {
      this.isFeedback = true;
    } else if (this.activeUrl.match(this.regexInviteUrl)) {
      this.isInvite = true;
      this.isInvite = false;
    } else if (this.activeUrl.match(this.regexAdminUrl)) {
      this.menuItems = this.adminItems;
      this.isSearching = false;
      this.isFeedback = false;
    } else if (this.activeUrl.match(this.regexDashboardUrl)) {
      this.menuItems = this.instanceItems;
      this.isSearching = true;
      this.isFeedback = false;
    }
  }

  private clearSettings(url: string): void {
    if (this.activeUrl !== this.previousSettingUrl) {

      const setting = this.getSettingByUrl(url);

      if (setting !== null) {
        setting.classList.remove('ui-state-active');
        setting.parentElement.classList.remove('ui-state-active');
        this.previousSettingUrl = this.activeUrl;
      }
    }
  }

  private highlightCurrentSetting(): void {
    const setting = this.getSettingByUrl(this.activeUrl);

    if (setting !== null) {
      this.clearSettings(this.previousSettingUrl);

      setting.classList.add('ui-state-active');
      setting.parentElement.classList.add('ui-state-active');
    }
  }

  private getSettingByUrl(url: string): Element {
    return document.querySelector(`div.ui-panelmenu-header a[href="${url}"]`);
  }
}
