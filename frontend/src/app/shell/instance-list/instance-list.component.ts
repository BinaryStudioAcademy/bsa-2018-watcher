import { Component, OnInit } from '@angular/core';
import {AfterContentChecked, AfterViewChecked} from '@angular/core';
import { InstanceService } from '../../core/services/instance.service';
import { ToastrService } from '../../core/services/toastr.service';
import { AuthService } from '../../core/services/auth.service';
import { MenuItem } from 'primeng/api';
import { User } from '../../shared/models/user.model';
import { Instance } from '../../shared/models/instance.model';
import { Router } from '@angular/router';
import { OrganizationRole } from '../../shared/models/organization-role.model';
import { UserOrganizationService } from '../../core/services/user-organization.service';
import { NavigationStart} from '@angular/router';

@Component({
  selector: 'app-instance-list',
  templateUrl: './instance-list.component.html',
  styleUrls: ['./instance-list.component.sass']
})
export class InstanceListComponent implements OnInit, AfterContentChecked, AfterViewChecked  {
constructor(private instanceService: InstanceService,
  private toastrService: ToastrService,
  private authService: AuthService,
  private userOrganizationService: UserOrganizationService,
  private router: Router) {
  this.instanceService.instanceAdded.subscribe(instance => this.onInstanceAdded(instance));
  this.instanceService.instanceEdited.subscribe(instance => this.onInstanceEdited(instance));
  router.events.forEach((event) => {
    if (event instanceof NavigationStart) {
      this.clearSettings(this.router.url);
      this.previousSettingUrl = this.router.url;
    }
  });
 }


  menuItems: MenuItem[];
  user: User;
  currentGuidId: string;
  showDownloadModal: boolean;
  popupMessage: string;
  isLoading: boolean;
  isDeleting: boolean;
  isMember = true;
  previousSettingUrl: string;

  currentQuery = '';

  ngOnInit(): void {
    this.authService.currentUser.subscribe(
      user => {
        this.user = user;
        this.userOrganizationService.getOrganizationRole().subscribe((role: OrganizationRole) => {
        this.isMember = role.name === 'Member' ? true : false;
        this.configureInstances(this.user.lastPickedOrganizationId);
    });
      }
    );
   }

   ngAfterContentChecked(): void {
    this.highlightCurrentSetting();
  }

  ngAfterViewChecked(): void {
    this.highlightCurrentSetting();
  }

  configureInstances(organizationId: number): void {
    this.menuItems = [{
      label: 'Create Instance',
      title: 'Create Instance',
      icon: 'pi pi-pw pi-plus',
      routerLink: ['instances/create'],
      disabled: this.isMember
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
      routerLink:  [`/user/instances/${instance.id}/${instance.guidId}/dashboards`],
      command: () => {
        this.instanceService.instanceChecked.emit(instance);
      },
      items: [{
        label: 'Edit',
        icon: 'fa fa-pencil',
        routerLink: [`/user/instances/${instance.id}/edit`],
        styleClass: 'instance-options',
        disabled: this.isMember
      }, {
        label: 'Activities',
        icon: 'fa fa fa-history',
        routerLink: [`/user/instances/${instance.guidId}/activities`],
        styleClass: 'instance-options'
      }, {
        label: 'Download app',
        icon: 'fa fa-download',
        styleClass: 'instance-options',
        disabled: this.isMember,
        command: () => {
          this.showDownloadModal = true;
          this.currentGuidId = instance.guidId;
        }
      }, {
        label: 'Report',
        icon: 'fa fa-stack-exchange',
        routerLink: [`/user/instances/${instance.id}/${instance.guidId}/report`],
        styleClass: 'instance-options'
      }, {
        label: 'Delete',
        icon: 'fa fa-close',
        command: () => {
          const index = this.menuItems.findIndex(i => i === item);
          this.deleteInstance(instance.id, index);
        },
        styleClass: 'instance-options',
        disabled: this.isMember
      } ]
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
    this.expandElement(item);
  }

  onInstanceEdited(instance: Instance): void {
    const item: MenuItem = this.instanceToMenuItem(instance);
    const index: number = this.menuItems.findIndex(inst => inst.id === instance.id.toString());
    this.menuItems[index] = item;
    this.onSearchChange(this.currentQuery);
    this.expandElement(item);
  }

  onSearchChange(searchQuery: string): void {
    this.currentQuery = searchQuery;
    this.menuItems = this.menuItems.map( (menuitem: MenuItem) => {
      if (!menuitem.label.toLowerCase().startsWith(searchQuery.toLowerCase())) {
        menuitem.visible = false;
      } else {
        menuitem.visible = true;
      }
      return menuitem;
    });
    // [0] element of menuItems is Create button
    this.menuItems[0].visible = true;
  }

  expandElement(menuitem: MenuItem): void {
    this.menuItems[0].expanded = false;
    menuitem.expanded = true;
  }
  onClose(): void {
    this.showDownloadModal = false;
  }

  private clearSettings(url: string): void {
    if (this.router.url !== this.previousSettingUrl) {
      const setting = this.getSettingByUrl(url);

      if (setting !== null) {
        setting.classList.remove('ui-state-active');
        setting.parentElement.classList.remove('ui-state-active');

      }
    }
  }

  private highlightCurrentSetting(): void {
    const setting = this.getSettingByUrl(this.router.url);

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
