import { Component, OnInit, ViewChild, OnChanges } from '@angular/core';
import { MenuItem, MenuItemContent } from '../../../../node_modules/primeng/primeng';
import { CreateEditDashboardComponent } from '../create-edit-dashboard/create-edit-dashboard.component';
import { DashboardService } from '../../core/services/dashboard.service';
import { Dashboard } from '../../shared/models/dashboard';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass']
})


export class DashboardComponent implements OnInit {

@ViewChild(CreateEditDashboardComponent) popup: CreateEditDashboardComponent;

inctanceId: number;
menuItems: MenuItem[];
dashboards: Dashboard[];
activeItem: MenuItem;

  constructor(private service: DashboardService) {
    this.menuItems = [];
    this.dashboards = [];
    this.inctanceId = 1;
  }

  createDashboard(title: string, createdAt: Date, instanceId: number) {
   const newDashboard = new Dashboard(title, createdAt, instanceId);
   this.service.create(newDashboard).subscribe((res: Response) => console.log(res));
  }

  getDashboards() {
    /*this.service.getAllByInstance(this.inctanceId).subscribe((data: Dashboard[]) => {
      this.dashboards = data;
     });*/
      this.dashboards = [
       new Dashboard('RAM',  new Date(),  this.inctanceId),
       new Dashboard('CAM',  new Date(),  this.inctanceId),
       new Dashboard('DAM',  new Date(),  this.inctanceId), ];
      this.dashboards.forEach(dash => {
        this.menuItems.push({label: dash.title}); });
  }
  ngOnInit() {
    this.getDashboards();
    this.menuItems.push(  {label: 'Add new', command: (onlick) => {
      this.popup.display = true;
      const index: number = this.menuItems.length - 2;
      console.log(index);
      this.activeItem = this.menuItems[index];
  }} );
  this.activeItem = this.menuItems[0];
  this.popup.onHide = () => {
    if (this.popup.creation === true) {
      this.createDashboard(this.popup.dashboardTitle, new Date(), this.inctanceId);
    }
  };
  }

}
