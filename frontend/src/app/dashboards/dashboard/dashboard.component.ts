import {Component, NgZone, OnDestroy, OnInit} from '@angular/core';
import {ConfirmationService} from 'primeng/primeng';
import {MenuItem, MessageService, SelectItem} from 'primeng/api';
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
import {CustomChart, CustomChartType, CustomData} from '../charts/models';
import {DataService} from '../services/data.service';

import {Chart} from '../../shared/models/chart.model';
import {ChartType, chartTypes} from '../../shared/models/chart-type.enum';
import {ChartRequest} from '../../shared/requests/chart-request.model';
import {ChartService} from '../../core/services/chart.service';
import {FormBuilder, FormControl} from '@angular/forms';
import {CollectedDataService} from '../../core/services/collected-data.service';
import {CollectedData} from '../../shared/models/collected-data.model';
import {customChartTypes} from '../charts/chart-builder/customChartTypes';
import {colorSets} from '@swimlane/ngx-charts/release/utils';
import * as shape from 'd3-shape';
import {DataProperty} from '../../shared/models/data-property.enum';
import {DashboardChart} from '../models/dashboard-chart';

const defaultOptions = {
  view: [716, 337],
  // colorScheme:  {
  //   domain: ['#5AA454', '#A10A28', '#C7B42C', '#AAAAAA']
  // },
  colorScheme: colorSets.find(s => s.name === 'cool'),
  schemeType: 'ordinal',
  showLegend: true,
  legendTitle: 'Legend',
  gradient: false,
  showXAxis: true,
  showYAxis: true,
  showXAxisLabel: true,
  showYAxisLabel: true,
  yAxisLabel: '',
  xAxisLabel: '',
  autoScale: true,
  showGridLines: true,
  rangeFillOpacity: 0.5,
  roundDomains: false,
  tooltipDisabled: false,
  showSeriesOnHover: true,
  curve: shape.curveLinear,
  curveClosed: shape.curveCardinalClosed
} as CustomChart;

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.sass'],
  providers: [ToastrService, ConfirmationService, DashboardService, MessageService]
})
export class DashboardComponent implements OnInit, OnDestroy {
  private paramsSubscription: Subscription;
  private instanceGuidId: string;

  instanceId: number;
  dashboards: Dashboard[] = [];
  dashboardMenuItems: DashboardMenuItem[] = [];
  activeDashboardItem: DashboardMenuItem = {};

  editTitle: string;
  creation: boolean;
  loading = false;
  displayEditDashboard = false;
  collectedDataForChart: CollectedData[] = [];
  percentageInfoToDisplay: PercentageInfo[] = [];
  percentageInfoToDisplaySingle: PercentageInfo;
  popupAddChart = false;
  dropdownType: SelectItem[];
  dropdownSource: SelectItem[];
  selectedType: ChartType;
  selectedSource: DataProperty[] = [];
  cogItems: MenuItem[];
  threshold: number;

  // Inputs for Chart
  chartOptions: CustomChart = defaultOptions;
  dataForChart: CustomData[] = [];
  chartType: CustomChartType = customChartTypes[0];
  showPreview = false;

  set PercentageInfoToDisplay(info: PercentageInfo[]) {
    this.percentageInfoToDisplay = info;
  }

  set PercentageInfoToDisplaySingle(info: PercentageInfo) {
    this.percentageInfoToDisplaySingle = info;
  }

  constructor(private dashboardsService: DashboardService,
              private collectedDataService: CollectedDataService,
              private instanceService: InstanceService,
              private dashboardsHub: DashboardsHub,
              private toastrService: ToastrService,
              private chartService: ChartService,
              private activateRoute: ActivatedRoute,
              private fb: FormBuilder,
              private ngZone: NgZone,
              private dataService: DataService) {

    this.dropdownType = [
      {label: 'Bar vertical', value: ChartType.BarVertical},
      {label: 'Line chart', value: ChartType.LineChart},
      {label: 'Pie', value: ChartType.Pie},
      {label: 'Guage', value: ChartType.Guage}
    ];

    this.dropdownSource = [
      {label: 'CPU', value: DataProperty.cpuUsagePercent},
      {label: 'RAM', value: DataProperty.ramUsagePercent},
      {label: 'DISC', value: DataProperty.localDiskFreeSpacePercent}
    ];
  }

