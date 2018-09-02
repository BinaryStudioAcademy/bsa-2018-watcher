import { Component, EventEmitter, Input, OnChanges, OnInit, Output } from '@angular/core';
import {ChartType, chartTypes} from '../../../shared/models/chart-type.enum';
import { DataProperty } from '../../../shared/models/data-property.enum';
import { SelectItem } from 'primeng/api';
import { DashboardChart } from '../../models/dashboard-chart';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { ChartRequest } from '../../../shared/requests/chart-request.model';
import { CollectedDataService } from '../../../core/services/collected-data.service';
import { CollectedData } from '../../../shared/models/collected-data.model';
import { DataService } from '../../services/data.service';
import { ChartService } from '../../../core/services/chart.service';
import { ToastrService } from '../../../core/services/toastr.service';
import { CustomData, DashboardChartType } from '../models';

@Component({
  selector: 'app-edit-chart',
  templateUrl: './edit-chart.component.html',
  styleUrls: ['./edit-chart.component.sass']
})
export class EditChartComponent implements OnInit, OnChanges {
  @Output() editChart = new EventEmitter<DashboardChart>();
  @Output() closed = new EventEmitter();
  @Input() display: boolean;
  @Input() dashboardId: number;
  @Input() dashboardChart: DashboardChart;
  type: ChartType;
  // data: CustomData[] = [];
  // object to send to backend to add or edit dashboardChart
  // in dashboard component fill this object with real data if it is edit mode, or fill it with default data from defaultOptions and set
  // current dashboard id if it is create mode

  dropdownTypes: SelectItem[];
  dropdownSources: SelectItem[];
  dropdownSourcesProcesses: SelectItem[];
  collectedDataForChart: CollectedData[] = [];
  // chartType: DashboardChartType = {...customChartTypes[0]};
  showPreview = false;
  chartForm: FormGroup;

  constructor(private fb: FormBuilder,
    private collectedDataService: CollectedDataService,
    private dataService: DataService,
    private chartService: ChartService,
    private toastrService: ToastrService) {
  }

  ngOnInit() {
    this.collectedDataService.getBuilderData()
      .subscribe(value => {
        this.collectedDataForChart = value;
      });

    this.dashboardChart.showCommon = false;

    this.dropdownTypes = [
      { label: 'Bar vertical', value: ChartType.BarVertical },
      { label: 'Line chart', value: ChartType.LineChart },
      { label: 'Pie', value: ChartType.Pie },
      { label: 'Guage', value: ChartType.Guage }
    ];

    this.dropdownSources = [
      { label: 'CPU', value: DataProperty.cpuUsagePercent },
      { label: 'RAM', value: DataProperty.ramUsagePercent },
      { label: 'DISC', value: DataProperty.localDiskFreeSpacePercent }
    ];

    this.dropdownSourcesProcesses = [
      { label: 'CPU n', value: DataProperty.processesCPU },
      { label: 'RAM', value: DataProperty.processesRAM },
      { label: 'DISC', value: DataProperty.localDiskFreeMBytes }
    ];

    this.chartForm = this.fb.group({
      isMultiple: new FormControl({ value: false, disabled: false }),
      mostLoaded: new FormControl({ value: 1, disabled: false }),
      xAxisLabel: new FormControl({ value: '', disabled: false }),
      yAxisLabel: new FormControl({ value: '', disabled: false })
    });

    // this.type = this.dashboardChart.chartType;
  }

  processChartType() {
    this.dashboardChart.chartType.type = this.type;
    this.dashboardChart.chartType.name = chartTypes[this.type];
  }

  ngOnChanges(changes) {

    // this.title = changes.dashboardTitle && changes.dashboardTitle.currentValue;
  }

  sources() {
    if (this.dashboardChart.showCommon) {
     // this.dashboardChart.dataSources = null;
      return this.dropdownSourcesProcesses;
    } else {
      return this.dropdownSources;
    }
  }

  isGuage() {
    if (this.dashboardChart.chartType.type === 3) {
      return true;
    } else { return false; }
  }

  processData(): void {
    this.showPreview = false;
    // this.dashboardChart.chartType.name = chartTypes[this.selectedType];
    // this.dashboardChart.chartType.type = this.selectedType;
    if (!this.dashboardChart.showCommon) {
    this.dashboardChart.data = this.dataService.prepareData(this.dashboardChart.chartType.type,
      this.dashboardChart.dataSources, this.collectedDataForChart);
    }
    if (this.dashboardChart.chartType.type === ChartType.BarVertical) {
      this.dashboardChart.xAxisLabel = 'Parameters';
      this.dashboardChart.yAxisLabel = 'Percentage %';
    } else if (this.dashboardChart.chartType.type === ChartType.LineChart) {
      // this.dataForChart = single;
      this.dashboardChart.xAxisLabel = 'Time';
      this.dashboardChart.yAxisLabel = 'Percentage %';
    } else if (this.dashboardChart.chartType.type === ChartType.Guage) {
      this.dashboardChart.yAxisLabel = 'Process';
      this.dashboardChart.xAxisLabel = '';
    }

    if (this.dashboardChart.data  && this.dashboardChart.data .length > 0) {
      this.showPreview = true;
    }
  }

  closeDialog() {
    this.display = false;
    this.closed.emit();
    // this.selectedSource = null;
    // this.selectedType = null;
    this.chartForm.reset();
    // this.dataForChart = [];
  }

  // closeDialog(): void {
  //   this.closed.emit();
  //   this.title = '';
  //   // this.dashboardTitle = '';
  // }

  onEditChart() {
    this.chartService.create(this.createChartRequest()).subscribe(
      value => {
          debugger;
        const dashboardChart: DashboardChart = this.dataService.instantiateDashboardChart(value, this.collectedDataForChart);
        // this.activeDashboardItem.charts.push(dashboardChart); // TODO: use this in dash component
        this.editChart.emit(dashboardChart);
        this.toastrService.success('Chart was created');
        this.closeDialog();
      },
      error => {
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });
  }

  onEditChart1(chart: ChartRequest) {
    this.chartService.update(1, chart).subscribe(
      value => {
        this.toastrService.success('The chart was updated');
      },
      error => {
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });
  }

  // edit(model: NgModel): void {
  //   this.editChart.emit(this.title);
  //   this.title = '';
  //   model.reset();
  // }

  createChartRequest(): ChartRequest {
    const chart: ChartRequest = {
      showCommon: this.dashboardChart.showCommon,
      threshold: this.dashboardChart.threshold,
      mostLoaded: '' + this.chartForm.get('mostLoaded').value,
      dashboardId: this.dashboardId,
      schemeType: this.dashboardChart.schemeType,

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
