import { Injectable, EventEmitter } from '@angular/core';
import * as universe from 'universe';
import * as papaparse from 'papaparse';
import { nest } from 'd3-collection';
import {Universe, Chart, Filter, Data, Query } from '../charts/models/data.models';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  private _dataText: string;
  private _parsed: {data: Data[], errors: any[], meta: any};

  universeUpdated: EventEmitter<Universe> = new EventEmitter();

  dataDims: string[] = [];

  dataUniverse: Universe;

  get rawData(): Data[] {
    return this._parsed.data;
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

  constructor() { }

  async updateData(dataText: string): Promise<Data[]> {
    this._parsed = papaparse.parse(dataText, {
      header: true,
      dynamicTyping: true,
      skipEmptyLines: true
    });

    if (this._parsed.meta.aborted || this._parsed.data.length === 0) {
      this._dataText = '';
      return this.rawData;
    }

    this.dataUniverse = await universe(this._parsed.data);

    this.universeUpdated.emit(this.dataUniverse);
    return this.rawData;
  }

  async createQuery(groupBy: string, valueKey: string, aggragate = 'sum'): Promise<Query> {
    let select: any = { $count: true };
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

  getChartSeriesFromQuery(query: Query, yKey: string = 'count', aggragate = 'sum'): Data[] {
    let data: any = query.data.map(d => {
      let value =  d.value[yKey];
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
        .key(d => d.name[0])
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
