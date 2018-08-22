import { Chart } from './chart.model';

export interface Dashboard  {
   id: number;
   title: string;
   createdAt: Date;
   charts: Chart[];
}



