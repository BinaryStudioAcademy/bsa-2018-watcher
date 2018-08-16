import { Component, OnInit, Output } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { Router, RouterEvent, ActivatedRoute } from '@angular/router';
import { InstanceService } from '../../core/services/instance.service';
import { Instance } from '../../shared/models/instance.model';
import { ToastrService } from '../../core/services/toastr.service';
import { AuthService } from '../../core/services/auth.service';

@Component({
  selector: 'app-left-side-menu',
  templateUrl: './left-side-menu.component.html',
  styleUrls: ['./left-side-menu.component.sass']
})
export class LeftSideMenuComponent implements OnInit {

  constructor(private router: Router,
    private instanceService: InstanceService,
    private toastrService: ToastrService,
    private authService: AuthService) { }

  private activeUrl: String;
  private settingsItems: MenuItem[];
  private instanceItems: MenuItem[];
  private organisationId: number;

  private regexSettingsUrl = /\/user\/settings/;
  private regexDashboardUrl = /\/user(\/dashboards)?/;

  @Output() activeInstance: Instance;

  isSearching: boolean;
  menuItems: MenuItem[];

  configureInstances(organizationId: number) {
    this.instanceService.getAllByOrganization(organizationId).subscribe((data: Instance[]) => {
      if (data) {
        console.log(data);
        const items = data.map(inst => this.instanceToMenuItem(inst));
        items.forEach(inst => this.instanceItems.push(inst));
        console.log(this.instanceItems);
        this.toastrService.success('Get instances from server');
      }
    });
  }

  instanceToMenuItem(instance: Instance) {
    const item: MenuItem = {
      label: instance.title,
      title: instance.id.toString(),
      command: () => this.activeInstance = instance,
      items: [{
        label: 'Update',
        icon: 'fa fa-refresh',
        routerLink: [`edit-instance/${instance.id}`],
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
        styleClass: 'instance-options'
      }]
    };
    return item;
  }

  async deleteInstance(id: number, index: number) {
    if (await this.toastrService.confirm('You sure you want to delete this instance? ')) {
      this.instanceService.delete(id).subscribe((res: Response) => {
        this.toastrService.success('Deleted instance');
        this.instanceItems.splice(index, 1);
      });
    }
  }

  ngOnInit() {
    this.activeUrl = this.router.url;
    this.organisationId = this.authService.getCurrentUser().lastPickedOrganizationId;
    this.initMenuItems();
    this.configureInstances(this.organisationId);
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

    this.instanceItems = [{
      label: 'Create Instance',
      icon: 'pi pi-pw pi-plus',
      routerLink: ['edit-instance']
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
      this.menuItems = this.instanceItems;
      this.isSearching = true;
    }
  }

}
