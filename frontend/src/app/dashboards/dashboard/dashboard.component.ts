import { Component, OnInit } from '@angular/core';
import { MenuItem, ConfirmationService } from 'primeng/primeng';
import {NotificationsService} from '../../shared/services/notifications.service';
import {SampleDto} from '../../shared/models/sample-dto.model';
import {MessageService} from 'primeng/api';
import { DashboardService } from '../../core/services/dashboard.service';
import { Dashboard } from '../../shared/models/dashboard.model';
import { Instance } from '../../shared/models/instance.model';
import { ToastrService } from '../../core/services/toastr.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass'],
  providers: [ToastrService, ConfirmationService, DashboardService, MessageService]
})

export class DashboardComponent implements OnInit {

  instance: Instance;

  menuItems: MenuItem[];
  activeItem: MenuItem;

  dashboards: Dashboard[];
  activeDashboard: Dashboard;
  editTitle: string;

  creation: boolean;
  loading = false;
  displayEditDashboard = false;

  constructor(private dashboardsService: DashboardService, private toastrService: ToastrService,
              private notificationsService: NotificationsService,
              private messageService: MessageService) {
    this.menuItems = [];
    this.activeItem = {};

    this.dashboards = [];
    this.instance = {id: 1, address: 'adress', platform: 'platform'};
    this.subscribeToEvents();
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

     if (this.menuItems.length >= 1 ) {
      this.activeDashboard = this.dashboards[0];
      this.activeItem = this.menuItems[0];
    } else {
      this.activeDashboard = null;
    }

    this.dashboardsService.delete(dashboard.id)
      .subscribe((res: Response) => {console.log(res); });
  }

  async delete() {
    if (await this.toastrService.confirm('You sure you want to delete dashboard ?')) {
    this.deleteDashboard(this.activeDashboard); }}

  configureDashboards() {
      this.dashboardsService.getAllByInstance(this.instance.id).subscribe((data: Dashboard[]) => {
      this.dashboards = data;

      this.dashboards.forEach(dash => {
        this.menuItems.push({
          label: dash.title,
          command: (onclick) => {
            this.activeDashboard = dash; }}); });

      this.loading = false; });
  }

  showCreatePopup(creation: boolean) {
    this.creation = creation;
    this.editTitle = creation ? '' : this.activeDashboard.title;
    this.displayEditDashboard = true;
  }

  onEdited(title: string) {
    if (this.creation === true) {
      const newdash: Dashboard = {title: title, createdAt: new Date(), instance: this.instance };
      this.createDashboard(newdash);
    let index = 0;
    // switching to new tab
    if (this.menuItems.length >= 2 ) {
      index = this.menuItems.length - 2;
      this.activeDashboard = newdash;
      this.activeItem = this.menuItems[index]; }
    } else {
      this.updateDashboard(title);
    }
    this.creation = false;
    this.displayEditDashboard = false;
  }

  onClosed() {
    if (this.creation === true) {
      if (this.menuItems.length >= 2) {
        // switching to last dashboard if popup is closed without save
        const index = this.menuItems.length - 2;
        const label = this.menuItems[index].label.slice();
        this.menuItems[index] = {label: label };
        this.activeItem = this.menuItems[index];
        this.activeDashboard = this.dashboards[index]; }
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
    this.configureDashboards();
    const lastItem: MenuItem = {
      label: 'Add new',
      icon: 'fa fa-plus',
      command: (onlick) =>  {
        this.showCreatePopup(true); },
      id: 'lastTab' };

    this.menuItems.push(lastItem);
    this.activeDashboard = this.dashboards[0];
    this.activeItem = this.menuItems[0];
  }
}
