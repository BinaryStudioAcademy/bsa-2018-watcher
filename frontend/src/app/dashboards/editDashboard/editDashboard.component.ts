import { Component, OnInit, OnChanges, Output, Input } from '@angular/core';
import { EventEmitter } from '@angular/core';
import {NgModel} from '@angular/forms';
import { SelectItem } from 'primeng/api';
import { DashboardChart } from '../models/dashboard-chart';
import { ChartType } from '../../shared/models/chart-type.enum';
import { DataProperty } from '../../shared/models/data-property.enum';
import { CollectedDataService } from '../../core/services/collected-data.service';
import { DataService } from '../../core/services/data.service';
import { defaultOptions } from '../charts/models/chart-options';
import {dashboardChartTypes} from '../charts/models/dashboardChartTypes';

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

  showPreview = false;
  dropdownSources: SelectItem[];
  dashboardCharts: DashboardChart[] = [];

  isSource: Boolean = false;
  isCustomize: Boolean = false;
  sources: DataProperty[];
  isIncluded: Boolean[] = [];

  constructor(private collectedDataService: CollectedDataService,
              private dataService: DataService) { }

  closeDialog(): void {
    this.closed.emit();
    this.title = '';
    this.reset();
  }

  generateAll() {
    this.isSource = true;
    this.isCustomize = false;
  }

  customize() {
    this.isSource = true;
    this.isCustomize = true;
  }

  edit(model: NgModel): void {
    let correction = 0;
    for (let i = 0; i < 4; i++) {
      if (!this.isIncluded[i] && this.isCustomize) {
         this.dashboardCharts.splice(i - correction, 1);
         correction++;
      }
    }
    this.edited.emit({title: this.title, charts: this.isSource ? this.dashboardCharts : null});
    this.title = '';
    model.reset();
    this.reset();
  }

  reset() {
    this.sources = [];
    this.isSource = false;
    this.isCustomize = false;
    this.showPreview = false;
    this.dashboardCharts = [];
    this.isIncluded = [];
    this.fillCharts();
  }

  ngOnChanges(changes) {
    this.title = changes.dashboardTitle && changes.dashboardTitle.currentValue;
  }

  ngOnInit() {
    this.dropdownSources = [
        { label: 'CPU %', value: DataProperty.cpuUsagePercentage},
        { label: 'RAM %', value: DataProperty.ramUsagePercentage },
        { label: 'DISC %', value: DataProperty.localDiskUsagePercentage }
    ];

    this.fillCharts();
  }

  fillCharts() {
    for (let i = 0; i < 4; i++) {
        this.isIncluded.push(true);
        const dashboardChart = { ...defaultOptions };
        this.dashboardCharts.push(dashboardChart);
        this.dashboardCharts[i].chartType = dashboardChartTypes[i];
        this.dashboardCharts[i].chartType.name = dashboardChartTypes[i].name;
        this.dashboardCharts[i].chartType.type = dashboardChartTypes[i].type;
        this.dashboardCharts[i].chartType.title = dashboardChartTypes[i].title;
        this.dashboardCharts[i].title = dashboardChartTypes[i].title;
        this.dashboardCharts[i].showXAxis = false;
        this.dashboardCharts[i].showYAxis = false;
        this.dashboardCharts[i].showLegend = false;
    }
  }

  processDataForAll() {
    this.dashboardCharts.forEach( dash => dash = this.processData(dash));
  }

  processData(dashboardChart: DashboardChart) {
    dashboardChart.dataSources = this.sources;
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
    this.showPreview = this.dataService.fulfillChart(this.dataService.fakeCollectedData, dashboardChart);

    return dashboardChart;
  }
}
