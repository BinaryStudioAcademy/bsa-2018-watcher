import {EventEmitter, Injectable} from '@angular/core';
import * as universe from 'universe';
import * as papaparse from 'papaparse';
import {nest} from 'd3-collection';
import {CustomData, CustomQuery, Nameable, Universe} from '../charts/models';
import {CollectedData} from '../../shared/models/collected-data.model';
import {ApiService} from '../../core/services/api.service';
import {Observable} from 'rxjs';
import {NumberSeriesItem, SeriesItem} from '../models/series-item';
import {MultiChartItem} from '../models/multi-chart-item';
import {dataPropertyLables, DataProperty, dataProperties} from '../../shared/models/data-property.enum';
import {ChartType} from '../../shared/models/chart-type.enum';

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
  prepareData(chartType: ChartType, dataSources: DataProperty[], dataToTransform: CollectedData[]): CustomData[] {
    if (!chartType && chartType !== ChartType.BarVertical) {
      return [];
    }
    if (chartType === ChartType.LineChart) {
      return this.mapToMultiData(dataToTransform, dataSources);
    } else {
      return this.mapToSeriesItem(dataToTransform[0], dataSources);
    }
  }

  mapToMultiData(data: CollectedData[], properties: DataProperty[]): MultiChartItem[] {
    const items: MultiChartItem[] = [];
    for (let i = 0; i < properties.length; i++) {
      const item: MultiChartItem = {name: '', series: []};
      if (typeof properties[i] === 'number') {
        item.name = dataPropertyLables[properties[i]];
      } else {
        item.name = dataPropertyLables[DataProperty[properties[i]]];
      }

      item.series = data.map(p => this.mapToLineChartSeriesItem(p, properties[i]));
      items.push(item);
    }

    return items;
  }

  mapToSeriesItem(data: CollectedData, properties: DataProperty[]): NumberSeriesItem[] {
    const items: NumberSeriesItem[] = [];
    for (let i = 0; i < properties.length; i++) {
      if (typeof properties[i] === 'number') {
        items.push(
          {
            name: dataPropertyLables[properties[i]],
            value: data[DataProperty[properties[i]]]
          });
      } else {
        items.push(
          {
            name: dataPropertyLables[DataProperty[properties[i]]],
            value: data[properties[i]]
          });
      }
    }

    return items;
  }

  mapToLineChartSeriesItem(data: CollectedData, property: DataProperty): SeriesItem {
    const seriesItem: SeriesItem = { value: 0, name: new Date(data.time) };

    if (typeof property === 'number') {
      seriesItem.value = data[DataProperty[property]];
    } else {
      seriesItem.value = data[property];
    }

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
