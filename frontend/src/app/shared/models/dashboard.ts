import { Instance } from './instance';
import { Chart } from './chart';

export class Dashboard {
  constructor(
    public id: number,
    public title: string,
    public createdAt: Date,
    public instanceId: number,
    public instance: Instance,
    public charts: Chart[]) {
  }
}




















