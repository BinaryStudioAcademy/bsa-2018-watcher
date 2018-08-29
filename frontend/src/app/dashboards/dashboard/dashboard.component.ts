import { Component, NgZone, OnDestroy, OnInit } from '@angular/core';
import { ConfirmationService, MenuItemContent } from 'primeng/primeng';
import { MessageService, MenuItem } from 'primeng/api';
import { DashboardService } from '../../core/services/dashboard.service';
import { Dashboard } from '../../shared/models/dashboard.model';
import { ToastrService } from '../../core/services/toastr.service';
import { DashboardMenuItem } from '../models';
import { DashboardRequest } from '../../shared/models/dashboard-request.model';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { InstanceService } from '../../core/services/instance.service';
import { DashboardsHub } from '../../core/hubs/dashboards.hub';
import { PercentageInfo } from '../models/percentage-info';
import { CustomChart, CustomData, CustomQuery, Filter, gapminder, toCapitalizedWords } from '../charts/models';
import { DataService } from '../services/data.service';

import { ChartType } from '../../shared/models/chart-type.enum';
import { ChartRequest } from '../../shared/requests/chart-request.model';
import { ChartService } from '../../core/services/chart.service';
import { SelectItem } from 'primeng/api';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { single1 } from '../models/data';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass'],
  providers: [ToastrService, ConfirmationService, DashboardService, MessageService]
})

export class DashboardComponent implements OnInit, OnDestroy {
  private paramsSubscription: Subscription;
  private instanceGuidId: string;

  isEditMode = false;
  instanceId: number;
  dashboards: Dashboard[] = [];
  dashboardMenuItems: DashboardMenuItem[] = [];
  activeDashboardItem: DashboardMenuItem = {};

  editTitle: string;
  creation: boolean;
  loading = false;
  displayEditDashboard = false;
  percentageInfoToDisplay: PercentageInfo[];
  percentageInfoToDisplaySingle: PercentageInfo;
  popupAddChart: Boolean = false;
  dropdownType: SelectItem[];
  selectedType: string;
  cogItems: MenuItem[];

  single1: any[];
  view: any[] = [564, 282];
  showXAxis = true;
  showYAxis = true;
  gradient = false;
  showLegend = true;
  showXAxisLabel = true;
  xAxisLabel = 'x';
  showYAxisLabel = true;
  yAxisLabel = 'y';
  colorScheme = {
    domain: ['#5AA454', '#A10A28', '#C7B42C', '#AAAAAA']
  };

  set PercentageInfoToDisplay(info: PercentageInfo[]) {
    this.percentageInfoToDisplay = info;
  }

  set PercentageInfoToDisplaySingle(info: PercentageInfo) {
    this.percentageInfoToDisplaySingle = info;
  }

  charts: CustomChart[] = [];
  filters: Filter[] = [];

  errors: any[] = [];
  rawData: CustomData[] = [];

  constructor(private dashboardsService: DashboardService,
    private instanceService: InstanceService,
    private dashboardsHub: DashboardsHub,
    private toastrService: ToastrService,
    private chartService: ChartService,
    private activateRoute: ActivatedRoute,
    private fb: FormBuilder,
    private ngZone: NgZone,
    private dataService: DataService) {

      this.dropdownType = [
        {label: 'Bar vertical', value: 'Bar vertical'},
        {label: 'Line chart', value: 'Line chart'},
        {label: 'Pie', value: 'Pie'},
        {label: 'Guage', value: 'Guage'}
      ];

  }

  chartForm = this.fb.group({
    xAxisLabel: new FormControl({ value: 'x', disabled: false }),
    yAxisLabel: new FormControl({ value: 'y', disabled: false })
  });

  async ngOnInit(): Promise<void> {
    this.instanceService.instanceRemoved.subscribe(instance => this.onInstanceRemoved(instance));

    await this.dashboardsHub.connectToSignalR();

    this.paramsSubscription = this.activateRoute.params.subscribe(params => {
      if (this.instanceGuidId) {
        this.dashboardsHub.unSubscribeFromInstanceById(this.instanceGuidId);
      }

      this.instanceId = params.insId;
      this.instanceGuidId = params.guidId;
      this.dashboardMenuItems = [];
      if (!this.instanceId) {
        return;
      }

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
    });

    this.cogItems = [{
      label: 'Add item',
      icon: 'fa fa-fw fa-plus',
      command: (event?: any) => this.showPopupAddChart(),
    },
    {
      label: 'Edit',
      icon: 'fa fa-fw fa-edit',
      command: (event?: any) => this.showCreatePopup(false),
    },
    {
      label: 'Delete',
      icon: 'fa fa-fw fa-remove',
      command: (event?: any) => this.delete(),
    }
    ];
  }

  getSignalRClaims() {
    this.dashboardsHub.getSignalRClaims();
  }

  ngOnDestroy(): void {
    this.paramsSubscription.unsubscribe();
  }

