import {ChangeDetectionStrategy, Component, EventEmitter, HostBinding, Input, OnInit, Output, ViewEncapsulation} from '@angular/core';
import * as SvgSaver from 'svgsaver';
import {CustomChart, CustomData} from '../models';

const EMPTY = [];

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.sass'],
  encapsulation: ViewEncapsulation.None,
  changeDetection: ChangeDetectionStrategy.Default
})
export class ChartComponent implements OnInit {
  @Output() select: EventEmitter<{ chart: CustomChart, value?: any }> = new EventEmitter();

  @Input() chart: CustomChart;
  @Input() chartType: any;
  @Input() data: CustomData[];
  // TODO: Here after Data came from father component need to parse data and render it on Component

  svgSaver = new SvgSaver();

  @Input() set activeEntries(value: CustomData[]) {
    this._activeEntries = value;
  }

  get activeEntries(): CustomData[] {
    return this.hasActiveEntries ? this._activeEntries : EMPTY;
  }

  private _activeEntries: CustomData[];

  @HostBinding('class.has-active-entries')
  get hasActiveEntries() {
    return this._activeEntries && this._activeEntries.length > 0;
  }

  constructor() {
  }

  ngOnInit() {
  }

  onSelect(data: CustomData) {
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
