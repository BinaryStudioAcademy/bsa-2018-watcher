import {Component, EventEmitter, OnDestroy, OnInit} from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {Subscription} from 'rxjs';
import {MenuItem} from 'primeng/api';

import {ToastrService} from '../../core/services/toastr.service';
import {InstanceService} from '../../core/services/instance.service';
import {DashboardService} from '../../core/services/dashboard.service';
import {AuthService} from '../../core/services/auth.service';
import {DataService} from '../../core/services/data.service';
import {ChartService} from '../../core/services/chart.service';
import {CollectedDataService} from '../../core/services/collected-data.service';

import {DashboardsHub} from '../../core/hubs/dashboards.hub';

import {defaultOptions} from '../charts/models/chart-options';
import {DashboardMenuItem} from '../models';
import {DashboardChart} from '../models/dashboard-chart';
import {Dashboard} from '../../shared/models/dashboard.model';
import {DashboardRequest} from '../../shared/models/dashboard-request.model';
import {CollectedData} from '../../shared/models/collected-data.model';

import {UserOrganizationService} from '../../core/services/user-organization.service';
import {ChartType} from '../../shared/models/chart-type.enum';
import {CollectedDataType} from '../../shared/models/collected-data-type.enum';


@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass']
})
export class DashboardComponent implements OnInit, OnDestroy {
  private paramsSubscription: Subscription;
  private instanceGuidId: string;

  onDisplayChartEditing = new EventEmitter<boolean>();

  instanceId: number;
  dashboards: Dashboard[] = [];
  dashboardMenuItems: DashboardMenuItem[] = [];
  activeDashboardItem: DashboardMenuItem = {};

  editTitle: string;
  creation: boolean;
  isLoading = false;
  displayEditDashboard = false;
  cogItems: MenuItem[];
  chartToEdit = {...defaultOptions};
  isManager: boolean;

  constructor(private dashboardsService: DashboardService,
              private collectedDataService: CollectedDataService,
              private instanceService: InstanceService,
              private dashboardsHub: DashboardsHub,
              private toastrService: ToastrService,
              private activateRoute: ActivatedRoute,
              private authService: AuthService,
              private dataService: DataService,
              private chartService: ChartService,
              private userOrganizationService: UserOrganizationService) {
  }

  async ngOnInit(): Promise<void> {
    // TODO: maybe do unrelated request with fork join to reduce # of request
    this.collectedDataService.getBuilderData()
      .subscribe(value => {
        this.dataService.fakeCollectedData = value;
      });

    try {
      const [firebaseToken, watcherToken] = await this.authService.getTokens().toPromise();
      await this.dashboardsHub.connectToSignalR(firebaseToken, watcherToken);
    } catch (e) {
      console.error('Error occurred while connecting to signalRHub ' + JSON.stringify(e));
    }
    this.instanceService.instanceRemoved.subscribe(instance => this.onInstanceRemoved(instance));

    this.paramsSubscription = this.activateRoute.params.subscribe(params => {
      if (this.instanceGuidId) {
        this.dashboardsHub.unSubscribeFromInstanceById(this.instanceGuidId);
      }

      this.instanceId = params.insId;
      this.instanceGuidId = params.guidId;
      this.dashboardMenuItems = [];
      this.dashboards = [];
      this.dataService.hourlyCollectedData = [];
      if (!this.instanceId) {
        return;
      }

      this.isLoading = true;
      this.getDashboardsByInstanceId(this.instanceId).then(value => {
        this.onDashboards(value);
        this.isLoading = false;
        this.collectedDataService.getCollectedDataByInstanceId(this.instanceGuidId, CollectedDataType.Accumulation)
          .subscribe(data => {
            this.dataService.hourlyCollectedData = data;
            if (this.dataService.hourlyCollectedData && this.dataService.hourlyCollectedData.length > 0) {
              // -1 is last item - plus sign
              if (this.dashboardMenuItems && this.dashboardMenuItems.length > 1) {
                this.fillDashboardChartsWithData(this.activeDashboardItem);
              }
            }
            this.dashboardsHub.subscribeToInstanceById(this.instanceGuidId);
          }, err => {
            console.error(err);
            this.toastrService.error('Error occurred while fetching instance\'s Collected Data');
            this.isLoading = false;
          });
      }).catch(reason => {
        console.error(reason);
        this.toastrService.error('Error occurred while fetching instance\'s Dashboards');
        this.isLoading = false;
      });
    });

    this.cogItems = [{
      label: 'Add item',
      icon: 'fa fa-fw fa-plus',

      command: (event?: any) => {
        this.decomposeChart(defaultOptions);
        this.showChartCreating();
      },
    },
      {
        label: 'Edit',
        icon: 'fa fa-fw fa-edit',
        command: () => this.showCreatePopup(false),
      },
      {
        label: 'Delete',
        icon: 'fa fa-fw fa-remove',
        command: () => this.delete(),
      }
    ];

    this.subscribeToCollectedData();
  }

