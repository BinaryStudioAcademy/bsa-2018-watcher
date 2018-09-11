import {Component, OnInit} from '@angular/core';
import {InstanceService} from '../../core/services/instance.service';
import {ToastrService} from '../../core/services/toastr.service';
import {AuthService} from '../../core/services/auth.service';
import {MenuItem} from 'primeng/api';
import {User} from '../../shared/models/user.model';
import {Instance} from '../../shared/models/instance.model';
import {Router} from '@angular/router';
import {UserOrganizationService} from '../../core/services/user-organization.service';
import {CollectedDataService} from '../../core/services/collected-data.service';
import {DataService} from '../../core/services/data.service';
import {DashboardsHub} from '../../core/hubs/dashboards.hub';

@Component({
  selector: 'app-instance-list',
  templateUrl: './instance-list.component.html',
  styleUrls: ['./instance-list.component.sass']
})
export class InstanceListComponent implements OnInit {
  constructor(private instanceService: InstanceService,
              private collectedDataService: CollectedDataService,
              private dataService: DataService,
              private toastrService: ToastrService,
              private authService: AuthService,
              private dashboardsHub: DashboardsHub,
              private userOrganizationService: UserOrganizationService,
              private router: Router) {
    this.instanceService.instanceAdded.subscribe(instance => this.onInstanceAdded(instance));
    this.instanceService.instanceEdited.subscribe(instance => this.onInstanceEdited(instance));
  }

  menuItems: MenuItem[];
  user: User;
  currentGuidId: string;
  showDownloadModal: boolean;
  popupMessage: string;
  isLoading: boolean;
  isDeleting: boolean;
  isManager: boolean;
  currentQuery = '';

  ngOnInit(): void {
    // TODO: maybe do unrelated request with fork join to reduce # of request
    this.collectedDataService.getBuilderData()
      .subscribe(value => {
        this.dataService.fakeCollectedData = value;
      });
    this.authService.currentUser.subscribe(
      async user => {
        this.user = user;
        const role = await this.userOrganizationService.getOrganizationRole();
        this.isManager = role.name === 'Manager';
        this.dashboardsHub.subscribeToOrganizationById(this.user.lastPickedOrganizationId);
        this.configureInstances(this.user.lastPickedOrganizationId);
      });
    this.dashboardsHub.instanceCheckedSubObservable.subscribe(value => {
      console.log(`Instance: ${value.instanceGuidId}, was checked at ${value.statusCheckedAt}`);
    });
  }

  configureInstances(organizationId: number): void {
    this.menuItems = [{
      label: 'Create Instance',
      title: 'Create Instance',
      icon: 'pi pi-pw pi-plus',
      routerLink: ['instances/create'],
      visible: this.isManager
    }];

    this.isLoading = true;
    this.instanceService.getAllByOrganization(organizationId).subscribe((data: Instance[]) => {
      if (data) {
        const items = data.map(inst => this.instanceToMenuItem(inst));
        this.menuItems = this.menuItems.concat(items);
        this.toastrService.success('Get instances from server');
      }
      this.isLoading = false;
    });
  }


  instanceToMenuItem(instance: Instance): MenuItem {
    const item: MenuItem = {
      label: instance.title,
      id: instance.id.toString(),
      routerLink: [`/user/instances/${instance.id}/${instance.guidId}/dashboards`],
      command: () => {
        this.currentGuidId = instance.guidId;
        this.instanceService.instanceChecked.emit(instance);
      },
      items: [{
        label: 'Edit',
        icon: 'fa fa-pencil',
        routerLink: [`/user/instances/${instance.id}/edit`],
        styleClass: 'instance-options',
        visible: this.isManager
      }, {
        label: 'Activities',
        icon: 'fa fa fa-history',
        routerLink: [`/user/instances/${instance.guidId}/activities`],
        styleClass: 'instance-options',
        command: () => this.highlightCurrent(item)
      }, {
        label: 'Download app',
        icon: 'fa fa-download',
        styleClass: 'instance-options',
        visible: this.isManager,
        command: () => {
          this.showDownloadModal = true;
          this.currentGuidId = instance.guidId;
          this.highlightCurrent(item);
        }
      }, {
        label: 'Report',
        icon: 'fa fa-stack-exchange',
        routerLink: [`/user/instances/${instance.id}/${instance.guidId}/report`],
        styleClass: 'instance-options',
        command: () => this.highlightCurrent(item)
      }, {
        label: 'Delete',
        icon: 'fa fa-close',
        command: () => {
          const index = this.menuItems.findIndex(i => i === item);
          this.deleteInstance(instance.id, index);
          this.highlightCurrent(item);
          this.dataService.hourlyCollectedData = [];
        },
        styleClass: 'instance-options',
        visible: this.isManager
      }]
    };
    return item;
  }

  async deleteInstance(id: number, index: number) {
    if (await this.toastrService.confirm('You sure you want to delete this instance? ')) {
      this.isDeleting = true;
      this.popupMessage = 'Deleting instance';

      this.instanceService.delete(id).subscribe((res: Response) => {
        this.instanceService.instanceRemoved.emit(id);
        this.toastrService.success('Deleted instance');
        this.menuItems.splice(index, 1);
        this.router.navigate([`instances`]);
        this.onSearchChange(this.currentQuery);

        this.isDeleting = false;
      });
    }
  }

  onInstanceAdded(instance: Instance): void {
    const item: MenuItem = this.instanceToMenuItem(instance);
    this.menuItems.push(item);
    this.onSearchChange(this.currentQuery);
    this.highlightCurrent(item);
  }

  onInstanceEdited(instance: Instance): void {
    const item: MenuItem = this.instanceToMenuItem(instance);
    const index: number = this.menuItems.findIndex(inst => inst.id === instance.id.toString());
    this.menuItems[index] = item;
    this.onSearchChange(this.currentQuery);
    this.highlightCurrent(item);
  }

  onSearchChange(searchQuery: string): void {
    this.currentQuery = searchQuery;
    this.menuItems = this.menuItems.map((menuitem: MenuItem) => {
      menuitem.visible = menuitem.label.toLowerCase().startsWith(searchQuery.toLowerCase());
      return menuitem;
    });

    // [0] element of menuItems is Create button
    this.menuItems[0].visible = this.isManager;
  }

  onClose(): void {
    this.showDownloadModal = false;
  }


  highlightCurrent(menuitem: MenuItem) {
    this.menuItems = this.menuItems.map(i => {
      i.expanded = false;
      return i;
    });
    menuitem.expanded = true;
  }
}
