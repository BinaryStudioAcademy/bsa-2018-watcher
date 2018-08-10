import { Component, OnInit } from '@angular/core';
import { MenuItem, ConfirmationService } from 'primeng/primeng';
import { DashboardService } from '../../core/Services/dashboard.service';
import { Dashboard } from '../../shared/models/dashboard';
import { ToastrService } from '../../core/services/toastr.service';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass'],
  providers: [ConfirmationService, DashboardService]
})

export class DashboardComponent implements OnInit {

  inctanceId: number;

  menuItems: MenuItem[];
  activeItem: MenuItem;

  dashboards: Dashboard[];
  activeDashboard: Dashboard;
  editTitle: string;

  creation: boolean;
  displayEditDashboard = false;

  constructor(private dashboardsService: DashboardService, private toastrService: ToastrService) {
    this.menuItems = [];
    this.dashboards = [];
    this.inctanceId = 1;
  }

  createDashboard(newDashboard: Dashboard) {
    const item: MenuItem = {
      label: newDashboard.title,
      command: (onclick) => {
        this.activeDashboard = newDashboard; }};

    this.dashboards.push(newDashboard);
    this.menuItems.splice(this.menuItems.length - 1, 0, item);

    this.dashboardsService.create(newDashboard)
      .subscribe((res: Response) => { console.log(res); });
    }

  updateDashboard(editTitle: string) {
    const index = this.dashboards.findIndex(d => d === this.activeDashboard);
    this.dashboards[index].title = editTitle;
    this.menuItems[index].label = editTitle;

    this.dashboardsService.update(this.dashboards[index])
      .subscribe((res: Response) => {console.log(res); });
  }

  deleteDashboard(dashboard: Dashboard) {
    const index = this.dashboards.findIndex(d => d === this.activeDashboard);
    this.menuItems.splice(index, 1);
    this.dashboards.splice(index, 1);
    this.dashboardsService.delete(dashboard.id)
      .subscribe((res: Response) => {console.log(res); });
  }

  async delete() {
    if (await this.toastrService.confirm('You sure you want to delete dashboard ?')) {
    this.deleteDashboard(this.activeDashboard); }}

  getDashboards() {
   /* this.dashboardsService.getAllByInstance(this.inctanceId).subscribe((data: Dashboard[]) => {
      this.dashboards = data;
     });*/
     // uncomment in case testing on local machine

      this.dashboards = [
       new Dashboard('RAM',  new Date(),  this.inctanceId),
       new Dashboard('CAM',  new Date(),  this.inctanceId),
       new Dashboard('DAM',  new Date(),  this.inctanceId), ];
      this.dashboards.forEach(dash => {
        this.menuItems.push({
          label: dash.title,
          command: (onclick) => {
            this.activeDashboard = dash; }}); });
  }

  showCreatePopup(creation: boolean) {
    this.creation = creation;
    this.editTitle = creation ? '' : this.activeDashboard.title;
    this.displayEditDashboard = true;
  }

  onEdited(title: string) {
    if (this.creation === true) {
      const newdash = new Dashboard(title, new Date(), this.inctanceId);
      this.createDashboard(newdash);

    // switching to new tab
      const index: number = this.menuItems.length - 2;
      this.activeDashboard = newdash;
      this.activeItem = this.menuItems[index];
    } else {
      this.updateDashboard(title);
    }
    this.creation = false;
    this.displayEditDashboard = false;
  }

  onClosed() {
    if (this.creation === true) {
      // switching to last dashboard if popup is closed without save
      const index = this.menuItems.length - 2;
      const label = this.menuItems[index].label.slice();

      this.menuItems[index] = {label: label };
      this.activeItem = this.menuItems[index];
      this.activeDashboard = this.dashboards[index];
    }
      this.creation = false;
      this.displayEditDashboard = false;
  }

  ngOnInit() {
    this.getDashboards();
    const lastItem: MenuItem = {
      label: 'Add new',
      icon: 'fa fa-plus',
      command: (onlick) =>  {
        this.showCreatePopup(true); },
      id: 'lastTab' };

    this.menuItems.push(lastItem);

  this.activeItem = this.menuItems[0];
  this.activeDashboard = this.dashboards[0];
  }
}
