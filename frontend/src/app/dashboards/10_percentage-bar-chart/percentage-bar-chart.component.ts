import { Component, OnInit } from '@angular/core';
import {DashboardService} from '../../core/services/dashboard.service';
import {NotificationsService} from '../../core/services/notifications.service';
import {MarketPriceDate} from '../models';
import {SeriesItem} from '../models/series-item';

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
  xAxisLabel = 'Sources';
  showYAxisLabel = true;
  yAxisLabel = 'Percentage';

  colorScheme = {
    domain: ['#5AA454', '#A10A28', '#C7B42C', '#AAAAAA']
  };

  marketData: any[] = [
    {
      name: 'Market Data Open',
      series: [
        // {
        //   value: 1311,
        //   name: new Date(2016, 9, 25, 22, 0, 10) // '2016-09-24T22:00:10.000Z'
        // }
      ]
    },
    {
      name: 'Market Data Close',
      series: [
        // {
        //   value: 1511,
        //   name: new Date(2016, 9, 25, 22, 0, 10) // '2016-09-24T22:00:10.000Z'
        // }
      ]
    }
  ];

  constructor(private dashboardsService: DashboardService,
              private notificationsService: NotificationsService) {
    this.notificationsService.getInitialMarketStatus()
      .subscribe(prices => {
        // debugger;
        const openData = prices.map(p => this.toSeriesData(p, true));
        const closeData = prices.map(p => this.toSeriesData(p, false));

        this.marketData[0].series.push(...openData);
        this.marketData[1].series.push(...closeData);

        this.marketData = [...this.marketData];
        this.subscribeToMarket();
      });
  }


  toSeriesData(price: MarketPriceDate, isOpen: boolean): SeriesItem {
    const data: SeriesItem = {
      name: new Date(price.date),
      value: 0
    };

    if (isOpen) {
      data.value = price.open;
    } else {
      data.value = price.close;
    }

    return data;
  }

  subscribeToMarket(): void {
    this.notificationsService.connectToSignalR();
    this.notificationsService.subscribeToMarketDataFeed();
    this.notificationsService.marketSubObservable.subscribe((latestStatus: MarketPriceDate) => {
      console.log(latestStatus);
      this.marketData[0].series.push({ name: new Date(latestStatus.date), value: latestStatus.open });
      this.marketData[1].series.push({ name: new Date(latestStatus.date), value: latestStatus.close });
      this.marketData[0].series.shift();
      this.marketData[1].series.shift();
      this.marketData = [...this.marketData];
    });
  }

  ngOnInit() {
  }

  onSelect(event) {
    console.log(event);
  }
}
