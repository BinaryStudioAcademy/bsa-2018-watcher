import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.sass']
})
export class HeaderComponent implements OnInit {

  userItems: MenuItem[];
  cogItems: MenuItem[];
  mailItems: MenuItem[];
  bellItems: MenuItem[];
  orgItems: MenuItem[];

  constructor() { }

  ngOnInit() {
    this.userItems = [{
        label: 'Profile',
        icon: 'fa fa-fw fa-user',
      },
      {
        label: 'Settings',
        icon: 'fa fa-fw fa-cog',
        routerLink: ['/user/settings']
      },
      {
        label: 'Logout',
        icon: 'fa fa-fw fa-sign-out',
      }
    ];

    this.cogItems = [{
        label: 'Item',
        icon: 'fa fa-fw fa-cog',
      },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-cog',
      },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-cog',
      }
    ];

    this.mailItems = [{
        label: 'Item',
        icon: 'fa fa-fw fa-envelope-o',
      },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-envelope-o',
      },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-envelope-o',
      }
    ];

    this.bellItems = [{
        label: 'Item',
        icon: 'fa fa-fw fa-bell-o',
      },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-bell-o',
      },
      {
        label: 'Item',
        icon: 'fa fa-fw fa-bell-o',
      }
    ];

    this.orgItems = [{
      label: 'Organization1',
      icon: 'fa fa-fw fa-building',
      },
      {
        label: 'Organization2',
        icon: 'fa fa-fw fa-building',
      },
      {
        label: 'Organization3',
        icon: 'fa fa-fw fa-building',
      }
    ];
  }
}
