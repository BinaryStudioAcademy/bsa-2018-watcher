import { Component, OnInit } from '@angular/core';
import { MenuItem, ConfirmationService } from 'primeng/primeng';
import {NotificationsService} from '../../shared/services/notifications.service';
import {SampleDto} from '../../shared/models/sample-dto.model';
import {MessageService} from 'primeng/api';
import { DashboardService } from '../../core/services/dashboard.service';
import { Dashboard } from '../../shared/models/dashboard.model';
import { Instance } from '../../shared/models/instance.model';
import { ToastrService } from '../../core/services/toastr.service';
import { DashboardMenuItem } from '../models/dashboard-menuitem.model';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass'],
  providers: [ToastrService, ConfirmationService, DashboardService, MessageService]
})

export class DashboardComponent implements OnInit {

  instance: Instance;

  dashboardMenuitems: DashboardMenuItem[];
  activeDashboardItem: DashboardMenuItem;

  editTitle: string;
  creation: boolean;
  loading = false;
  displayEditDashboard = false;

  constructor(private dashboardsService: DashboardService, private toastrService: ToastrService,
              private notificationsService: NotificationsService,
              private messageService: MessageService) {
    this.activeDashboardItem = {};
    this.dashboardMenuitems = [];
    this.instance = {id: 1, address: 'adress', platform: 'platform'};
    this.subscribeToEvents();
  }

  transformToDashboard(dashboard: DashboardMenuItem): Dashboard {
    const newdash: Dashboard = {
      title: dashboard.label,
      createdAt: dashboard.createdAt,
      id: dashboard.dashId,
      instance: dashboard.instance,
      charts: dashboard.charts, };
    return newdash;
  }

  createDashboard(newDashboard: Dashboard) {
    const item: DashboardMenuItem = {
      dashId: newDashboard.id,
      label: newDashboard.title,
      instance: newDashboard.instance,
      createdAt: newDashboard.createdAt,
      charts: newDashboard.charts,
      command: (onclick) => { this.activeDashboardItem = item; }
    };
    this.dashboardMenuitems.splice(this.dashboardMenuitems.length - 1, 0, item);
    this.loading = false; /*
    this.dashboardsService.create(newDashboard)
    .subscribe(
      (res: Response) => {
        console.log(res);
        const item: DashboardMenuItem = {
          label: newDashboard.title,
          command: (onclick) => { this.activeDashboardItem = {
            dashId: newDashboard.id,
            label: newDashboard.title,
            instance: newDashboard.instance,
            createdAt: newDashboard.createdAt,
            charts: newDashboard.charts}; }
        };
        this.dashboardMenuitems.splice(this.dashboardMenuitems.length - 1, 0, item);
        this.loading = false; },
      error => {
        console.log(`Error: ${error}`);
        this.loading = false;
      });*/
    }

  updateDashboard(editTitle: string) {
    const index = this.dashboardMenuitems.findIndex(d => d === this.activeDashboardItem);
    const payload: Dashboard = this.transformToDashboard(this.dashboardMenuitems[index]);
    payload.title = editTitle;
    // remove below
    this.dashboardMenuitems[index].label = payload.title;
    this.loading = false;

    /*this.dashboardsService.update(payload)
      .subscribe(
        (res: Response) => {
          console.log(res);
          this.dashboardMenuitems[index].label = payload.title;
          this.loading = false; },
        error => {
          console.log(`Error: ${error}`);
          this.loading = false;
         });*/
  }

  deleteDashboard(dashboard: DashboardMenuItem) {
    const index = this.dashboardMenuitems.findIndex(d => d === this.activeDashboardItem);
        this.dashboardMenuitems.splice(index, 1);

        if (this.dashboardMenuitems.length >= 1 ) {
          this.activeDashboardItem = this.dashboardMenuitems[0];
        } else {
            this.activeDashboardItem = null; }

        this.loading = false;
    /*this.dashboardsService.delete(dashboard.dashId)
      .subscribe((res: Response) => {
        console.log(res);
        const index = this.dashboardMenuitems.findIndex(d => d === this.activeDashboardItem);
        this.dashboardMenuitems.splice(index, 1);

        if (this.dashboardMenuitems.length >= 1 ) {
          this.activeDashboardItem = this.dashboardMenuitems[0];
        } else {
            this.activeDashboardItem = null; }

        this.loading = false; },
        error => {
          console.log(`Error: ${error}`);
        this.loading = false; });*/ }

