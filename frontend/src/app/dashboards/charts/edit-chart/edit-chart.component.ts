import {Component, EventEmitter, Input, OnChanges, OnInit, Output} from '@angular/core';
import {ChartType, chartTypes} from '../../../shared/models/chart-type.enum';
import {DataProperty, dataPropertyLables} from '../../../shared/models/data-property.enum';
import {SelectItem, SelectItemGroup} from 'primeng/api';
import {DashboardChart} from '../../models/dashboard-chart';
import {FormBuilder} from '@angular/forms';
import {ChartRequest} from '../../../shared/requests/chart-request.model';
import {CollectedDataService} from '../../../core/services/collected-data.service';
import {CollectedData} from '../../../shared/models/collected-data.model';
import {DataService} from '../../../core/services/data.service';
import {ChartService} from '../../../core/services/chart.service';
import {ToastrService} from '../../../core/services/toastr.service';
import {Chart} from '../../../shared/models/chart.model';
import {dashboardChartTypes} from '../models/dashboardChartTypes';
import {colorSets} from '@swimlane/ngx-charts/release/utils';

@Component({
  selector: 'app-edit-chart',
  templateUrl: './edit-chart.component.html',
  styleUrls: ['./edit-chart.component.sass']
})
export class EditChartComponent implements OnInit, OnChanges {
  @Output() editChart = new EventEmitter<DashboardChart>();
  @Output() closed = new EventEmitter();
  @Output() dashboardChartChange = new EventEmitter();

  visible: boolean;

  @Input() onDisplay: EventEmitter<boolean>;
  @Input() dashboardId: number;

  @Input() dashboardChart: DashboardChart;

  type: ChartType;
  dropdownTypes: SelectItem[];
  dropdownSources: SelectItem[];
  dropdownGroupSources: SelectItemGroup[];

  collectedDataForChart: CollectedData[] = [];
  showPreview = false;
  processDataSource: DataProperty;

  colorSchemes = colorSets;
  historyTime: number;

  get dialogTitle() {
    if (this.dashboardChart && this.dashboardChart.id) {
      return 'Edit chart';
    } else {
      // this.dashboardChart.chartType.type = null;
      return 'Create chart';
    }
  }

  get spinnerDisabled() {
    return this.dashboardChart && this.dashboardChart.showCommon;
  }

  constructor(private fb: FormBuilder,
              private collectedDataService: CollectedDataService,
              private dataService: DataService,
              private chartService: ChartService,
              private toastrService: ToastrService) {
  }

  ngOnInit() {
    this.onDisplay.subscribe((isShow: boolean) => this.visible = isShow);
    this.createSourceItems();
    this.collectedDataService.getBuilderData()
      .subscribe(value => {
        this.collectedDataForChart = value;
      });

    this.dashboardChart.showCommon = false;
    this.dropdownTypes = [
      {label: dashboardChartTypes[0].title, value: dashboardChartTypes[0]},
      {label: dashboardChartTypes[1].title, value: dashboardChartTypes[1]},
      {label: dashboardChartTypes[2].title, value: dashboardChartTypes[2]},
      {label: dashboardChartTypes[3].title, value: dashboardChartTypes[3]},
    ];

    this.dropdownSources = [
      {label: dataPropertyLables[DataProperty.cpuUsagePercentage], value: DataProperty.cpuUsagePercentage},
      {label: dataPropertyLables[DataProperty.ramUsagePercentage], value: DataProperty.ramUsagePercentage},
      {label: dataPropertyLables[DataProperty.localDiskUsagePercentage], value: DataProperty.localDiskUsagePercentage},
      {label: dataPropertyLables[DataProperty.processesCount], value: DataProperty.processesCount},
      {label: dataPropertyLables[DataProperty.usageRamMBytes], value: DataProperty.usageRamMBytes},
      {label: dataPropertyLables[DataProperty.interruptsPerSeconds], value: DataProperty.interruptsPerSeconds},
      {label: dataPropertyLables[DataProperty.localDiskUsageMBytes], value: DataProperty.localDiskUsageMBytes}
    ];
  }

  getMultiSelectNumber() {
    return this.dashboardChart.chartType.type === ChartType.Pie ? 1 : null;
  }

  multiSelect(event) {
    if (event.value.length === 0) {
      this.dropdownSources.forEach(item => item.disabled = false);
      return;
    }

    if (dataPropertyLables[event.itemValue].includes('%')) {
      this.dashboardChart.dataSources = this.dashboardChart.dataSources.filter(s => dataPropertyLables[s].includes('%'));
      this.dropdownSources.forEach(item => !item.label.includes('%') ? item.disabled = true : item.disabled = false);
    } else {
      this.dashboardChart.dataSources = this.dashboardChart.dataSources.filter(s => !dataPropertyLables[s].includes('%'));
      this.dropdownSources.forEach(item => item.label.includes('%') ? item.disabled = true : item.disabled = false);
    }

    this.processData();
  }

  dropDownSelect(event) {
    this.dashboardChart.dataSources = [event.value];
    this.processData();
  }

