import { Instance } from './instance.model';
import { Chart } from './chart.model';

export class Dashboard {

  constructor(title, createdAt, instanceId) {
    this.title = title;
    this.createdAt = createdAt;
    this.instanceId = instanceId;
  }
  id: number;
  title: string;
  createdAt: Date;
  instanceId: number;
  instance: Instance;
  charts: Chart[];
}




















