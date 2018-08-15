import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';
import { Router, RouterEvent, ActivatedRoute } from '@angular/router';
import { InstanceService } from '../../core/services/instance.service';
import { Instance } from '../../shared/models/instance.model';
import { ToastrService } from '../../core/services/toastr.service';

@Component({
  selector: 'app-left-side-menu',
  templateUrl: './left-side-menu.component.html',
  styleUrls: ['./left-side-menu.component.sass']
})
export class LeftSideMenuComponent implements OnInit {

  constructor(private router: Router,
              private instanceService: InstanceService,
              private toastrService: ToastrService) { }

  private activeUrl: String;
  private settingsItems: MenuItem[];
  private dashboardItems: MenuItem[];

  private regexSettingsUrl = /\/user\/settings/;
  private regexDashboardUrl = /\/user(\/dashboards)?/;

  isSearching: boolean;
  menuItems: MenuItem[];

  configureInstances(organizationId: number) {
    let instances: Instance[];
    this.instanceService.getAllByOrganization(organizationId).subscribe( (data: Instance[]) => {
      if (data) {
        instances = data;
        this.toastrService.success('Success');
      } else {
        this.toastrService.error('Error is occured');
      }
    });
  }

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
      routerLink: ['edit-instance']
    }, {
      label: 'Instance1',
      icon: 'fa fa-fw fa-hdd-o',
      items: [{
        label: 'Update',
        icon: 'fa fa-refresh',
        routerLink: ['edit-instance/123'],
      }, {
        label: 'Delete',
        icon: 'fa fa-close'
      }, {
        label: 'Download app',
        icon: 'fa fa-download'
      }]
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