  async delete() {
    if (await this.toastrService.confirm('You sure you want to delete dashboard ?')) {
      this.loading = true;
      this.deleteDashboard(this.activeDashboardItem); }}

      suc() { this.toastrService.success('gt'); }
  configureDashboards() {
      this.dashboardsService.getAllByInstance(this.instance.id).subscribe(
    (data: Dashboard[]) => {
      this.dashboardMenuitems = data.map(
        dash => {
          const item: DashboardMenuItem = {
            label: dash.title,
            dashId: dash.id,
            instance: dash.instance,
            createdAt: dash.createdAt,
            charts: dash.charts,
            command: (onclick) => {
              this.activeDashboardItem = item; }
          };
          return item; }
      );

      this.loading = false; },
    error => {
      console.log(`Error: ${error}`);
      this.loading = false; } );
  }

  showCreatePopup(creation: boolean) {
    this.creation = creation;
    this.editTitle = creation ? '' : this.activeDashboardItem.label;
    this.displayEditDashboard = true;
  }

  onEdited(title: string) {
    this.loading = true;
    if (this.creation === true) {
      const newdash: Dashboard = {title: title, createdAt: new Date(), instance: this.instance };
      this.createDashboard(newdash);
    let index = 0;
    // switching to new tab
    if (this.dashboardMenuitems.length >= 2 ) {
      index = this.dashboardMenuitems.length - 2;
      this.activeDashboardItem = {
        label: newdash.title,
        dashId: newdash.id,
        createdAt: newdash.createdAt,
        instance: newdash.instance,
        charts: newdash.charts
      };
      this.activeDashboardItem = this.dashboardMenuitems[index]; }
    } else {
      this.updateDashboard(title);
    }
    this.creation = false;
    this.displayEditDashboard = false;
  }

  onClosed() {
    if (this.creation === true) {
      if (this.dashboardMenuitems.length >= 2) {
        // switching to last dashboard if popup is closed without save
        const index = this.dashboardMenuitems.length - 2;
        const label = this.dashboardMenuitems[index].label.slice();

        const x: DashboardMenuItem = {
          label: label,
          dashId: this.dashboardMenuitems[index].dashId,
          createdAt: this.dashboardMenuitems[index].createdAt,
          instance: this.dashboardMenuitems[index].instance,
          charts: this.dashboardMenuitems[index].charts
        };
        this.dashboardMenuitems[index] = x;
        this.activeDashboardItem = this.dashboardMenuitems[index]; }
    }
      this.creation = false;
      this.displayEditDashboard = false;
      this.toastrService.success('sadasda');
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
    this.toastrService.success('message');
    // this.loading = true;
    // this.configureDashboards();
    const item1: DashboardMenuItem = {
      label: 'RAM',
      instance: this.instance,
      createdAt: new Date(),
      command: (onclick) => {
        this.activeDashboardItem = item1; }
    };
    const item2: DashboardMenuItem = {
      label: 'CAM',
      instance: this.instance,
      createdAt: new Date(),
      command: (onclick) => {
        this.activeDashboardItem = item2;
        console.log(this.activeDashboardItem); }
    };
    this.dashboardMenuitems = [item1, item2];

    const lastItem: DashboardMenuItem = {
      label: 'Add new',
      icon: 'fa fa-plus',
      command: (onlick) =>  {
        this.showCreatePopup(true); },
      id: 'lastTab' };

    this.dashboardMenuitems.push(lastItem);
    this.activeDashboardItem = this.dashboardMenuitems[0];
  }
}