  chartForm = this.fb.group({
    isMultiple: new FormControl({value: false, disabled: false}),
    mostLoaded: new FormControl({value: 1, disabled: false}),
    xAxisLabel: new FormControl({value: '', disabled: false}),
    yAxisLabel: new FormControl({value: '', disabled: false})
  });

  processData(): void {
    // this.chartOptions.xAxisLabel = this.chartForm.get('xAxisLabel').value;
    // this.chartOptions.yAxisLabel = this.chartForm.get('yAxisLabel').value;
    this.chartType.name = chartTypes[this.selectedType];
    this.dataForChart = this.dataService.prepareData(this.selectedType, this.selectedSource, this.collectedDataForChart);
    this.showPreview = true;

    if (this.selectedType === ChartType.BarVertical) {
      this.chartOptions.xAxisLabel = 'Parameters';
      this.chartOptions.yAxisLabel = 'Percentage %';
    } else if (this.selectedType === ChartType.LineChart) {
      this.chartOptions.xAxisLabel = 'Time';
      this.chartOptions.yAxisLabel = 'Percentage %';
    } else if (this.selectedType === ChartType.Guage) {
      this.chartOptions.yAxisLabel = 'Process';
      this.chartOptions.xAxisLabel = '';
    }
    /* if (this.selectedType === ChartType.BarVertical) {
       this.chartOptions.xAxisLabel = this.chartForm.get('xAxisLabel').value ? this.chartForm.get('xAxisLabel').value : 'Parameters';
       this.chartOptions.yAxisLabel = this.chartForm.get('yAxisLabel').value ? this.chartForm.get('yAxisLabel').value : 'Percentage %';
     } else if (this.selectedType === ChartType.LineChart) {
       this.chartOptions.xAxisLabel = this.chartForm.get('xAxisLabel').value ? this.chartForm.get('xAxisLabel').value : 'Time';
       this.chartOptions.yAxisLabel = this.chartForm.get('yAxisLabel').value ? this.chartForm.get('yAxisLabel').value : 'Percentage %';
     } else if (this.selectedType === ChartType.Guage) {
       this.chartOptions.yAxisLabel = this.chartForm.get('yAxisLabel').value ? this.chartForm.get('yAxisLabel').value : 'Process';
     }*/
  }

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

