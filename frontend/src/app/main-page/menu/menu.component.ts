import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.sass']
})
export class MenuComponent implements OnInit {

  constructor() { }

  menuItems: MenuItem[];

  ngOnInit() {
    
    this.menuItems = [
        {
          label: 'Create Dashboard',
          icon: 'pi pi-pw pi-plus',
        },
        {
          label: 'Dashboards',
          icon: 'pi pi-fw pi-th-large',
          items: [
            {label: 'Dashbord1', icon: 'fa fa-fw fa-columns'},
            {label: 'Dashbord2', icon: 'fa fa-fw fa-columns'}
          ]
        },
        {
          label: 'Create Instance',
          icon: 'pi pi-pw pi-plus',
        },
        {
          label: 'Instances',
          icon: 'pi pi-fw pi-th-large',
          items: [
            {label: 'Instance', icon: 'fa fa-fw fa-hdd-o'},
            {label: 'Instance', icon: 'fa fa-fw fa-hdd-o'}
          ]
        },
        {
            label: 'Help',
            icon: 'pi pi-fw pi-question',
            items: [
              {
                label: 'Contents',
                icon: 'pi pi-pi pi-bars'
              },
              {
                label: 'Search', 
                icon: 'pi pi-pi pi-search', 
              }
            ]
          },
        {
            label: 'Settings',
            icon: 'pi pi-fw pi-cog',
            items: [
              {
                label: 'Edit',
                icon: 'pi pi-fw pi-pencil',
                items: [
                  {label: 'Save', icon: 'pi pi-fw pi-save'},
                  {label: 'Update', icon: 'pi pi-fw pi-save'},
                ]
              },
              {
                label: 'Other',
                icon: 'pi pi-fw pi-tags',
                items: [
                  {label: 'Delete', icon: 'pi pi-fw pi-minus'}
                ]
              }
          ]
        }
    ];
}
}
