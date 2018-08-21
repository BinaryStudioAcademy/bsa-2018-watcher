import {ChangeDetectionStrategy, Component, Input, OnChanges, OnInit} from '@angular/core';
import {DashboardService} from '../../core/services/dashboard.service';
import {SeriesItem} from '../models/series-item';
import {PercentageInfo} from '../models/percentage-info';
import * as shape from 'd3-shape';
import {DashboardsHub} from '../../core/hubs/dashboards.hub';

@Component({
  selector: 'app-percentage-line-chart',
  templateUrl: './percentage-line-chart.component.html',
  styleUrls: ['./percentage-line-chart.component.sass'],
  changeDetection: ChangeDetectionStrategy.Default
})
export class PercentageLineChartComponent implements OnInit, OnChanges {
  view: any[] = [700, 300];

  // options
  animations = false;
  showXAxis = true;
  showYAxis = true;
  gradient = false;
  showLegend = true;
  showGridLines = true;
  showRefLabels = true;
  showRefLines = true;
  roundDomains = false;
  showXAxisLabel = true;
  showYAxisLabel = true;
  autoScale = true;
  curve = shape.curveBasis;
  yScaleMin = 0;
  yScaleMax = 100;
  xAxisLabel = 'Time';
  yAxisLabel = 'Percentage %';

  @Input() percentageInfo: PercentageInfo[];

  colorScheme = {
    domain: ['#5AA454', '#A10A28', '#C7B42C', '#AAAAAA']
  };

  data: any[] = [
    {
      name: 'CPU',
      series: []
    },
    {
      name: 'RAM',
      series: []
    },
    {
      name: 'Disk Free Space',
      series: []
    },
    {
      name: 'Interrupts',
      series: []
    },
  ];

  constructor(private dashboardsService: DashboardService,
              private dashboardsHub: DashboardsHub) {
  }

  ngOnInit(): void {
    this.buildChart(this.percentageInfo);
    this.subscribeToCollectedData();
  }

  ngOnChanges(): void {
    this.buildChart(this.percentageInfo);
  }


  buildChart(info: PercentageInfo[]) {
    if (info && info.length > 0) {
      const infoToInsert = info.map(p => this.toSeriesData(p));

      for (const inf of infoToInsert) {
        for (let i = 0; i < 4; i++) {
          this.data[i].series.push(inf[i]);
        }
      }

      this.data = [...this.data];
    }
  }

  toSeriesData(info: PercentageInfo): SeriesItem[] {
    const items: SeriesItem[] = [];
    for (let i = 0; i < 4; i++) {
      items.push({name: new Date(info.time), value: 0});
    }

    items[0].value = Math.floor(info.cpuUsagePercent);
    items[1].value = Math.floor(info.ramUsagePercent);
    items[2].value = Math.floor(info.localDiskFreeSpacePercent);
    items[3].value = Math.floor(info.interruptsTimePercent);

    return items;
  }

  subscribeToCollectedData(): void {
    this.dashboardsHub.infoSubObservable.subscribe((latestInfo: PercentageInfo) => {
      const infoToInsert = this.toSeriesData(latestInfo);
      for (let i = 0; i < 4; i++) {
        if (this.data[i].series > 20) {
          this.data[i].series.shift();
        }
        this.data[i].series.push(infoToInsert[i]);
      }

      this.data = [...this.data];
    });
  }

  onSelect(event) {
    console.log(event);
  }
}
