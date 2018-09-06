import { Component, OnInit, OnChanges, Output, Input } from '@angular/core';
import { EventEmitter } from '@angular/core';
import {NgModel} from '@angular/forms';
import { SelectItem } from 'primeng/api';
import { DashboardChart } from './../models/dashboard-chart';
import { ChartType, chartTypes } from './../../shared/models/chart-type.enum';
import { DataProperty } from './../../shared/models/data-property.enum';
import { CollectedDataService } from './../../core/services/collected-data.service';
import { CollectedData } from './../../shared/models/collected-data.model';
import { DataService } from './../../core/services/data.service';
import { ChartService } from './../../core/services/chart.service';
import { defaultOptions } from '../charts/models/chart-options';
import {dashboardChartTypes} from './../charts/models/dashboardChartTypes';
import { ChartRequest } from './../../shared/requests/chart-request.model';

@Component({
  selector: 'app-edit-dashboard',
  templateUrl: './editDashboard.component.html',
  styleUrls: ['./editDashboard.component.sass']
})
export class EditDashboardComponent implements OnInit, OnChanges {
  title = '';

  @Output() edited = new EventEmitter<any>(); // string
  @Output() closed = new EventEmitter();
  @Input() display: boolean;
  @Input() dashboardTitle: string;

  // @Output() added = new EventEmitter<Array<ChartRequest>>();

  showPreview = false;
  dropdownSources: SelectItem[];
  collectedDataForChart: CollectedData[] = [];
  dashboardCharts: DashboardChart[] = [];
  newCharts: ChartRequest[] = [];
  dashboardChart1 = { ...defaultOptions };
  dashboardChart2 = { ...defaultOptions };
  dashboardChart3 = { ...defaultOptions };
  dashboardChart = { ...defaultOptions };
  isSource: Boolean = false;
  isCustomize: Boolean = false;
  sources: DataProperty[];
  isIncluded: Boolean[] = [];

  constructor(private collectedDataService: CollectedDataService,
              private dataService: DataService,
              private chartService: ChartService) { }

  closeDialog(): void {
    this.closed.emit();
    this.title = '';
    // this.dashboardTitle = '';
    this.sources = [];
    this.isSource = false;
    this.isCustomize = false;
    this.showPreview = false;
  }

  generateAll() {
    this.isSource = true;
  }

  customize() {
    this.isSource = true;
    this.isCustomize = true;
  }

  edit(model: NgModel): void {
    for (let i = 0; i < 4; i++) {
      this.newCharts.push(this.createChartRequest(this.dashboardCharts[i]));
      if (!this.isIncluded[i] && this.isCustomize) {
         this.newCharts.splice(i, 1);
      }
    }
    this.edited.emit({title: this.title, charts: this.newCharts});
    // this.edited.emit(this.title);
    this.title = '';
    model.reset();
    /*this.added.emit(this.newCharts);*/
  }

  ngOnChanges(changes) {
    this.title = changes.dashboardTitle && changes.dashboardTitle.currentValue;
  }

  ngOnInit() {
    this.collectedDataService.getBuilderData()
    .subscribe(value => {
      this.collectedDataForChart = value;
    });

    this.dropdownSources = [
      { label: 'CPU', value: DataProperty.cpuUsagePercent },
      { label: 'RAM', value: DataProperty.ramUsagePercent },
      { label: 'DISC', value: DataProperty.localDiskFreeSpacePercent }
    ];

    this.fillCharts();
  }

  fillCharts() {
    this.dashboardCharts.push(this.dashboardChart);
    this.dashboardCharts.push(this.dashboardChart1);
    this.dashboardCharts.push(this.dashboardChart2);
    this.dashboardCharts.push(this.dashboardChart3);
    for (let i = 0; i < 4; i++) {
        this.isIncluded.push(true);
        this.dashboardCharts[i].view = [476, 247];
        this.dashboardCharts[i].chartType = dashboardChartTypes[i];
        this.dashboardCharts[i].chartType.name = dashboardChartTypes[i].name;
        this.dashboardCharts[i].chartType.type = dashboardChartTypes[i].type;
        this.dashboardCharts[i].chartType.title = dashboardChartTypes[i].title;
    }
  }

  processDataForAll() {
    this.dashboardCharts.forEach( dash => dash = this.processData(dash));
  }

  processData(dashboardChart: DashboardChart) {
    this.showPreview = false;
    dashboardChart.data = this.dataService.prepareData(dashboardChart.chartType.type,
      this.sources, this.collectedDataForChart);

    switch (dashboardChart.chartType.type) {
      case ChartType.BarVertical:
        dashboardChart.xAxisLabel = 'Parameters';
        dashboardChart.yAxisLabel = 'Percentage %';
        break;
      case ChartType.LineChart:
        dashboardChart.xAxisLabel = 'Time';
        dashboardChart.yAxisLabel = 'Percentage %';
        break;
      case ChartType.Guage:
        dashboardChart.yAxisLabel = 'Process';
        dashboardChart.xAxisLabel = '';
        break;
    }

    if (dashboardChart.data && dashboardChart.data.length > 0) {
      this.showPreview = true;
    }
    return dashboardChart;
  }

  createChartRequest(dashboardChart: DashboardChart): ChartRequest {
    const chart: ChartRequest = {
      showCommon: dashboardChart.showCommon,
      threshold: dashboardChart.threshold,
      mostLoaded: '',
      schemeType: dashboardChart.schemeType,
      dashboardId: 0,
      showLegend: dashboardChart.showLegend,
      legendTitle: dashboardChart.legendTitle,
      gradient: dashboardChart.gradient,
      showXAxis: dashboardChart.showXAxis,
      showYAxis: dashboardChart.showYAxis,
      showXAxisLabel: dashboardChart.showXAxisLabel,
      showYAxisLabel: dashboardChart.showYAxisLabel,
      yAxisLabel: dashboardChart.yAxisLabel,
      xAxisLabel: dashboardChart.xAxisLabel,
      autoScale: dashboardChart.autoScale,
      showGridLines: dashboardChart.showGridLines,
      rangeFillOpacity: dashboardChart.rangeFillOpacity,
      roundDomains: dashboardChart.roundDomains,
      isTooltipDisabled: dashboardChart.tooltipDisabled,
      isShowSeriesOnHover: dashboardChart.showSeriesOnHover,
      title: dashboardChart.title,
      type: dashboardChart.chartType.type,
      sources: this.sources.join(),
      isLightTheme: dashboardChart.theme === 'light',
      scheme: dashboardChart.colorScheme
    };
    return chart;
  }

}