  ngOnDestroy(): void {
    this.paramsSubscription.unsubscribe();
  }

  subscribeToCollectedData(): void {
    this.dashboardsHub.infoSubObservable.subscribe((latestData: CollectedData) => {
      this.dataService.pushLatestCollectedData(latestData);
      if (!this.activeDashboardItem.charts || this.activeDashboardItem.charts.length < 1) {
        return;
      }
      for (let i = 0; i < this.activeDashboardItem.charts.length; i++) {
        switch (this.activeDashboardItem.charts[i].type) {
          case ChartType.ResourcesTable:
            this.activeDashboardItem.charts[i].colectedData = latestData;
            break;
          default:
            this.dataService.fulfillChart(this.dataService.hourlyCollectedData, this.activeDashboardItem.charts[i], false);
            break;
        }
      }
    });
  }

  async getDashboardsByInstanceId(id: number): Promise<Dashboard[]> {
    this.isManager = await this.getOrganizationPermissions();
    const plusItem = this.createPlusItem();
    this.dashboardMenuItems.push(plusItem);
    return this.dashboardsService.getAllByInstance(id).toPromise();
  }

  async getOrganizationPermissions(): Promise<boolean> {
    const role = await this.userOrganizationService.getOrganizationRole();
    return role.name === 'Manager';
  }

  onDashboards(value) {
    if (value && value.length) {
      this.dashboards = value;
      // Fill Dashboard Menu Items
      this.dashboardMenuItems.unshift(...this.dashboards.map(dash => this.transformToMenuItem(dash)));
      this.activeDashboardItem = this.dashboardMenuItems[0];
    } else {
      this.dashboards = [];
    }

    this.toastrService.success('Successfully got dashboards info from server');
  }

  createPlusItem(): DashboardMenuItem {
    const lastItem: DashboardMenuItem = {
      icon: 'fa fa-plus',
      command: () => {
        this.activeDashboardItem = lastItem;
        this.showCreatePopup(true);
      },
      id: 'lastTab',
      visible: this.isManager,
    };

    return lastItem;
  }

  createDashboard(title: string, instanceId: number, charts: DashboardChart[]): void {
    const createRequest = this.chartService.instantiateCreateDashboardRequest(title, instanceId, charts);
    this.dashboardsService.create(createRequest)
      .subscribe((dto) => {
          const item: DashboardMenuItem = this.transformToMenuItem(dto);
          this.dashboardMenuItems.unshift(item);
          this.activeDashboardItem = this.dashboardMenuItems[0];
          this.toastrService.success('Successfully added new dashboard!');
        },
        error => {
          this.toastrService.error(`Error occurred status: ${error}`);
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
          this.toastrService.success('Successfully updated dashboard!');
        },
        error => {
          this.toastrService.error(`Error occurred status: ${error}`);
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

          this.toastrService.success('Successfully deleted dashboard!');
        },
        error => {
          this.toastrService.error(`Error occurred status: ${error}`);
        });
  }

  async delete(): Promise<void> {
    if (await this.toastrService.confirm('You sure you want to delete dashboard ?')) {
      this.deleteDashboard(this.activeDashboardItem);
    }
  }

  showCreatePopup(creation: boolean): void {
    this.creation = creation;
    this.editTitle = creation ? '' : this.activeDashboardItem.label;
    this.displayEditDashboard = true;
  }

