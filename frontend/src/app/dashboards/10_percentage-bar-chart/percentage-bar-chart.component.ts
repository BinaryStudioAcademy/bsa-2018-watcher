import { Component, OnInit } from '@angular/core';
import {PercentageInfo} from '../models/percentage-info';
import {DashboardsHub} from '../../core/hubs/dashboards.hub';

@Component({
  selector: 'app-percentage-bar-chart',
  templateUrl: './percentage-bar-chart.component.html',
  styleUrls: ['./percentage-bar-chart.component.sass']
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
    {
      name: 'Interrupts',
      value: 4
    }
  ];

   constructor(private notificationsService: DashboardsHub) {
    this.subscribePercentageInfo();
  }

  subscribePercentageInfo(): void {
    this.notificationsService.connectToSignalR();
    this.notificationsService.infoSubObservable.subscribe((latestStatus: PercentageInfo) => {
      this.data[0].value = Math.floor(latestStatus.cpuUsagePercent);
      this.data[1].value = Math.floor(latestStatus.ramUsagePercent);
      this.data[2].value = Math.floor(latestStatus.localDiskFreeSpacePercent);
      this.data[3].value = Math.floor(latestStatus.interruptsTimePercent);
      this.data = [...this.data];
    });
  }

  ngOnInit() {
  }

  onSelect(event) {
    console.log(event);
  }
}
