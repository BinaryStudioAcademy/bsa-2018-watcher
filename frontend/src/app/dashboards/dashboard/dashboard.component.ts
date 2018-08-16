import {Component, OnInit} from '@angular/core';
import {ConfirmationService} from 'primeng/primeng';
import {MessageService} from 'primeng/api';
import {DashboardService} from '../../core/services/dashboard.service';
import {Dashboard} from '../../shared/models/dashboard.model';
import {Instance} from '../../shared/models/instance.model';
import {ToastrService} from '../../core/services/toastr.service';
import {DashboardMenuItem} from '../models/dashboard-menuitem.model';
import {DashboardRequest} from '../../shared/models/dashboard-request.model';

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

  constructor(private dashboardsService: DashboardService,
              private toastrService: ToastrService) {
    this.activeDashboardItem = {};
    this.dashboardMenuitems = [];
  }

  ngOnInit() {
    this.loading = true;
    this.dashboardsService.getDefaultInstance()
      .subscribe(value => {
        this.instance = value;
        if (this.instance.dashboards && this.instance.dashboards.length > 0) {
          // Fill Dashboard Menu Items
          this.dashboardMenuitems.unshift(...this.instance.dashboards.map(dash => this.transformToMenuItem(dash)));
          this.activeDashboardItem = this.dashboardMenuitems[0];
        }
        this.loading = false;
        this.toastrService.success('Successfully got instance info from server');
      }, error => this.toastrService.error(error.toString()));

    const lastItem: DashboardMenuItem = {
      icon: 'fa fa-plus',
      command: (onlick) => {
        this.showCreatePopup(true);
      },
      id: 'lastTab'
    };
    this.loading = false;
    this.dashboardMenuitems.push(lastItem);
  }

  createDashboard(newDashboard: DashboardRequest): void {
    this.dashboardsService.create(newDashboard)
      .subscribe((dto) => {
          const item: DashboardMenuItem = this.transformToMenuItem(dto);
          // this.dashboardMenuitems.splice(this.dashboardMenuitems.length - 1, 0, item);
          this.dashboardMenuitems.unshift(item);
          this.activeDashboardItem = this.dashboardMenuitems[0];
          this.loading = false;
          this.toastrService.success('Added new dashboard');
        },
        error => {
          this.loading = false;
          this.toastrService.error(`Error ocured status: ${error}`);
        });
  }

  updateDashboard(editTitle: string): void {
    const index = this.dashboardMenuitems.findIndex(d => d === this.activeDashboardItem);
    const request: DashboardRequest = {
      title: editTitle,
      instanceId: this.instance.id
    };

    this.dashboardsService.update(this.dashboardMenuitems[index].dashId, request)
      .subscribe(
        (res: Response) => {
          console.log(res);
          this.dashboardMenuitems[index].label = editTitle;
          this.loading = false;
          this.toastrService.success('Updated dashboard');
        },
        error => {
          this.loading = false;
          this.toastrService.error(`Error ocured status: ${error}`);
        });
  }

  deleteDashboard(dashboard: DashboardMenuItem): void {
    this.dashboardsService.delete(dashboard.dashId)
      .subscribe((res: Response) => {
          console.log(res);
          // Search and delete selected Item
          const index = this.dashboardMenuitems.findIndex(d => d === this.activeDashboardItem);
          this.dashboardMenuitems.splice(index, 1);

          // [0] - is + button
          if (this.dashboardMenuitems.length > 1) {
            this.activeDashboardItem = this.dashboardMenuitems[0];
          } else {
            this.activeDashboardItem = null;
          }

          this.loading = false;
          this.toastrService.success('Deleted dashboard');
        },
        error => {
          this.loading = false;
          this.toastrService.error(`Error occured status: ${error}`);
        });
  }

  async delete(): Promise<void> {
    if (await this.toastrService.confirm('You sure you want to delete dashboard ?')) {
      this.loading = true;
      this.deleteDashboard(this.activeDashboardItem);
    }
  }

  showCreatePopup(creation: boolean): void {
    this.creation = creation;
    // if we are adding new textbox needs to be clear
    this.editTitle = creation ? '' : this.activeDashboardItem.label;
    this.displayEditDashboard = true;
  }

  onEdited(title: string) {
    this.loading = true;
    if (this.creation === true) {
      const newdash: DashboardRequest = {title: title, instanceId: this.instance.id};
      this.createDashboard(newdash);
      let index = 0;
      // switching to new tab
      if (this.dashboardMenuitems.length >= 2) {
        index = this.dashboardMenuitems.length - 2;
        this.activeDashboardItem = this.dashboardMenuitems[index];
      }
    } else {
      this.updateDashboard(title);
    }
    this.creation = false;
    this.displayEditDashboard = false;
  }

  onClosed() {
    if (this.creation === true) {
      if (this.dashboardMenuitems.length > 1) {
        // switching to last dashboard if popup is closed without save
        const index = this.dashboardMenuitems.length - 2;
        const label = this.dashboardMenuitems[index].label.slice();

        // TODO: refactor this shit below
        const x: DashboardMenuItem = {
          label: label,
          dashId: this.dashboardMenuitems[index].dashId,
          createdAt: this.dashboardMenuitems[index].createdAt,
          charts: this.dashboardMenuitems[index].charts,
          command: this.dashboardMenuitems[index].command
        };

        this.dashboardMenuitems[index] = x;
        this.activeDashboardItem = this.dashboardMenuitems[index];
      }
    }
    this.creation = false;
    this.displayEditDashboard = false;
  }

  transformToMenuItem(dashboard: Dashboard): DashboardMenuItem {
    const item: DashboardMenuItem = {
      label: dashboard.title,
      dashId: dashboard.id,
      createdAt: dashboard.createdAt,
      charts: dashboard.charts,
      command: (onclick) => {
        this.activeDashboardItem = item;
      }
    };
    return item;
  }
}
