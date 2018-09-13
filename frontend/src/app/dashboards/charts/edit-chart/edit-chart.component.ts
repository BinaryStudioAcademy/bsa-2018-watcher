import {Component, EventEmitter, Input, OnInit, Output} from '@angular/core';
import {SelectItem, SelectItemGroup} from 'primeng/api';
import {colorSets} from '@swimlane/ngx-charts/release/utils';

import {DataService} from '../../../core/services/data.service';
import {ChartService} from '../../../core/services/chart.service';
import {ToastrService} from '../../../core/services/toastr.service';

import {Chart} from '../../../shared/models/chart.model';
import {ChartRequest} from '../../../shared/requests/chart-request.model';
import {ChartType, chartTypeLabels} from '../../../shared/models/chart-type.enum';
import {DataProperty, dataPropertyLables} from '../../../shared/models/data-property.enum';

import {DashboardChart} from '../../models/dashboard-chart';


@Component({
  selector: 'app-edit-chart',
  templateUrl: './edit-chart.component.html',
  styleUrls: ['./edit-chart.component.sass']
})
export class EditChartComponent implements OnInit {
  @Output() editChart = new EventEmitter<DashboardChart>();
  @Output() closed = new EventEmitter();
  @Output() dashboardChartChange = new EventEmitter();

  visible: boolean;

  @Input() onDisplay: EventEmitter<boolean>;
  @Input() dashboardId: number;
  @Input() dashboardChart: DashboardChart;

  dropdownTypes: SelectItemGroup[] = [];
  dropdownSources: SelectItem[] = [];
  dropdownGroupSources: SelectItemGroup[] = [];

  type = ChartType;
  colorSchemes = colorSets;

  isEditing: boolean;
  isPreviewAvailable: boolean;
  isTimeAvailable: boolean;

  get dialogTitle() {
    if (this.dashboardChart && this.dashboardChart.id) {
      this.isEditing = true;
      return 'Edit Chart';
    } else {
      this.isEditing = false;
      return 'CreateChart';
    }
  }

  get spinnerDisabled() {
    return this.dashboardChart && this.dashboardChart.showCommon;
  }

  get isValid(): boolean {
    return !!this.dashboardChart.dataSources.length;
  }

  constructor(private dataService: DataService,
              private chartService: ChartService,
              private toastrService: ToastrService) {
  }

  ngOnInit() {
    this.onDisplay.subscribe((isShow: boolean) => {
      this.visible = isShow;
      this.processData();
    });

    this.dashboardChart.showCommon = false;

    // Fill dropdown with grouped sources
    this.dropdownTypes = [{
      label: 'Bar Charts',
      items: [
        { label: chartTypeLabels[ChartType.BarVertical], value: ChartType.BarVertical },
        { label: chartTypeLabels[ChartType.BarHorizontal], value: ChartType.BarHorizontal },
        { label: chartTypeLabels[ChartType.BarVertical2D], value: ChartType.BarVertical2D },
        { label: chartTypeLabels[ChartType.BarHorizontal2D], value: ChartType.BarHorizontal2D },
        { label: chartTypeLabels[ChartType.BarVerticalStacked], value: ChartType.BarVerticalStacked },
        { label: chartTypeLabels[ChartType.BarHorizontalStacked], value: ChartType.BarHorizontalStacked },
        { label: chartTypeLabels[ChartType.BarVerticalNormalized], value: ChartType.BarVerticalNormalized },
        { label: chartTypeLabels[ChartType.BarHorizontalNormalized], value: ChartType.BarHorizontalNormalized },
      ]
    }, {
      label: 'Line/Area Charts',
      items: [
        { label: chartTypeLabels[ChartType.LineChart], value: ChartType.LineChart },
        { label: chartTypeLabels[ChartType.AreaChart], value: ChartType.AreaChart },
        { label: chartTypeLabels[ChartType.AreaChartNormalized], value: ChartType.AreaChartNormalized },
        { label: chartTypeLabels[ChartType.AreaChartStacked], value: ChartType.AreaChartStacked },
      ],
    }, {
      label: 'Pie Charts',
      items: [
        { label: chartTypeLabels[ChartType.Pie], value: ChartType.Pie },
        { label: chartTypeLabels[ChartType.PieGrid], value: ChartType.PieGrid },
        { label: chartTypeLabels[ChartType.AdvancedPie], value: ChartType.AdvancedPie },
      ]
    }, {
        label: 'Other Charts',
        items: [
          { label: chartTypeLabels[ChartType.ResourcesTable], value: ChartType.ResourcesTable },
          { label: chartTypeLabels[ChartType.NumberCards], value: ChartType.NumberCards },
          { label: chartTypeLabels[ChartType.Gauge], value: ChartType.Gauge },
          { label: chartTypeLabels[ChartType.PolarChart], value: ChartType.PolarChart },
          { label: chartTypeLabels[ChartType.HeatMap], value: ChartType.HeatMap },
          { label: chartTypeLabels[ChartType.TreeMap], value: ChartType.TreeMap },
        ]}
    ];

    // Object.keys(ChartType).forEach(type => {
    //   const number = Number(type);
    //   if (!isNaN(number)) {
    //     this.dropdownTypes.push({label: chartTypeLabels[number], value: number });
    //   }
    // });

    this.resetBuilderForm();
  }

