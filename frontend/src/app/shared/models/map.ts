import {DataProperty} from '../../dashboards/models/data-property.enum';

export interface ProperiesMap<T> {
  [K: string]: T;
}
