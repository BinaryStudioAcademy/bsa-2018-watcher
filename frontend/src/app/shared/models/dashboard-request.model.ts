import {Instance} from './instance.model';
import {Chart} from './chart.model';

export interface DashboardRequest {
  title: string;
  instance: Instance;
  charts?: Chart[];
}
