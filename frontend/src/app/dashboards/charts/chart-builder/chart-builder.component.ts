import {Component, OnInit, NgZone, Output, EventEmitter} from '@angular/core';
import {colorSets} from '@swimlane/ngx-charts/release/utils/color-sets';
import * as shape from 'd3-shape';
import * as chroma from 'chroma-js';

import {CustomChart, CustomChartType, CustomData} from '../models';
import {DataService} from '../../services/data.service';
import {toCapitalizedWords} from '../models';
import {customChartTypes} from './customChartTypes';

const defaultOptions = {
  view: undefined,
  colorScheme: colorSets.find(s => s.name === 'cool'),
  schemeType: 'ordinal',
  showLegend: true,
  legendTitle: 'Legend',
  gradient: false,
  showXAxis: true,
  showYAxis: true,
  showXAxisLabel: true,
  showYAxisLabel: true,
  yAxisLabel: '',
  xAxisLabel: '',
  autoScale: true,
  showGridLines: true,
  rangeFillOpacity: 0.5,
  roundDomains: false,
  tooltipDisabled: false,
  showSeriesOnHover: true,
  curve: shape.curveLinear,
  curveClosed: shape.curveCardinalClosed
} as CustomChart;

@Component({
  selector: 'app-chart-builder',
  templateUrl: './chart-builder.component.html',
  styleUrls: ['./chart-builder.component.sass']
})
export class ChartBuilderComponent implements OnInit {
  chartTypes = customChartTypes;

  dataDims: string[] = [null, null, null, null, 'count'];
  chartOptions: CustomChart;
  colors: string;
  colorsRight: string;
  steps: number;
  bezier: boolean;
  lightness: boolean;
  bezierRight: boolean;
  lightnessRight: boolean;
  diverging: boolean;
  theme: string;
  chartType: CustomChartType = customChartTypes[0];

  data: CustomData[] = [];
  headerValues: any[] = [];

  aggragates = ['count', 'sum', 'avg', 'max', 'min'];

  @Output() addChart: EventEmitter<CustomChart> = new EventEmitter();

  get hasChartSelected(): boolean {
    return this.chartType && !!this.chartType.name;
  }

  get hasValidDimensions(): boolean {
    return this.hasChartSelected &&
      !this.chartType.dimLabels.some((l, i) => l ? !this.dataDims[i] : false);
  }

  constructor(private ngZone: NgZone, private dataService: DataService) {
    dataService.universeUpdated.subscribe(() => {
      this.clearAll();

      const headerValues = this.dataService.headerValues;

      if (JSON.stringify(headerValues) !== JSON.stringify(this.headerValues)) {
        this.headerValues = headerValues.slice();
        this.dataDims = [null, null, null, null, 'count'];
        this.data = [];
      } else {
        this.processData();
      }
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

    const query = await this.dataService.createQuery(xKey, yKey, agg);
    this.data = this.dataService.getChartSeriesFromQuery(query, yKey, agg);

    return this.ngZone.run(() => {
    });
  }

  ngOnInit(): void {
    this.dataDims = [null, null, null, null, 'count'];
    this.clearAll();
  }

  clearAll(): any {
    this.chartType = customChartTypes[0];
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
    this.chartOptions = {...defaultOptions} as CustomChart;
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
    chart.dataDims = this.dataDims.slice();
    chart.theme = this.theme;
    return this.addChart.emit(chart);
  }

  setChartType(chartType: CustomChartType): void {
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








