import {Component, EventEmitter, Input, OnChanges, OnInit, Output} from '@angular/core';
import {ChartType, chartTypes} from '../../../shared/models/chart-type.enum';
import {DataProperty} from '../../../shared/models/data-property.enum';
import {SelectItem} from 'primeng/api';
import {DashboardChart} from '../../models/dashboard-chart';
import {FormBuilder, FormControl, FormGroup} from '@angular/forms';
import {ChartRequest} from '../../../shared/requests/chart-request.model';
import {CollectedDataService} from '../../../core/services/collected-data.service';
import {CollectedData} from '../../../shared/models/collected-data.model';
import {DataService} from '../../../core/services/data.service';
import {ChartService} from '../../../core/services/chart.service';
import {ToastrService} from '../../../core/services/toastr.service';
import {Chart} from '../../../shared/models/chart.model';

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
  dropdownSourcesProcesses: SelectItem[];
  collectedDataForChart: CollectedData[] = [];
  showPreview = false;
  chartForm: FormGroup;

  get dialogTitle() {
    if (this.dashboardChart && this.dashboardChart.id) {
      return 'Edit chart';
    } else {
      this.dashboardChart.chartType.type = null;
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

    this.collectedDataService.getBuilderData()
      .subscribe(value => {
        this.collectedDataForChart = value;
      });

    this.dashboardChart.showCommon = false;

    this.dropdownTypes = [
      {label: 'Bar vertical', value: ChartType.BarVertical},
      {label: 'Line chart', value: ChartType.LineChart},
      {label: 'Pie', value: ChartType.Pie},
      {label: 'Guage', value: ChartType.Guage}
    ];

    this.dropdownSources = [
      {label: 'CPU', value: DataProperty.cpuUsagePercent},
      {label: 'RAM', value: DataProperty.ramUsagePercent},
      {label: 'DISC', value: DataProperty.localDiskFreeSpacePercent}
    ];

    this.dropdownSourcesProcesses = [
      {label: 'CPU p', value: DataProperty.processesCPU},
      {label: 'RAM p', value: DataProperty.processesRAM},
      {label: 'DISC p', value: DataProperty.localDiskFreeMBytes}
    ];

    this.chartForm = this.fb.group({
      isMultiple: new FormControl({value: false, disabled: false}),
      mostLoaded: new FormControl({value: 1, disabled: false}),
      xAxisLabel: new FormControl({value: '', disabled: false}),
      yAxisLabel: new FormControl({value: '', disabled: false})
    });
  }

  processChartType() {
    this.showPreview = false;
    this.dashboardChart.chartType.name = chartTypes[this.dashboardChart.chartType.type];
    this.processData();
  }

  resetDataSources() {
    this.dashboardChart.dataSources = [];
  }

  ngOnChanges(changes) {
    // this.title = changes.dashboardTitle && changes.dashboardTitle.currentValue;
  }

  isGuage() {
    return this.dashboardChart.chartType.type === 3;
  }

  processData(): void {
    // debugger;
    console.log(this.dashboardChart.dataSources);
    this.showPreview = false;
    if (!this.dashboardChart.showCommon) {
      this.dashboardChart.data = this.dataService.prepareData(this.dashboardChart.chartType.type,
        this.dashboardChart.dataSources, this.collectedDataForChart);
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
    this.chartForm.reset();
    this.closed.emit();
  }

  onEditChart() {
    if (!this.dashboardChart.id) {
      this.chartService.create(this.createChartRequest()).subscribe(this.handleSuccessfulEdit, this.handleFailedEdit);
    } else {
      this.chartService.update(this.dashboardChart.id,
        this.createChartRequest()).subscribe(this.handleSuccessfulEdit, this.handleFailedEdit);
    }
  }

  handleSuccessfulEdit(chart: Chart): void {
    const dashboardChart: DashboardChart = this.dataService.instantiateDashboardChart(chart, this.collectedDataForChart);
    this.editChart.emit(dashboardChart);
    this.closeDialog();
  }

  handleFailedEdit(error) {
    this.toastrService.error(`Error occurred status: ${error.message}`);
  }

  createChartRequest(): ChartRequest {
    const chart: ChartRequest = {
      showCommon: this.dashboardChart.showCommon,
      threshold: this.dashboardChart.threshold,
      mostLoaded: '' + this.chartForm.get('mostLoaded').value,
      schemeType: this.dashboardChart.schemeType,
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
      sources: this.dashboardChart.dataSources.join(),
      isLightTheme: this.dashboardChart.theme === 'light',
    };
    return chart;
  }
}
