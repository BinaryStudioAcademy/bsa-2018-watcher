import { Component, OnInit, ViewChild, OnChanges } from '@angular/core';
import { MenuItem, MenuItemContent, ConfirmationService } from '../../../../node_modules/primeng/primeng';
import { EditDashboardComponent } from '../create-edit-dashboard/create-edit-dashboard.component';
import { DashboardService } from '../../core/Services/dashboard.service';
import { Dashboard } from '../../shared/models/dashboard';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass'],
  providers: [ConfirmationService, DashboardService]
})

export class DashboardComponent implements OnInit {

inctanceId: number;
menuItems: MenuItem[];
dashboards: Dashboard[];
activeItem: MenuItem;
activeDashboard: Dashboard;
creation: boolean;
displayEditDashboard = false;
newtitle: string;

  constructor(private dashboardsService: DashboardService, private confirmationService: ConfirmationService) {
    this.menuItems = [];
    this.dashboards = [];
    this.inctanceId = 1;
  }

  createDashboard(newDashboard: Dashboard) {
   this.dashboards.push(newDashboard);
   this.menuItems.splice(this.menuItems.length - 1, 0, {label: newDashboard.title,
    command: (onclick) => this.activeDashboard = newDashboard});
   // this.dashboardsService.create(newDashboard).subscribe((res: Response) => console.log(res));
  }

  updateDashboard(newTitle: string) {
    const index = this.dashboards.findIndex(d => d === this.activeDashboard);
    this.dashboards[index].title = newTitle;
    this.menuItems[index].label = newTitle;
    // this.dashboardsService.update(this.dashboards[index]).subscribe((res: Response) => console.log(res));
  }

  deleteDashboard(dashboard: Dashboard) {
    const index = this.dashboards.findIndex(d => d === this.activeDashboard);
    this.menuItems.splice(index, 1);
    this.dashboards.splice(index, 1);
    // this.dashboardsService.delete(dashboard.id).subscribe((res: Response) => console.log(res));
  }
  delete() {
    this.confirmationService.confirm({
    message: 'Are you sure that you want to delete this dashboard?',
    header: 'Confirmation',
    icon: 'pi pi-exclamation-triangle',
    accept: () => {
        this.deleteDashboard(this.activeDashboard);
    },
    reject: () => {
      console.log('rejected');
    }
}); }

  getDashboards() {
    /*this.dashboardsService.getAllByInstance(this.inctanceId).subscribe((data: Dashboard[]) => {
      this.dashboards = data;
     });*/
      this.dashboards = [
       new Dashboard('RAM',  new Date(),  this.inctanceId),
       new Dashboard('CAM',  new Date(),  this.inctanceId),
       new Dashboard('DAM',  new Date(),  this.inctanceId), ];
      this.dashboards.forEach(dash => {
        this.menuItems.push({label: dash.title, command: (onclick) => this.activeDashboard = dash}); });
  }

  showCreatePopup(creation: boolean) {
    this.creation = creation;
    alert(this.displayEditDashboard);

    if (creation === true) {
      this.newtitle = '';
    } else {
      this.newtitle = this.activeDashboard.title;
    }
    this.displayEditDashboard = true;
    alert(this.displayEditDashboard);
  }

  onSaved(title: string) {
    if (this.creation === true) {
      const newdash = new Dashboard(title, new Date(), this.inctanceId);
      this.createDashboard(newdash);
      const index: number = this.menuItems.length - 2;
      this.activeDashboard = newdash;
      this.activeItem = this.menuItems[index];
      this.creation = false;
    } else {
      this.updateDashboard(title);
    }
  }

  ngOnInit() {
    this.getDashboards();
    this.menuItems.push(  {label: 'Add new', command: (onlick) => this.showCreatePopup(true) } );

  this.activeItem = this.menuItems[0];
  this.activeDashboard = this.dashboards[0];

  }
}
