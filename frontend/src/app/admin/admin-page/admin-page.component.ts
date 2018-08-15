import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-admin-page',
  templateUrl: './admin-page.component.html',
  styleUrls: ['./admin-page.component.sass']
})
export class AdminPageComponent implements OnInit {

  constructor() { }

  menuItems: MenuItem[];

  ngOnInit() {
    this.menuItems = [{
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
        routerLink: ['/user/admin/feedback-list']
      }];
  }
}