  createSourceItems() {
    switch (this.dashboardChart.chartType.type) {
      case ChartType.Pie:
        if (this.dashboardChart.showCommon) {
          this.dropdownGroupSources = [{
            label: 'Percentage',
            items: [
              {label: dataPropertyLables[DataProperty.cpuUsagePercentage], value: DataProperty.cpuUsagePercentage},
              {label: dataPropertyLables[DataProperty.ramUsagePercentage], value: DataProperty.ramUsagePercentage},
            ]
          }, {
            label: 'Memory',
            items: [
              {label: dataPropertyLables[DataProperty.localDiskFreeMBytes], value: DataProperty.localDiskFreeMBytes},
              {label: dataPropertyLables[DataProperty.ramMBytes], value: DataProperty.ramMBytes}
            ]
          }];
        } else {
          this.dropdownGroupSources = [{
            label: 'Percentage',
            items: [
              {label: dataPropertyLables[DataProperty.pCpu], value: DataProperty.pCpu},
              {label: dataPropertyLables[DataProperty.pRam], value: DataProperty.pRam},
            ]
          }, {
            label: 'Memory',
            items: [
              {label: dataPropertyLables[DataProperty.ramMBytes], value: DataProperty.ramMBytes}
            ]
          }];
        }
        break;
      default:
        this.dropdownGroupSources = [{
          label: 'Sources', // TODO: change
          items: [
            {label: dataPropertyLables[DataProperty.pCpu], value: DataProperty.pCpu},
            {label: dataPropertyLables[DataProperty.pRam], value: DataProperty.pRam},
            {label: dataPropertyLables[DataProperty.ramMBytes], value: DataProperty.ramMBytes}
          ]
        }];
        break;
    }
  }

  processChartType() {
    this.showPreview = false;
    this.dashboardChart.chartType.name = chartTypes[this.dashboardChart.chartType.type];
    this.createSourceItems();
    this.processData();
  }

  resetDataSources() {
    this.dashboardChart.dataSources = [];
  }

  ngOnChanges(changes) {
    // this.title = changes.dashboardTitle && changes.dashboardTitle.currentValue;
  }

  isGuage() {
    return this.dashboardChart.chartType.type === ChartType.Guage;
  }

  processData(): void {
    this.showPreview = false;
    if (this.dashboardChart.showCommon) {
      this.dashboardChart.data = this.dataService.prepareData(this.dashboardChart.chartType.type,
        this.dashboardChart.dataSources, this.collectedDataForChart);
    } else {
      this.dashboardChart.data = this.dataService.prepareProcessData(this.dashboardChart.chartType.type,
        this.processDataSource, this.collectedDataForChart, this.dashboardChart.mostLoaded);
    }

    switch (this.dashboardChart.chartType.type) {
      case ChartType.BarVertical:
        this.dashboardChart.xAxisLabel = 'Parameters';
        this.dashboardChart.yAxisLabel = 'Percentage %';
        break;
      case ChartType.LineChart:
        this.dashboardChart.xAxisLabel = 'Time';
        this.dashboardChart.yAxisLabel = 'Percentage %';
        break;
      case ChartType.Guage:
        this.dashboardChart.yAxisLabel = 'Process';
        this.dashboardChart.xAxisLabel = '';
        break;
    }

    if (this.dashboardChart.data && this.dashboardChart.data.length > 0) {
      this.showPreview = true;
    }
  }

  closeDialog() {
    this.visible = false;
    this.closed.emit();
  }

  onEditChart() {
    const chartRequest = this.createChartRequest();
    if (!this.dashboardChart.id) {
      this.chartService.create(chartRequest).subscribe((val) => {
        this.handleSuccessfulCreate(val);
      }, (err) => {
        this.handleFailedEdit(err);
      });
    } else {
      this.chartService.update(chartRequest, this.dashboardChart.id).subscribe(() => {
        this.handleSuccessfulEdit(chartRequest, this.dashboardChart.id);
      }, (err) => {
        this.handleFailedEdit(err);
      });
    }
  }

  handleSuccessfulCreate(chart: Chart): void {
    const dashboardChart: DashboardChart = this.dataService.instantiateDashboardChart(chart, this.collectedDataForChart);
    this.editChart.emit(dashboardChart);
    this.closeDialog();
  }

  handleSuccessfulEdit(request: ChartRequest, id: number): void {
    const dashboardChart: DashboardChart = this.dataService.instantiateDashboardChartFromRequest(request, id, this.collectedDataForChart);
    this.editChart.emit(dashboardChart);
    this.closeDialog();
  }


  handleFailedEdit(error) {
    this.toastrService.error(`Error occurred status: ${error.message}`);
  }

  createChartRequest(): ChartRequest {
    let src: string;
    if (!this.dashboardChart.showCommon) { // TODO: add conditions
      src = this.processDataSource.toString();
    } else {
      src = this.dashboardChart.dataSources.join();
    }
    const chart: ChartRequest = {
      showCommon: this.dashboardChart.showCommon,
      threshold: this.dashboardChart.threshold,
      mostLoaded: this.dashboardChart.mostLoaded,
      schemeType: this.dashboardChart.colorScheme.name, // this.dashboardChart.schemeType,
      dashboardId: this.dashboardId,
      showLegend: this.dashboardChart.showLegend,
      legendTitle: this.dashboardChart.legendTitle,
      gradient: this.dashboardChart.gradient,
      showXAxis: this.dashboardChart.showXAxis,
      showYAxis: this.dashboardChart.showYAxis,
      showXAxisLabel: this.dashboardChart.showXAxisLabel,
      showYAxisLabel: this.dashboardChart.showYAxisLabel,
      yAxisLabel: this.dashboardChart.yAxisLabel,
      xAxisLabel: this.dashboardChart.xAxisLabel,
      autoScale: this.dashboardChart.autoScale,
      showGridLines: this.dashboardChart.showGridLines,
      rangeFillOpacity: this.dashboardChart.rangeFillOpacity,
      roundDomains: this.dashboardChart.roundDomains,
      isTooltipDisabled: this.dashboardChart.tooltipDisabled,
      isShowSeriesOnHover: this.dashboardChart.showSeriesOnHover,
      title: this.dashboardChart.title,
      type: this.dashboardChart.chartType.type,
      sources: src,
      isLightTheme: this.dashboardChart.theme === 'light',
    };
    return chart;
  }
}
