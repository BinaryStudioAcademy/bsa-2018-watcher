import { Component, OnInit } from '@angular/core';
import { MenuItem, ConfirmationService } from 'primeng/primeng';
import {NotificationsService} from '../../shared/services/notifications.service';
import {SampleDto} from '../../shared/models/sample-dto.model';
import {MessageService} from 'primeng/api';
import { DashboardService } from '../../core/Services/dashboard.service';
import { Dashboard } from '../../shared/models/dashboard';
import { ToastrService } from '../../core/services/toastr.service';
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass'],

  providers: [ConfirmationService, DashboardService, MessageService]
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

  constructor(private dashboardsService: DashboardService, private toastrService: ToastrService,
              private notificationsService: NotificationsService,
              private messageService: MessageService) {
    this.menuItems = [];
    this.dashboards = [];
    this.inctanceId = 1;
    this.subscribeToEvents();
  }

  createDashboard(newDashboard: Dashboard) {
    const item: MenuItem = {
      label: newDashboard.title,
      command: (onclick) => {
        this.activeDashboard = newDashboard; }};

    this.dashboards.push(newDashboard);
    this.menuItems.splice(this.menuItems.length - 1, 0, item);

    // comment this if testing on local machine
    this.dashboardsService.create(newDashboard)
      .subscribe((res: Response) => { console.log(res); });
    }

  updateDashboard(editTitle: string) {
    const index = this.dashboards.findIndex(d => d === this.activeDashboard);
    this.dashboards[index].title = editTitle;
    this.menuItems[index].label = editTitle;

    // comment this if testing on local machine
    this.dashboardsService.update(this.dashboards[index])
      .subscribe((res: Response) => {console.log(res); });
  }

  deleteDashboard(dashboard: Dashboard) {
    const index = this.dashboards.findIndex(d => d === this.activeDashboard);
    this.menuItems.splice(index, 1);
    this.dashboards.splice(index, 1);
    // comment this if testing on local machine
    this.dashboardsService.delete(dashboard.id)
      .subscribe((res: Response) => {console.log(res); });
  }

  async delete() {
    if (await this.toastrService.confirm('You sure you want to delete dashboard ?')) {
    this.deleteDashboard(this.activeDashboard); }}

  getDashboards() {

    // comment this if testing on local machine
    this.dashboardsService.getAllByInstance(this.inctanceId).subscribe((data: Dashboard[]) => {
      this.dashboards = data;
     });

     // uncomment in case testing on local machine

      /*this.dashboards = [
       new Dashboard('RAM',  new Date(),  this.inctanceId),
       new Dashboard('CAM',  new Date(),  this.inctanceId),
       new Dashboard('DAM',  new Date(),  this.inctanceId), ];*/
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

  private subscribeToEvents(): void {
    this.notificationsService.connectionEstablished.subscribe(() => {
        console.log('Connected from dashboard');
    });

    this.notificationsService.sampleReceived.subscribe((sample: SampleDto) => {
      this.messageService.add({
        severity: 'info', summary: sample.name, detail: `Name: ${sample.name}, Id: ${sample.id},
          Sample Field: ${sample.sampleField.toString()}, Date of creation: ${sample.dateOfCreation}, Count: ${sample.count}, `
      });
    });
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
