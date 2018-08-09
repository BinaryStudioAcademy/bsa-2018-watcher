import { Component, OnInit, ViewChild, OnChanges } from '@angular/core';
import { MenuItem, MenuItemContent } from '../../../../node_modules/primeng/primeng';
import { CreateEditDashboardComponent } from '../create-edit-dashboard/create-edit-dashboard.component';
import {Dashboard} from '../../shared/models/dashboard.model';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass']
})


export class DashboardComponent implements OnInit {

@ViewChild(CreateEditDashboardComponent) popup: CreateEditDashboardComponent;

items: MenuItem[];
activeItem: MenuItem;
newDashboard: Dashboard;

  constructor() { }

  createDashboard() {
   this.newDashboard.title = this.popup.dashboardTitle;
   this.newDashboard.createdAt = new Date();
  }

  ngOnInit() {
    this.items = [
      {label: 'RAM', },
      {label: 'CAM', },
      {label: 'DAM', },
      {label: 'Add new', command: (onlick) => {
        this.popup.display = true;
        const index: number = this.items.length - 2;
        console.log(index);
        this.activeItem = this.items[index];
    }}
  ];
  this.activeItem = this.items[0];
  this.popup.ngOnInit();
  }

}
