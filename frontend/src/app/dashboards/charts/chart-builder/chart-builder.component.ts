import {Component, OnInit, NgZone, Output, EventEmitter} from '@angular/core';
import * as chroma from 'chroma-js';

import { DashboardChartType, CustomData} from '../models';
import {toCapitalizedWords} from '../models';
import {customChartTypes} from '../models/customChartTypes';
import {CollectedDataService} from '../../../core/services/collected-data.service';
import {defaultOptions} from '../models/chart-options';
import {DashboardChart} from '../../models/dashboard-chart';

@Component({
  selector: 'app-chart-builder',
  templateUrl: './chart-builder.component.html',
  styleUrls: ['./chart-builder.component.sass']
})
export class ChartBuilderComponent implements OnInit {
  chartTypes = customChartTypes;

  dataDims: string[] = [null, null, null, null, 'count'];
  chartOptions: DashboardChart;
  colors: string;
  colorsRight: string;
  steps: number;
  bezier: boolean;
  lightness: boolean;
  bezierRight: boolean;
  lightnessRight: boolean;
  diverging: boolean;
  theme: string;
  chartType: DashboardChartType = customChartTypes[0];

  data: CustomData[] = [];
  headerValues: any[] = [];

  aggragates = ['count', 'sum', 'avg', 'max', 'min'];

  @Output() addChart: EventEmitter<DashboardChart> = new EventEmitter();

  get hasChartSelected(): boolean {
    return this.chartType && !!this.chartType.name;
  }

  get hasValidDimensions(): boolean {
    return this.hasChartSelected &&
      !this.chartType.dimLabels.some((l, i) => l ? !this.dataDims[i] : false);
  }

  constructor(private ngZone: NgZone,
              private collectedDataService: CollectedDataService) {
  }

  ngOnInit(): void {
    this.dataDims = [null, null, null, null, 'count'];
    this.clearAll();

    this.collectedDataService.getBuilderData()
      .subscribe(value => {
        console.log(value);
      });
  }

  setChartLabels(): any {
    if (!this.hasValidDimensions) {
      return;
    }

    const labels = this.chartType.chartLabels(this.dataDims.map(toCapitalizedWords));
    return Object.assign(this.chartOptions, labels);
  }

  async processData(): Promise<void> {
    if (!this.hasValidDimensions) {
      return;
    }

    this.setChartLabels();

    let xKey: any = this.dataDims[0];
    if (this.dataDims[1]) {
      xKey = [xKey, this.dataDims[1]];
    }

    const yKey = this.dataDims[2];
    const agg = this.dataDims[4];

    return this.ngZone.run(() => {
    });
  }

  clearAll(): any {
    this.chartType = {...customChartTypes[0]};
    this.theme = 'dark';
    this.colors = '#a8385d,#7aa3e5,#a27ea8,#aae3f5,#adcded,#a95963,#8796c0,#7ed3ed,#50abcc,#ad6886';
    this.colorsRight = 'darkred, deeppink, orange, lightyellow';
    this.steps = 10;
    this.bezier = false;
    this.lightness = false;
    this.bezierRight = false;
    this.lightnessRight = false;
    this.bezier = false;
    this.lightness = false;
    this.chartOptions = {...defaultOptions};
    this.chartOptions.chartType = {...defaultOptions.chartType};
    return this.updateColorScheme();
  }

  updateColorScheme(): any {
    const domain = this.diverging ? this.updateColorSchemeDiv() : this.updateColorSchemeSeq();
    return this.chartOptions.colorScheme = {...this.chartOptions.colorScheme, domain};
  }

  async onAddToDashboard(): Promise<void> {
    const chart = {...this.chartOptions};
    chart.data = this.data.slice();
    chart.chartType = {...this.chartType};
    chart.theme = this.theme;
    return this.addChart.emit(chart);
  }

  setChartType(chartType: DashboardChartType): void {
    this.chartType = chartType;
    this.dataDims = chartType.dimLabels.map((l, i) => l ? this.dataDims[i] : null);
    return this.setChartLabels();
  }

  private updateColorSchemeSeq(): string[] {
    return this.getColorScale(this.colors, this.bezier, this.lightness);
  }

  private updateColorSchemeDiv(): string[] {
    const domainL = this.getColorScale(this.colors, this.bezier, this.lightness);
    const domainR = this.getColorScale(this.colorsRight, this.bezierRight, this.lightnessRight);

    if (domainL[domainL.length - 1] === domainR[0]) {
      domainL.pop();
    }

    return chroma.scale([...domainL, ...domainR]).colors(this.steps);
  }

  private getColorScale(colors: string, bezier: boolean, lightness: boolean): string[] {
    const cleanColors = clean(colors);
    const scale = bezier ? chroma.bezier(cleanColors.slice(0, 5)).scale() : chroma.scale(cleanColors);
    return scale.mode('lab').correctLightness(lightness).colors(this.steps);

    function clean(s: string): string[] {
      return s.trim().replace(/(, *| +)/g, ',').replace(/['"]/g, '').split(',');
    }
  }
}








