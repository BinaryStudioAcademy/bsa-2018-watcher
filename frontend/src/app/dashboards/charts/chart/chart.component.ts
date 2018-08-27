import {Component, OnInit, Input, EventEmitter, Output, HostBinding, ViewEncapsulation} from '@angular/core';
import * as SvgSaver from 'svgsaver';
import {Universe, Chart, Filter, Data, Query} from '../models/data.models';

const EMPTY = [];

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.sass'],
  encapsulation: ViewEncapsulation.None
})
export class ChartComponent implements OnInit {
  @Output() select: EventEmitter<{ chart: Chart, value?: any }> = new EventEmitter();

  @Input() chart: Chart;
  @Input() chartType: any;
  @Input() data: Data[];

  svgSaver = new SvgSaver();

  @Input() set activeEntries(value: Data[]) {
    this._activeEntries = value;
  }

  get activeEntries(): Data[] {
    return this.hasActiveEntries ? this._activeEntries : EMPTY;
  }

  private _activeEntries: Data[];

  @HostBinding('class.has-active-entries')
  get hasActiveEntries() {
    return this._activeEntries && this._activeEntries.length > 0;
  }

  constructor() {
  }

  ngOnInit() {
  }

  onSelect(data: Data) {
    if (data) {
      const value = typeof data === 'object' ? data.name : data;
      if (this.chart.xFilter) {
        const filter = this.chart.xFilter;
        switch (filter.type) {
          case 'value':
            filter.range[0] = value;
            break;
          default:
            filter.rangeIndex[value] = !filter.rangeIndex[value];
        }
      }
      return this.select.emit({chart: this.chart, value});
    }
    return this.select.emit({chart: this.chart});
  }
}
