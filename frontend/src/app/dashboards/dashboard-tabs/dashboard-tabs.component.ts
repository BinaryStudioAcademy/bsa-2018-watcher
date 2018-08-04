import { Component, OnInit } from '@angular/core';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-dashboard-tabs',
  templateUrl: './dashboard-tabs.component.html',
  styleUrls: ['./dashboard-tabs.component.sass']
})
export class DashboardTabsComponent implements OnInit {

  items: MenuItem[];

  constructor() { }

  ngOnInit() {
    this.items = [
        {label: 'Stats', icon: 'fa fa-fw fa-bar-chart'},
        {label: 'Calendar', icon: 'fa fa-fw fa-calendar'},
        {label: 'Documentation', icon: 'fa fa-fw fa-book'},
        {label: 'Support', icon: 'fa fa-fw fa-support'},
        {label: 'Social', icon: 'fa fa-fw fa-twitter'}
    ];
}

}
