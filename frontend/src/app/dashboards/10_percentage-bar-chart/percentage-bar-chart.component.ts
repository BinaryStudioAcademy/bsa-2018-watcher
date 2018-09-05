import {ChangeDetectionStrategy, Component, Input, OnInit} from '@angular/core';
import {DashboardsHub} from '../../core/hubs/dashboards.hub';
import {CollectedData} from '../../shared/models/collected-data.model';
import {PercentageInfo} from '../models/percentage-info';

@Component({
  selector: 'app-percentage-bar-chart',
  templateUrl: './percentage-bar-chart.component.html',
  styleUrls: ['./percentage-bar-chart.component.sass'],
  changeDetection: ChangeDetectionStrategy.Default
})
export class PercentageBarChartComponent implements OnInit {
  view: any[] = [700, 300];

  // options
  showXAxis = true;
  showYAxis = true;
  gradient = false;
  showLegend = true;
  showXAxisLabel = true;
  showYAxisLabel = true;
  yScaleMin = 0;
  yScaleMax = 100;
  xAxisLabel = 'Parameters';
  yAxisLabel = 'Percentage %';

  @Input() dataToPlot: CollectedData | PercentageInfo;

  colorScheme = {
    domain: ['#5AA454', '#A10A28', '#C7B42C', '#AAAAAA']
  };

  data: any[] = [
    {
      name: 'CPU',
      value: 1
    },
    {
      name: 'RAM',
      value: 2
    },
    {
      name: 'Disk Free Space',
      value: 3
    },
    // {
    //   name: 'Interrupts',
    //   value: 4
    // }
  ];

   constructor(private dashboardsHub: DashboardsHub) {
  }

  ngOnInit() {
    if (this.dataToPlot) {
      this.renderChart(this.dataToPlot);
    }
    this.subscribePercentageInfo();
  }

  subscribePercentageInfo(): void {
    this.dashboardsHub.infoSubObservable.subscribe((latestData: CollectedData | PercentageInfo) => {
      this.renderChart(latestData);
    });
  }

  renderChart(data: CollectedData | PercentageInfo) {
    // this.data[0].value = Math.floor(data.cpuUsagePercent);
    // this.data[1].value = Math.floor(data.ramUsagePercent);
    // this.data[2].value = Math.floor(data.localDiskFreeSpacePercent);
    // this.data[3].value = Math.floor(data.interruptsTimePercent);
    this.data = [...this.data];
  }

  onSelect(event) {
    console.log(event);
  }
}
