import {Component, OnDestroy, OnInit} from '@angular/core';
import {ConfirmationService} from 'primeng/primeng';
import {MessageService} from 'primeng/api';
import {DashboardService} from '../../core/services/dashboard.service';
import {Dashboard} from '../../shared/models/dashboard.model';
import {ToastrService} from '../../core/services/toastr.service';
import {DashboardMenuItem} from '../models';
import {DashboardRequest} from '../../shared/models/dashboard-request.model';
import {ActivatedRoute} from '@angular/router';
import {Subscription} from 'rxjs';
import {InstanceService} from '../../core/services/instance.service';
import {DashboardsHub} from '../../core/hubs/dashboards.hub';
import {PercentageInfo} from '../models/percentage-info';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass'],
  providers: [ToastrService, ConfirmationService, DashboardService, MessageService]
})

export class DashboardComponent implements OnInit, OnDestroy {
  instanceId: number;
  private instanceGuidId: string;

  private subscription: Subscription;

  dashboards: Dashboard[] = [];
  dashboardMenuItems: DashboardMenuItem[] = [];
  activeDashboardItem: DashboardMenuItem = {};

  editTitle: string;
  creation: boolean;
  loading = false;
  displayEditDashboard = false;
  percentageInfoToDisplay: PercentageInfo[];
  percentageInfoToDisplaySingle: PercentageInfo;

  set PercentageInfoToDisplay(info: PercentageInfo[]) {
    this.percentageInfoToDisplay = info;
  }

  set PercentageInfoToDisplaySingle(info: PercentageInfo) {
    this.percentageInfoToDisplaySingle = info;
  }

  constructor(private dashboardsService: DashboardService,
              private instanceService: InstanceService,
              private dashboardsHub: DashboardsHub,
              private toastrService: ToastrService,
              private activateRoute: ActivatedRoute) {
  }

  async ngOnInit(): Promise<void> {
    this.instanceService.instanceRemoved.subscribe(instance => this.onInstanceRemoved(instance));

    await this.dashboardsHub.connectToSignalR();

    this.subscription = this.activateRoute.params.subscribe(params => {
      if (this.instanceGuidId) {
        this.dashboardsHub.unSubscribeFromInstanceById(this.instanceGuidId);
      }
      this.instanceId = params['insId'];
      this.instanceGuidId = params['guidId'];

      this.dashboardMenuItems = [];
      if (this.instanceId && this.instanceId !== 0) {
        this.getDashboardsByInstanceId(this.instanceId);

        this.dashboardsHub.getInitialPercentageInfoByInstanceId(this.instanceId)
          .subscribe(info => {
            if (info && info.length > 0) {
              this.PercentageInfoToDisplaySingle = info[info.length - 1];
              this.PercentageInfoToDisplay = info;
            }
            this.dashboardsHub.subscribeToInstanceById(this.instanceGuidId);
          }, err => {
            console.error(err);
            this.toastrService.error('Cant fetch instance collected Data');
          });
      }
    });
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }

  onInstanceRemoved(id: number) {
    this.instanceId = 0;
    this.dashboards = [];
    this.dashboardMenuItems = []; // no +
    this.activeDashboardItem = null;
  }

  getDashboardsByInstanceId(id: number): void {
    this.loading = true;
    const lastItem: DashboardMenuItem = {
      icon: 'fa fa-plus',
      command: (onlick) => {
        this.showCreatePopup(true);
      },
      id: 'lastTab'
    };
    this.dashboardMenuItems.push(lastItem);
    this.dashboardsService.getAllByInstance(id)
      .subscribe(value => {
        this.dashboards = value;
        if (this.dashboards && this.dashboards.length > 0) {
          // Fill Dashboard Menu Items
          this.dashboardMenuItems.unshift(...this.dashboards.map(dash => this.transformToMenuItem(dash)));
          this.activeDashboardItem = this.dashboardMenuItems[0];
        }
        this.loading = false;
        this.toastrService.success('Successfully got instance info from server');
      }, error => this.toastrService.error(error.toString()));
  }

  createDashboard(newDashboard: DashboardRequest): void {
    this.dashboardsService.create(newDashboard)
      .subscribe((dto) => {
          const item: DashboardMenuItem = this.transformToMenuItem(dto);
          this.dashboardMenuItems.unshift(item);
          this.activeDashboardItem = this.dashboardMenuItems[0];
          this.loading = false;
          this.toastrService.success('Added new dashboard');
        },
        error => {
          this.loading = false;
          this.toastrService.error(`Error ocured status: ${error}`);
        });
  }

  updateDashboard(editTitle: string): void {
    const index = this.dashboardMenuItems.findIndex(d => d === this.activeDashboardItem);
    const request: DashboardRequest = {
      title: editTitle,
      instanceId: this.instanceId
    };

    this.dashboardsService.update(this.dashboardMenuItems[index].dashId, request)
      .subscribe(
        (res: Response) => {
          console.log(res);
          this.dashboardMenuItems[index].label = editTitle;
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
          const index = this.dashboardMenuItems.findIndex(d => d === this.activeDashboardItem);
          this.dashboardMenuItems.splice(index, 1);

          // [0] - is + button
          if (this.dashboardMenuItems.length > 1) {
            this.activeDashboardItem = this.dashboardMenuItems[0];
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

  showAddItemPopup(): void {
  }


  onEdited(title: string) {
    this.loading = true;
    if (this.creation === true) {
      const newdash: DashboardRequest = {title: title, instanceId: this.instanceId};
      this.createDashboard(newdash);
      let index = 0;
      // switching to new tab
      if (this.dashboardMenuItems.length >= 2) {
        index = this.dashboardMenuItems.length - 2;
        this.activeDashboardItem = this.dashboardMenuItems[index];
      }
    } else {
      this.updateDashboard(title);
    }
    this.creation = false;
    this.displayEditDashboard = false;
  }

  onClosed() {
    if (this.creation === true) {
      if (this.dashboardMenuItems.length > 1) {
        // switching to last dashboard if popup is closed without save
        const index = this.dashboardMenuItems.length - 2;
        const label = this.dashboardMenuItems[index].label.slice();

        // TODO: refactor this shit below
        const x: DashboardMenuItem = {
          label: label,
          dashId: this.dashboardMenuItems[index].dashId,
          createdAt: this.dashboardMenuItems[index].createdAt,
          charts: this.dashboardMenuItems[index].charts,
          command: this.dashboardMenuItems[index].command
        };

        this.dashboardMenuItems[index] = x;
        this.activeDashboardItem = this.dashboardMenuItems[index];
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
