import { Component, OnInit, OnChanges, Output, Input } from '@angular/core';
import { EventEmitter } from '@angular/core';
import { NgModel} from '@angular/forms';
import { SelectItem } from 'primeng/api';
import { DashboardChart } from '../models/dashboard-chart';

import { ChartType } from '../../shared/models/chart-type.enum';
import { DataProperty } from '../../shared/models/data-property.enum';
import { DataService } from '../../core/services/data.service';
import { defaultOptions } from '../charts/models/chart-options';

@Component({
  selector: 'app-edit-dashboard',
  templateUrl: './editDashboard.component.html',
  styleUrls: ['./editDashboard.component.sass']
})
export class EditDashboardComponent implements OnInit, OnChanges {
  title = '';

  @Output() edited = new EventEmitter<any>();
  @Output() closed = new EventEmitter();
  @Input() display: boolean;
  @Input() dashboardTitle: string;

  showPreview = false;
  dropdownSources: SelectItem[];
  dashboardCharts: DashboardChart[] = [];

  isSource: Boolean = false;
  isCustomize: Boolean = false;
  sources: DataProperty[];
  countToGenerate = 4;

  constructor(private dataService: DataService) { }

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
    this.dashboardCharts = this.dashboardCharts.filter(chart => chart.isIncluded && chart.dataSources && chart.dataSources.length > 0);
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
    for (let i = 0; i < this.countToGenerate; i++) {
      const chart = Object.assign({
        ...defaultOptions,
      }, {
        type: i,
        title: ChartType[i],
        showXAxis: false,
        showYAxis: false,
        showLegend: false
      });

      this.dashboardCharts.push(chart);
    }
  }

  processDataForAll() {
    this.dashboardCharts.forEach( dash => dash = this.processData(dash));
  }

  processData(dashboardChart: DashboardChart) {
    dashboardChart.dataSources = this.sources;
    switch (dashboardChart.type) {
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
    this.showPreview = this.dataService.fulfillChart(this.dataService.fakeCollectedData, dashboardChart, true);

    return dashboardChart;
  }
}
