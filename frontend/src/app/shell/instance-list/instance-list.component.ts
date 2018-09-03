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
              private router: Router) { }

  private menuItems: MenuItem[];
  private user: User;
  private currentGuidId: string;
  private showDownloadModal: boolean;

  private currentQuery = '';

  ngOnInit() {
    this.authService.currentUser.subscribe(
      user => {
        this.user = user;
        // TODO: make this in one method
        this.initMenuItems();
        this.configureInstances(this.user.lastPickedOrganizationId);
      }
    );
    this.instanceService.instanceAdded.subscribe(instance => this.onInstanceAdded(instance));
    this.instanceService.instanceEdited.subscribe(instance => this.onInstanceEdited(instance));
  }


  // TODO: refactor items.foreach add range of items instead of every
  configureInstances(organizationId: number): void {
    this.instanceService.getAllByOrganization(organizationId).subscribe((data: Instance[]) => {
      if (data) {
        const items = data.map(inst => this.instanceToMenuItem(inst));
        items.forEach(inst => this.menuItems.push(inst));
        this.toastrService.success('Get instances from server');
      }
    });
  }

  private initMenuItems(): void {
    this.menuItems = [{
      label: 'Create Instance',
      title: 'Create Instance',
      icon: 'pi pi-pw pi-plus',
      routerLink: ['instances/create'],
    }];
  }

  instanceToMenuItem(instance: Instance): MenuItem {
    const item: MenuItem = {
      label: instance.title,
      id: instance.id.toString(),
      routerLink:  [`instances/${instance.id}/${instance.guidId}/dashboards`],
      command: () => {
        this.instanceService.instanceChecked.emit(instance);
      },
      items: [{
        label: 'Edit',
        icon: 'fa fa-pencil',
        routerLink: [`instances/${instance.id}/edit`],
        styleClass: 'instance-options'
      }, {
        label: 'Delete',
        icon: 'fa fa-close',
        command: () => {
          const index = this.menuItems.findIndex(i => i === item);
          this.deleteInstance(instance.id, index);
        },
        styleClass: 'instance-options'
      }, {
        label: 'Download app',
        icon: 'fa fa-download',
        styleClass: 'instance-options',
        command: () => {
          this.showDownloadModal = true;
          this.currentGuidId = instance.guidId;
        }
      }]
    };
    return item;
  }

  async deleteInstance(id: number, index: number) {
    if (await this.toastrService.confirm('You sure you want to delete this instance? ')) {
    // here need to be configuration of popup
        this.instanceService.delete(id).subscribe((res: Response) => {
        this.instanceService.instanceRemoved.emit(id);
        this.toastrService.success('Deleted instance');
        this.menuItems.splice(index, 1);
        this.router.navigate([`instances`]);
        this.onSearchChange(this.currentQuery);
        // close spinner popup
      });
    }
  }

  onInstanceAdded(instance: Instance) {
    console.log('INSATNCE ADSD');
    const item: MenuItem = this.instanceToMenuItem(instance);
    this.menuItems.push(item);
    this.onSearchChange(this.currentQuery);
  }

  onInstanceEdited(instance: Instance) {
    console.log('INSATNCE ADSD');
    const item: MenuItem = this.instanceToMenuItem(instance);
    const index: number = this.menuItems.findIndex(inst => inst.id === instance.id.toString());
    this.menuItems[index] = item;
    this.onSearchChange(this.currentQuery);
  }

  // TODO: Make refactor (menuitem can be lower to prevent check on every step)
  onSearchChange(searchQuery: string): void {
    this.currentQuery = searchQuery;
    this.menuItems = this.menuItems.map( (menuitem: MenuItem) => {
      if (!menuitem.label.toLowerCase().startsWith(searchQuery.toLowerCase())) {
        menuitem.visible = false;
      } else {
        menuitem.visible = true;
      }
      if (menuitem.label === this.menuItems[0].label) { menuitem.visible = true; }
      return menuitem;
    });
  }

  onClose(): void {
    this.showDownloadModal = false;
  }
}
