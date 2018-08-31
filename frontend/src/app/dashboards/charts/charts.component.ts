import { Component, ViewEncapsulation, OnInit, ViewChild, TemplateRef, NgZone } from '@angular/core';
import { colorSets } from '@swimlane/ngx-charts/release/utils/color-sets';
import SvgSaver from 'svgsaver';

import { TabsComponent, TabComponent } from '@swimlane/ngx-ui';
import {
  CustomChart,
  CustomData,
  Filter,
  CustomQuery,
  gapminder,
  toCapitalizedWords} from './models';
import {DataService} from '../services/data.service';

@Component({
  selector: 'app-charts',
  templateUrl: './charts.component.html',
  styleUrls: ['./charts.component.sass'],
  encapsulation: ViewEncapsulation.None
})
export class ChartsComponent implements OnInit {
  charts: CustomChart[] = [];
  filters: Filter[] = [];

  @ViewChild('tabs') tabs: TabsComponent;
  @ViewChild('dashboardTab') dashboardTab: TabComponent;
  @ViewChild('dataTab') dataTab: TabComponent;

  _dataText = ' ';
  errors: any[] = [];
  rawData: CustomData[] = [];

  get dataText(): string {
    return this._dataText || ' ';
  }

  set dataText(value: string) {
    this.updateData(value);
  }

  get hasValidData() {
    return this._dataText.length > 0 && this.errors.length === 0;
  }

  editorConfig = {
    lineNumbers: true,
    theme: 'dracula',
    mode: {
      name: 'json'
    }
  };

  svgSaver; // = new SvgSaver();

  constructor(private ngZone: NgZone, private dataService: DataService) { }

  ngOnInit() {
    this.clearAll();
  }

  async useExample() {
    this._dataText = gapminder;
    await this.updateData();
    // this.dataDims = [5, 0, 3, 3].map(i => this.headerValues[i].name);

    this.ngZone.run(() => {});
  }

  onResetClicked() {
    this.clearAll();
    this.tabs.tabClicked(this.dataTab);
  }

  clearAll() {
    this.dataText = '';
    this.charts = [];
    this.filters = [];
  }

  async addChartToDashboard(chart: CustomChart) {
    this.charts.push(chart);

    // todo: assumes single series chart
    const x = this.dataService.createQuery(chart.dataDims[0], chart.dataDims[2], chart.dataDims[4]);
    const y = this.dataService.createQuery(chart.dataDims[2], 'count');

    const qs = await Promise.all([x, y]);

    chart.xQuery = qs[0];
    chart.yQuery = qs[1];

    chart.xFilter = this.addFilter(chart.xQuery);
    chart.yFilter = this.addFilter(chart.yQuery);

    this.tabs.tabClicked(this.dashboardTab);
  }

  private async updateData(value = this._dataText) {
    const data = await this.dataService.updateData(value);

    if (data.length < 1 || this.errors.length) {
      this._dataText = '';
      this.errors = [];
      return;
    }

    this.rawData = data;
    this._dataText = value;
  }

  private addFilter(query: CustomQuery): Filter {
    const key = query.column.key;
    let filter = this.filters.find(c => c.key === key);
    if (!filter) {
      const values = query.column.values;
      const minValue = Math.min(...values);
      const maxValue = Math.max(...values);

      const type = (values.length < 6 || isNaN(minValue) || isNaN(maxValue)) ? 'cat' : 'value';

      let range = [];
      let rangeIndex = {};
      if (type === 'value') {
        range = [minValue, maxValue];
      } else {
        range = query.column.values.slice(0);
        rangeIndex = range.reduce((acc, cur) => {
          acc[cur] = true;
          return acc;
        }, rangeIndex);
      }

      filter = {
        type,
        label: toCapitalizedWords(key),
        key,
        minValue,
        maxValue,
        query,
        step: 1,
        values,
        rangeIndex,
        range
      };
      this.filters.push(filter);
    }
    return filter;
  }
}
