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
  prepareData(chartType: string, dataSource: string, dataToTransform: CollectedData[]): CustomData[] {
    if (chartType === 'Bar vertical') {
      const data: NumberSeriesItem = this.mapToSeriesItem(dataToTransform[0], dataSource);
      return [data];
    } else {
      const data: NumberSeriesItem = this.mapToSeriesItem(dataToTransform[0], dataSource);
      return [data];
    }
  }

  mapToSeriesItem(data: CollectedData, property: string): NumberSeriesItem {
    const seriesItem: NumberSeriesItem = {
      value: data[property],
      name: property
    };


    return seriesItem;

    // this.data[0].value = Math.floor(data.cpuUsagePercent);
    // this.data[1].value = Math.floor(data.ramUsagePercent);
    // this.data[2].value = Math.floor(data.localDiskFreeSpacePercent);

    // this.data = [...this.data];
  }

  toSeriesData(info: PercentageInfo | CollectedData): SeriesItem[] {
    const items: SeriesItem[] = [];
    for (let i = 0; i < 3; i++) {
      items.push({name: new Date(info.time), value: 0});
    }

    items[0].value = Math.floor(info.cpuUsagePercent);
    items[1].value = Math.floor(info.ramUsagePercent);
    items[2].value = Math.floor(info.localDiskFreeSpacePercent);
    // items[3].value = Math.floor(info.interruptsTimePercent);

    return items;
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
