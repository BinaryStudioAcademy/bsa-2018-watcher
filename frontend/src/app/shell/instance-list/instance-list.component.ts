import { Component, OnInit } from '@angular/core';
import { InstanceService } from '../../core/services/instance.service';
import { ToastrService } from '../../core/services/toastr.service';
import { AuthService } from '../../core/services/auth.service';
import { MenuItem } from 'primeng/api';
import { User } from '../../shared/models/user.model';
import { Instance } from '../../shared/models/instance.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-instance-list',
  templateUrl: './instance-list.component.html',
  styleUrls: ['./instance-list.component.sass']
})
export class InstanceListComponent implements OnInit {

  constructor(private instanceService: InstanceService,
              private toastrService: ToastrService,
              private authService: AuthService,
              private router: Router) {
                this.instanceService.instanceAdded.subscribe(instance => {this.onInstanceAdded(instance);
                  console.log('SUBSCRIBED ON EVENT'); });
                this.instanceService.instanceEdited.subscribe(instance => this.onInstanceEdited(instance));
               }

  menuItems: MenuItem[];
  user: User;
  currentGuidId: string;
  showDownloadModal: boolean;
  popupMessage: string;
  isLoading: boolean;

  currentQuery = '';

  ngOnInit() {
    this.authService.currentUser.subscribe(
      user => {
        this.user = user;
        this.configureInstances(this.user.lastPickedOrganizationId);
      }
    );
   }


  configureInstances(organizationId: number): void {
    this.isLoading = true;
    this.popupMessage = 'Loading instances info';

    this.menuItems = [{
      label: 'Create Instance',
      title: 'Create Instance',
      icon: 'pi pi-pw pi-plus',
      routerLink: ['instances/create'],
    }];

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
        styleClass: 'instance-options'
      }, {
        label: 'Download app',
        icon: 'fa fa-download',
        styleClass: 'instance-options',
        command: () => {
          this.showDownloadModal = true;
          this.currentGuidId = instance.guidId;
        }
      }, {
        label: 'Delete',
        icon: 'fa fa-close',
        command: () => {
          const index = this.menuItems.findIndex(i => i === item);
          this.deleteInstance(instance.id, index);
        },
        styleClass: 'instance-options'
      } ]
    };
    return item;
  }

  async deleteInstance(id: number, index: number) {
    if (await this.toastrService.confirm('You sure you want to delete this instance? ')) {
        this.isLoading = true;
        this.popupMessage = 'Deleting instance';

        this.instanceService.delete(id).subscribe((res: Response) => {
        this.instanceService.instanceRemoved.emit(id);
        this.toastrService.success('Deleted instance');
        this.menuItems.splice(index, 1);
        this.router.navigate([`instances`]);
        this.onSearchChange(this.currentQuery);

        this.isLoading = false;
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
}
