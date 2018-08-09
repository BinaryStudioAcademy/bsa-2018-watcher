import { Component, OnInit, ViewChild, OnChanges } from '@angular/core';
import { MenuItem, MenuItemContent } from '../../../../node_modules/primeng/primeng';
import { CreateEditDashboardComponent } from '../create-edit-dashboard/create-edit-dashboard.component';
import { DashboardService } from '../../core/services/dashboard.service';
import { Dashboard } from '../../shared/models/dashboard';
import { and } from '../../../../node_modules/@angular/router/src/utils/collection';
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
activeDashboard: Dashboard;

  constructor(private service: DashboardService) {
    this.menuItems = [];
    this.dashboards = [];
    this.inctanceId = 1;
  }

  createDashboard(newDashboard: Dashboard) {
   this.dashboards.push(newDashboard);
   this.menuItems.splice(this.menuItems.length - 1, 0, {label: newDashboard.title,
    command: (onclick) => this.activeDashboard = newDashboard});
   // this.service.create(newDashboard).subscribe((res: Response) => console.log(res));
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
        this.menuItems.push({label: dash.title, command: (onclick) => this.activeDashboard = dash}); });
  }

  showCreatePopup(title?: string, update?: boolean) {
    this.popup.display = true;
    if (update === true) {
      this.popup.dashboardTitle = title.slice();
      this.popup.updating = true;
      this.popup.creation = false;
    } else {
      this.popup.creation = true;
      this.popup.updating = false;
    }
  }

  ngOnInit() {
    this.getDashboards();
    this.menuItems.push(  {label: 'Add new', command: (onlick) => this.showCreatePopup() } );

  this.activeItem = this.menuItems[0];
  this.activeDashboard = this.dashboards[0];

  this.popup.onHide = () => {
    if (this.popup.creation === true) {
      const newdash = new Dashboard(this.popup.dashboardTitle, new Date(), this.inctanceId);
      this.createDashboard(newdash);
      const index: number = this.menuItems.length - 2;
      console.log(index);
      this.activeDashboard = newdash;
      this.activeItem = this.menuItems[index];
    }
    if (this.popup.updating === true) {
      this.dashboards.find(d => d === this.activeDashboard).title =
      this.popup.dashboardTitle;
    }
  };
  }

}