  async addChartToDashboard(chart: CustomChart) {
    this.charts.push(chart);

    // todo: assumes single series chart
    const x = this.dataService.createQuery(chart.dataDims[0], chart.dataDims[2], chart.dataDims[4]);
    const y = this.dataService.createQuery(chart.dataDims[2], 'count');

    const qs = await Promise.all([x, y]);

    chart.xQuery = qs[0];
    chart.yQuery = qs[1];

    chart.xFilter = this.addFilter(chart.xQuery);
    chart.yFilter = this.addFilter(chart.yQuery);

    this.isEditMode = false;
  }

  private addFilter(query: CustomQuery): Filter {
    const key = query.column.key;
    let filter = this.filters.find(c => c.key === key);
    if (!filter) {
      const values = query.column.values;
      const minValue = Math.min(...values);
      const maxValue = Math.max(...values);

      const type = (values.length < 6 || isNaN(minValue) || isNaN(maxValue)) ? 'cat' : 'value';

      let range = [];
      let rangeIndex = {};
      if (type === 'value') {
        range = [minValue, maxValue];
      } else {
        range = query.column.values.slice(0);
        rangeIndex = range.reduce((acc, cur) => {
          acc[cur] = true;
          return acc;
        }, rangeIndex);
      }

      filter = {
        type,
        label: toCapitalizedWords(key),
        key,
        minValue,
        maxValue,
        query,
        step: 1,
        values,
        rangeIndex,
        range
      };
      this.filters.push(filter);
    }
    return filter;
  }

  onInstanceRemoved(id: number) {
    this.instanceId = 0;
    this.dashboards = [];
    this.dashboardMenuItems = []; // no +
    this.activeDashboardItem = null;
  }

  getDashboardsByInstanceId(id: number): void {
    this.loading = true;
    const plusItem = this.createPlusItem();
    this.dashboardMenuItems.push(plusItem);
    this.dashboardsService.getAllByInstance(id)
      .subscribe((value = []) => {
        if (value && value.length > 0) {
          this.dashboards = value;
          // Fill Dashboard Menu Items
          this.dashboardMenuItems.unshift(...this.dashboards.map(dash => this.transformToMenuItem(dash)));
          this.activeDashboardItem = this.dashboardMenuItems[0];
        }
        this.loading = false;
        this.toastrService.success('Successfully got instance info from server');
      }, error => this.toastrService.error(error.toString()));
  }

  createPlusItem(): DashboardMenuItem {
    const lastItem: DashboardMenuItem = {
      icon: 'fa fa-plus',
      command: (onlick) => {
        this.activeDashboardItem = lastItem;
        this.showCreatePopup(true);
      },
      id: 'lastTab'
    };

    return lastItem;
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
    console.log(this.creation);
    console.log('CREATION ON SHOW');
    // if we are adding new, textbox needs to be clear
    this.editTitle = creation ? '' : this.activeDashboardItem.label;
    this.displayEditDashboard = true;
  }

  showAddItemPopup(): void {
    this.isEditMode = true;
  }


  onEdited(title: string) {
    this.loading = true;
    if (this.creation === true) {
      const newdash: DashboardRequest = { title: title, instanceId: this.instanceId };
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
      } else {
        this.activeDashboardItem = undefined;
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
      // routerLink: `/user/instances/${this.instanceId}/${this.instanceGuidId}/dashboards/${dashboard.id}`,
      command: (onclick) => {
        this.activeDashboardItem = item;
      }
    };
    return item;
  }

  onView() {
    this.xAxisLabel = this.chartForm.get('xAxisLabel').value;
    this.yAxisLabel = this.chartForm.get('yAxisLabel').value;
    Object.assign(this,  {single1} );
  }

  showPopupAddChart() {
    this.popupAddChart = true;


  }

  onCancel() {
    this.popupAddChart = false;
  }

  createChart() {
    const chart: ChartRequest = {
      type: ChartType.Multiple, // if ChartType.Plot -> Bad request
      source: 'source',
      showCommon: 'showCommon1',
      threshold: 16,
      mostLoaded: 'mostLoaded',
      dashboardId: 102// this.activeDashboardItem.dashId
    };
    console.log(chart);
    return chart;
  }

  onCreateChart() {
    this.popupAddChart = false;

    if (true) {
      this.chartService.create(this.createChart()).subscribe(
        value => {
          this.toastrService.success('Chart was created');
          // this.activeDashboardItem.charts.push(value);
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error.message}`);
        });
    }
  }

  onEditChart(chart: ChartRequest) {
    this.chartService.update(111, this.createChart()).subscribe(
      value => {
        this.toastrService.success('The chart was updated');
      },
      error => {
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });
  }

  onDeleteChart(id: number) {
    this.chartService.delete( 111 ).subscribe(
      value => {
        this.toastrService.success('The chart was deleted');
      },
      error => {
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });
  }
}
