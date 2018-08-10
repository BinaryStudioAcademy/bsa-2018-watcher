import { Component, OnInit } from '@angular/core';
import {NotificationsService} from '../../shared/services/notifications.service';
import {SampleDto} from '../../shared/models/sample-dto.model';
import {MessageService} from 'primeng/api';

import { MenuItem, ConfirmationService } from '../../../../node_modules/primeng/primeng';
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
dashboards: Dashboard[];
activeItem: MenuItem;
activeDashboard: Dashboard;
creation: boolean;
displayEditDashboard = false;
newTitle: string;

  constructor(private dashboardsService: DashboardService, private toastrService: ToastrService, 
              private notificationsService: NotificationsService,
              private messageService: MessageService) {
    this.menuItems = [];
    this.dashboards = [];
    this.inctanceId = 1;
    this.subscribeToEvents();
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
  async delete() { if (await this.toastrService.confirm('You sure you want to delete dashboard ?')) {
    this.deleteDashboard(this.activeDashboard); }}

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

    if (creation === true) {
      this.newTitle = '';
    } else {
      this.newTitle = this.activeDashboard.title;
    }
    this.displayEditDashboard = true;
  }

  onSaved(title: string) {
    if (this.creation === true) {
      const newdash = new Dashboard(title, new Date(), this.inctanceId);
      this.createDashboard(newdash);
      const index: number = this.menuItems.length - 2;
      this.activeDashboard = newdash;
      this.activeItem = this.menuItems[index];
      this.creation = false;
      this.displayEditDashboard = false;
    } else {
      this.updateDashboard(title);
      this.displayEditDashboard = false;
    }
  }
  onClosed() {
    this.displayEditDashboard = false;
    if (this.creation === true) {
      const index = this.dashboards.length - 2;
      this.activeItem = this.menuItems[index];
      this.activeDashboard = this.dashboards[index]; }}

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
    this.menuItems.push(  {label: 'Add new', command: (onlick) => this.showCreatePopup(true) } );


  this.activeItem = this.menuItems[0];
  this.activeDashboard = this.dashboards[0];

  }
}
