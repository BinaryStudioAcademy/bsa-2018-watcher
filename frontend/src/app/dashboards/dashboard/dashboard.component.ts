import { Component, OnInit, ViewChild, OnChanges } from '@angular/core';
import { MenuItem, MenuItemContent } from '../../../../node_modules/primeng/primeng';
import { CreateEditDashboardComponent } from '../create-edit-dashboard/create-edit-dashboard.component';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass']
})


export class DashboardComponent implements OnInit {

@ViewChild(CreateEditDashboardComponent) popup: CreateEditDashboardComponent;

items: MenuItem[];
activeItem: MenuItem;
newDashboardTitle: string;
  constructor() { }

  ngOnInit() {
    this.items = [
      {label: 'RAM', },
      {label: 'CAM', },
      {label: 'DAM', },
      {label: 'Add new', command: (onlick) => {
        this.popup.display = true;
        let index: number = this.items.length - 2;
        console.log(index);
        this.activeItem = this.items[index];
    }}
  ];
  this.activeItem = this.items[0];
  }

}
