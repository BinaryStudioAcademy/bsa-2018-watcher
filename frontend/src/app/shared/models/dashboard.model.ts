
import { Instance } from './instance.model';
import { Chart } from './chart.model';

export interface Dashboard  {
   id: number;
   title: string;
   createdAt: Date;
   instanceId: number;
   instance: Instance;
   charts: Chart[];
}