  dropDownSelect(event) {
    this.dashboardChart.dataSources = [event.value];
    this.processData();
  }

  multiSelect(event) {
    if (event.value.length === 0) {
      this.dropdownSources.forEach(item => item.disabled = false);
      return;
    }

    switch (this.dashboardChart.type) {
      case ChartType.ResourcesTable:
      case ChartType.NumberCards:
        break;
      default:
        // Disabling another groups
        if (dataPropertyLables[event.itemValue].includes('%')) {
          this.dashboardChart.dataSources = this.dashboardChart.dataSources.filter(s => dataPropertyLables[s].includes('%'));
          this.dropdownSources.forEach(item => !item.label.includes('%') ? item.disabled = true : item.disabled = false);
        } else {
          this.dashboardChart.dataSources = this.dashboardChart.dataSources.filter(s => !dataPropertyLables[s].includes('%'));
          this.dropdownSources.forEach(item => item.label.includes('%') ? item.disabled = true : item.disabled = false);
        }
        break;
    }
    this.processData();
  }

  resetBuilderForm() {
    this.dashboardChart.dataSources = [];
    this.createSourceItems();
    this.dropdownSources.forEach(item => item.disabled = false);

    if (!this.isEditing) {
      this.dashboardChart.title = chartTypeLabels[this.dashboardChart.type];
      this.dashboardChart.xAxisLabel = '';
      this.dashboardChart.yAxisLabel = '';
      this.dashboardChart.legendTitle = 'Legend';
    } else {
      this.dashboardChart.title = this.dashboardChart.title || chartTypeLabels[this.dashboardChart.type];
      this.dashboardChart.legendTitle = this.dashboardChart.legendTitle || 'Legend';
    }

    this.isPreviewAvailable = this.dashboardChart.showCommon;
    this.dashboardChart.showXAxis = true;
    this.dashboardChart.showYAxis = true;
    this.isTimeAvailable = false;


    switch (this.dashboardChart.type) {
      case ChartType.ResourcesTable:
        this.dashboardChart.showCommon = true;
        this.dashboardChart.showXAxis = false;
        this.dashboardChart.showYAxis = false;
        this.dashboardChart.showLegend = false;
        this.dashboardChart.dataSources = [
          DataProperty.name,
          DataProperty.pCpu,
          DataProperty.ramMBytes,
          DataProperty.pRam
        ];
        break;
      case ChartType.LineChart:
      case ChartType.AreaChart:
      case ChartType.AreaChartStacked:
      case ChartType.AreaChartNormalized:
      case ChartType.PolarChart:
        this.isTimeAvailable = true;
        this.dashboardChart.xAxisLabel = 'Time';
        this.dashboardChart.yAxisLabel = 'Value';
        break;
      case ChartType.BarVertical:
        this.dashboardChart.xAxisLabel = 'Parameters';
        this.dashboardChart.yAxisLabel = 'Value';
        break;
      case ChartType.BarVertical2D:
      case ChartType.BarVerticalStacked:
      case ChartType.BarVerticalNormalized:
        this.isPreviewAvailable = true;
        this.dashboardChart.xAxisLabel = 'Parameters';
        this.dashboardChart.yAxisLabel = 'Value';
        break;
      case ChartType.BarHorizontal:
        this.dashboardChart.xAxisLabel = 'Value';
        this.dashboardChart.yAxisLabel = 'Parameters';
        break;
      case ChartType.BarHorizontal2D:
      case ChartType.BarHorizontalStacked:
      case ChartType.BarHorizontalNormalized:
        this.isTimeAvailable = true;
        this.dashboardChart.xAxisLabel = 'Value';
        this.dashboardChart.yAxisLabel = 'Parameters';
        break;
      case ChartType.Gauge:
        this.dashboardChart.showXAxis = false;
        this.dashboardChart.showLegend = false;
        this.dashboardChart.yAxisLabel = 'Process';
      break;
      case ChartType.HeatMap:
        this.dashboardChart.showLegend = false;
        this.dashboardChart.yAxisLabel = 'Intensivity';
        this.dashboardChart.xAxisLabel = 'Parameters';
        break;
      case ChartType.Pie:
      case ChartType.AdvancedPie:
      case ChartType.PieGrid:
      case ChartType.TreeMap:
      case ChartType.NumberCards:
        this.dashboardChart.showLegend = false;
        this.dashboardChart.showXAxis = false;
        this.dashboardChart.showYAxis = false;
        break;
    }
  }