    this.collectedDataService.getBuilderData()
      .subscribe(value => {
        this.collectedDataForChart = value;
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

  ngOnDestroy(): void {
    this.paramsSubscription.unsubscribe();
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
      .subscribe((value) => {
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
      } else {
        this.activeDashboardItem = undefined;
      }
    }
    this.creation = false;
    this.displayEditDashboard = false;
  }

  transformToMenuItem(dashboard: Dashboard): DashboardMenuItem {
    const dashChats: DashboardChart[] = dashboard.charts.map(c => this.instantiateDashboardChart(c));

    const item: DashboardMenuItem = {
      label: dashboard.title,
      dashId: dashboard.id,
      createdAt: dashboard.createdAt,
      charts: dashChats,
      // routerLink: `/user/instances/${this.instanceId}/${this.instanceGuidId}/dashboards/${dashboard.id}`,
      command: (onclick) => {
        this.activeDashboardItem = item;
      }
    };
    return item;
  }

  convertStringToArrEnum(sources: string) {
    const array = new Array<DataProperty>();
    const newSources = sources.split(',');
    for (let i = 0; i < newSources.length; i++) {
      array.push(DataProperty[newSources[i]]);
    }
    return array;
  }

  showPopupAddChart() {
    this.processData();
    this.popupAddChart = true;
  }

  closeMy() {
    // this.processData();
    this.onCancel();
  }

  onCancel() {
    this.popupAddChart = false;
    this.selectedSource = null;
    this.selectedType = null;
    this.threshold = 0;
    this.chartForm.reset();
    this.dataForChart = [];
  }

  onCreateChart() {
    this.popupAddChart = false;

    if (true) {
      this.chartService.create(this.createChartRequest()).subscribe(
        value => {
          const dashChat: DashboardChart = this.instantiateDashboardChart(value);
          this.activeDashboardItem.charts.push(dashChat);
          this.toastrService.success('Chart was created');
          // this.charts.push(dashChat);
        },
        error => {
          this.toastrService.error(`Error ocured status: ${error.message}`);
        });
    }
  }

  instantiateDashboardChart(value: Chart): DashboardChart {
    debugger;
    const props: DataProperty[] = [];
    const arrNumbers = value.sources.split(',');

    for (let i = 0; i < arrNumbers.length; i++) {
      props.push(DataProperty[arrNumbers[i]]);
    }
    const dashChart: DashboardChart = {
      view: [800, 400],
      colorScheme: defaultOptions.colorScheme,
      schemeType: defaultOptions.schemeType,
      showLegend: value.showLegend,
      legendTitle: value.legendTitle,
      gradient: value.gradient,
      showXAxis: value.showXAxis,
      showYAxis: value.showYAxis,
      showXAxisLabel: value.showXAxisLabel,
      showYAxisLabel: value.showYAxisLabel,
      yAxisLabel: value.yAxisLabel,
      xAxisLabel: value.xAxisLabel,
      autoScale: value.autoScale,
      showGridLines: value.showGridLines,
      rangeFillOpacity: value.rangeFillOpacity,
      roundDomains: value.roundDomains,
      tooltipDisabled: value.isTooltipDisabled,
      showSeriesOnHover: value.isShowSeriesOnHover,
      curve: defaultOptions.curve,
      curveClosed: defaultOptions.curveClosed,

      title: value.title,

      data: this.dataService.prepareData(value.type, props, this.collectedDataForChart), // this.dataForChart,
      activeEntries: [],
      chartType: {
        name: chartTypes[value.type],
        title: '',
        chartLabels: null,
        dimLabels: []
      },
      theme: value.isLightTheme ? 'light' : 'dark'
    };

    return dashChart;
  }

  createChartRequest(): ChartRequest {
    debugger;
    const chart: ChartRequest = {
      showCommon: this.chartForm.get('isMultiple').value,
      threshold: this.threshold,
      mostLoaded: '' + this.chartForm.get('mostLoaded').value,
      dashboardId: this.activeDashboardItem.dashId,
      schemeType: this.chartOptions.schemeType,

      showLegend: this.chartOptions.showLegend,
      legendTitle: this.chartOptions.legendTitle,
      gradient: this.chartOptions.gradient,
      showXAxis: this.chartOptions.showXAxis,
      showYAxis: this.chartOptions.showYAxis,
      showXAxisLabel: this.chartOptions.showXAxisLabel,
      showYAxisLabel: this.chartOptions.showYAxisLabel,
      yAxisLabel: this.chartOptions.yAxisLabel,
      xAxisLabel: this.chartOptions.xAxisLabel,
      autoScale: this.chartOptions.autoScale,
      showGridLines: this.chartOptions.showGridLines,
      rangeFillOpacity: this.chartOptions.rangeFillOpacity,
      roundDomains: this.chartOptions.roundDomains,
      isTooltipDisabled: this.chartOptions.tooltipDisabled,
      isShowSeriesOnHover: this.chartOptions.showSeriesOnHover,
      title: this.chartOptions.title,
      type: this.selectedType,
      sources: this.selectedSource.join(),
      isLightTheme: this.chartOptions.theme === 'light',
    };
    return chart;
  }

  // onEditChart(chart: ChartRequest) {
  //   this.chartService.update(1, chart).subscribe(
  //     value => {
  //       this.toastrService.success('The chart was updated');
  //     },
  //     error => {
  //       this.toastrService.error(`Error ocured status: ${error.message}`);
  //     });
  // }
  //
  //
  // onDeleteChart(id: number) {
  //   this.chartService.delete(111).subscribe(
  //     value => {
  //       this.toastrService.success('The chart was deleted');
  //     },
  //     error => {
  //       this.toastrService.error(`Error ocured status: ${error.message}`);
  //     });
  // }
  //
  // getSignalRClaims() {
  //   this.dashboardsHub.getSignalRClaims();
  // }
}