  onEditChart(chart: DashboardChart) {
    this.decomposeChart(chart);
    this.showChartCreating();
  }

  onEdited(event: any) {
    if (this.creation === true) {
      this.createDashboard(event.title, this.instanceId, event.charts);
      let index = 0;
      // switching to new tab
      if (this.dashboardMenuItems.length >= 2) {
        index = this.dashboardMenuItems.length - 2;
        this.activeDashboardItem = this.dashboardMenuItems[index];
      }
    } else {
      this.updateDashboard(event.title);
    }
    this.creation = false;
    this.displayEditDashboard = false;
  }

  onChartDeleted(chartId: number) {
    const deletedChartIndex = this.activeDashboardItem.charts.findIndex(ch => ch.id === chartId);
    if (deletedChartIndex >= 0) {
      this.activeDashboardItem.charts.splice(deletedChartIndex, 1);
      this.activeDashboardItem.charts = [...this.activeDashboardItem.charts];
      this.toastrService.success('Successfully deleted chart!');
    } else {
      this.toastrService.error('Deleted chart not found!');
    }
  }

  onClosed() {
    if (this.creation === true) {
      if (this.dashboardMenuItems.length > 1) {
        // switching to last dashboard if popup is closed without save
        const index = this.dashboardMenuItems.length - 2;
        const label = this.dashboardMenuItems[index].label.slice();

        this.dashboardMenuItems[index] = {
          label: label,
          dashId: this.dashboardMenuItems[index].dashId,
          createdAt: this.dashboardMenuItems[index].createdAt,
          charts: this.dashboardMenuItems[index].charts,
          command: this.dashboardMenuItems[index].command
        };
        this.activeDashboardItem = this.dashboardMenuItems[index];
      } else {
        this.activeDashboardItem = undefined;
      }
    }
    this.creation = false;
    this.displayEditDashboard = false;
  }

  showChartCreating() {
    this.onDisplayChartEditing.emit(true);
  }

  onChartEditClosed() {
    this.onDisplayChartEditing.emit(false);
  }

  onChartEdited(chart?: DashboardChart) {
    // Don't fill this chart with data, it's already filled in edit chart component
    const updateChartIndex = this.activeDashboardItem.charts.findIndex(ch => ch.id === chart.id);
    if (updateChartIndex >= 0) {
      this.activeDashboardItem.charts[updateChartIndex] = chart;
      this.activeDashboardItem.charts = [...this.activeDashboardItem.charts];
      this.toastrService.success('Successfully updated chart!');
    } else {
      this.activeDashboardItem.charts = [...this.activeDashboardItem.charts, chart];
      this.toastrService.success('Successfully created chart!');
    }
  }

  decomposeChart(chart: DashboardChart): void {
    this.chartToEdit = {...chart};
    this.chartToEdit.colorScheme = {...chart.colorScheme};
    this.chartToEdit.type = chart.type;
  }

  transformToMenuItem(dashboard: Dashboard): DashboardMenuItem {
    const item: DashboardMenuItem = {
      label: dashboard.title,
      dashId: dashboard.id,
      createdAt: dashboard.createdAt,
      charts: dashboard.charts.map(c => this.dataService.instantiateDashboardChart(c)),
      command: () => {
        this.activeDashboardItem = item;
        this.fillDashboardChartsWithData(this.activeDashboardItem);
      }
    };
    return item;
  }

  fillDashboardChartsWithData(dashboardItem: DashboardMenuItem): void {
    for (let j = 0; j < dashboardItem.charts.length; j++) {
      this.dataService.fulfillChart(this.dataService.hourlyCollectedData, dashboardItem.charts[j], false);
    }
    // for (let i = 0; i < this.dashboardMenuItems.length - 1; i++) {
    //   for (let j = 0; j < this.dashboardMenuItems[i].charts.length; j++) {
    //     this.dataService.fulfillChart(this.dataService.hourlyCollectedData, this.dashboardMenuItems[i].charts[j]);
    //   }
    // }
  }

  onInstanceRemoved(id: number): void {
    this.instanceId = null;
    this.dashboards = [];
    this.dashboardMenuItems = [];
    this.activeDashboardItem = null;
    this.dataService.hourlyCollectedData = [];
  }
}