  createSourceItems() {
    switch (this.dashboardChart.type) {
      case ChartType.ResourcesTable: {
        this.dropdownSources = [
          {label: dataPropertyLables[DataProperty.name], value: DataProperty.name},
          {label: dataPropertyLables[DataProperty.pCpu], value: DataProperty.pCpu},
          {label: dataPropertyLables[DataProperty.pRam], value: DataProperty.pRam},
          {label: dataPropertyLables[DataProperty.ramMBytes], value: DataProperty.ramMBytes}
        ];
        return;
      }
      case ChartType.Pie:
      case ChartType.AdvancedPie:
      case ChartType.PieGrid:
      case ChartType.TreeMap:
        if (this.dashboardChart.showCommon) {
          this.dropdownGroupSources = [{
            label: 'Percentage',
            items: [
              { label: dataPropertyLables[DataProperty.cpuUsagePercentage], value: DataProperty.cpuUsagePercentage },
              { label: dataPropertyLables[DataProperty.ramUsagePercentage], value: DataProperty.ramUsagePercentage },
              { label: dataPropertyLables[DataProperty.localDiskUsagePercentage], value: DataProperty.localDiskUsagePercentage },
            ]
          }, {
            label: 'Memory',
            items: [
              { label: dataPropertyLables[DataProperty.usageRamMBytes], value: DataProperty.usageRamMBytes },
              { label: dataPropertyLables[DataProperty.localDiskUsageMBytes], value: DataProperty.localDiskUsageMBytes }
            ]
          }];
          return;
        }
    }

    // Default for all another types
    this.dropdownGroupSources = [{
      label: 'Percentage',
      items: [
        { label: dataPropertyLables[DataProperty.pCpu], value: DataProperty.pCpu },
        { label: dataPropertyLables[DataProperty.pRam], value: DataProperty.pRam },
      ]
    }, {
      label: 'Memory',
      items: [
        { label: dataPropertyLables[DataProperty.ramMBytes], value: DataProperty.ramMBytes }
      ]
    }];

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

  selectChartType() {
    this.resetBuilderForm();
    this.processData();
  }

  showPreview() {
    this.isPreviewAvailable = true;
    this.processData();
  }

  processData(): void {
    if (this.dashboardChart.type === ChartType.ResourcesTable) {
      this.dashboardChart.colectedData = this.dataService.fakeCollectedData[0];
      this.dashboardChart.data = [ {} ]; // If data undefine than it not appeared
      this.isPreviewAvailable = true;
      return;
    }

    this.isPreviewAvailable = this.dataService.fulfillChart(this.dataService.fakeCollectedData, this.dashboardChart, true);
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
    const dashboardChart: DashboardChart = this.dataService.instantiateDashboardChart(chart);
    this.editChart.emit(dashboardChart);
    this.closeDialog();
  }

  handleSuccessfulEdit(request: ChartRequest, id: number): void {
    const dashboardChart: DashboardChart = this.dataService.instantiateDashboardChartFromRequest(request, id);
    this.editChart.emit(dashboardChart);
    this.closeDialog();
  }

  handleFailedEdit(error) {
    this.toastrService.error(`Error occurred status: ${error.message}`);
  }

  createChartRequest(): ChartRequest {
    return {
      showCommon: this.dashboardChart.showCommon,
      threshold: this.dashboardChart.threshold,
      mostLoaded: this.dashboardChart.mostLoaded,
      historyTime: this.dashboardChart.historyTime,
      schemeType: this.dashboardChart.colorScheme.name,
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
      type: this.dashboardChart.type,
      sources: this.dashboardChart.dataSources.join(),
      isLightTheme: this.dashboardChart.theme === 'light',
    };
  }
}
