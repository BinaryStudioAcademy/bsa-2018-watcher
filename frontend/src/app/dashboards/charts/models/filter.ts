import {CustomData} from './custom-data';
import {CustomQuery} from './customQuery';

export interface Filter {
  type: string;
  key: string;
  label: string;
  minValue: any;
  maxValue: any;
  query: CustomQuery;
  step: number;
  values: CustomData[];
  rangeIndex: CustomData;
  range: number[];
}
