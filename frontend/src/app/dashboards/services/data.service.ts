import {Injectable, EventEmitter} from '@angular/core';
import * as universe from 'universe';
import * as papaparse from 'papaparse';
import {nest} from 'd3-collection';
import {Universe, CustomData, CustomQuery} from '../charts/models';
import {Nameable} from '../charts/models';
import {CollectedData} from '../../shared/models/collected-data.model';
import {ApiService} from '../../core/services/api.service';
import {Observable} from 'rxjs';
import {NumberSeriesItem, SeriesItem} from '../models/series-item';
import {PercentageInfo} from '../models/percentage-info';
import {MultiChartItem} from '../models/multi-chart-item';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  private readonly ctrlUrl = '/CollectedData';
  private _dataText: string;
  private _parsed: { data: CustomData[], errors: any[], meta: any };



  universeUpdated: EventEmitter<Universe> = new EventEmitter();

  dataDims: string[] = [];

  dataUniverse: Universe;

  rawData(): Observable<CollectedData[]> {
    return this.apiService.get(`${this.ctrlUrl}/Builder`) as Observable<CollectedData[]>;
    // return this._parsed.data;
  }


  get errors(): any[] {
    return this._parsed.errors;
  }

  get dataText(): string {
    return this._dataText || ' ';
  }

  get headerValues(): string[] {
    return this._parsed.meta.fields.map(d => ({
      name: d,
      type: typeof this._parsed.data[0][d]
    }));
  }

  constructor(private apiService: ApiService) {
  }

  // dataSource - property to show on the chart
  prepareData(chartType: string, dataSources: string[], dataToTransform: CollectedData[]): CustomData[] {
    if (chartType === 'line-chart') {
      const data: MultiChartItem[] = this.mapToMultiData(dataToTransform, dataSources);
      return data;
    }
    if (chartType === 'bar-vertical') {
      const data: NumberSeriesItem[] = this.mapToSeriesItem(dataToTransform[0], dataSources);
      return data;
    } else {
      const data: NumberSeriesItem[] = this.mapToSeriesItem(dataToTransform[0], dataSources);
      return data;
    }
  }

  mapToMultiData(data: CollectedData[], properties: string[]): MultiChartItem[] {
    const items: MultiChartItem[] = [];
    for (let i = 0; i < properties.length; i++) {
      const item: MultiChartItem = {
        name: properties[i],
        series: []
      };
      item.series = data.map(p => this.mapToLineChartSeriesItem(p, properties[i]));
      items.push(item);
    }

    return items;
  }

  toSeriesData(info: PercentageInfo | CollectedData, property: string): SeriesItem[] {
    const items: SeriesItem[] = [];
    for (let i = 0; i < 3; i++) {
      items.push({name: new Date(info.time), value: 0});
    }

    items[0].value = Math.floor(info.cpuUsagePercent);
    items[1].value = Math.floor(info.ramUsagePercent);
    items[2].value = Math.floor(info.localDiskFreeSpacePercent);

    return items;
  }

  //
  // function legendName(s: string) {
  //   return // TODO: create dictionary and by this s - key - get user friendly value
  // }
  //

  mapToSeriesItem(data: CollectedData, properties: string[]): NumberSeriesItem[] {
    const items: NumberSeriesItem[] = [];
    for (let i = 0; i < properties.length; i++) {
      items.push({name: properties[i], value: data[properties[i]]});
    }

    //
    // const seriesItem: NumberSeriesItem = {
    //   value: data[property],
    //   name: property
    // };

    return items;
  }

  mapToLineChartSeriesItem(data: CollectedData, property: string): SeriesItem {
    const seriesItem: SeriesItem = {
      value: data[property],
      name: new Date(data.time)
    };

    return seriesItem;
  }


  async updateData(dataText: string): Promise<CollectedData[]> {
    this._parsed = papaparse.parse(dataText, {
      header: true,
      dynamicTyping: true,
      skipEmptyLines: true
    });

    if (this._parsed.meta.aborted || this._parsed.data.length === 0) {
      this._dataText = '';
      return this.rawData().toPromise();
    }

    this.dataUniverse = await universe(this._parsed.data);

    this.universeUpdated.emit(this.dataUniverse);
    return this.rawData().toPromise();
  }

  async createQuery(groupBy: string, valueKey: string, aggragate = 'sum'): Promise<CustomQuery> {
    let select: any = {$count: true};
    aggragate = '$' + aggragate;

    if (valueKey && valueKey !== 'count') {
      select = {
        $count: true,
        [valueKey]: {
          [aggragate]: valueKey
        }
      };
    }

    return await this.dataUniverse.query({
      groupBy,
      select
    });
  }

  getChartSeriesFromQuery(query: CustomQuery, yKey: string = 'count', aggragate = 'sum'): CustomData[] {
    let data: any = query.data.map(d => {
      let value = d.value[yKey];
      if (typeof value === 'object') {
        value = value[aggragate];
      }

      // todo: key is array
      return {
        name: d.key,
        value: value
      };
    }); // .filter(d => d.value !== 0);

    if (data.length > 0 && Array.isArray(data[0].name)) {
      data = nest()
        .key(datum => (datum as Nameable).name[0])
        .entries(data)
        .map(d => {
          const series = d.values.map(dd => {
            return {
              name: dd.name[1],
              value: dd.value
            };
          });
          return {
            name: d.key,
            series
          };
        });
    }

    return data;
  }
}
