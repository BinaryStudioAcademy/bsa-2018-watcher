import { MenuItem } from 'primeng/primeng';
import { Instance } from '../../shared/models/instance.model';
import { Chart } from '../../shared/models/chart.model';

export interface DashboardMenuItem extends MenuItem  {
   dashId?: number;
   label: string;
   title: string;
   createdAt: Date;
   instance: Instance;
   charts?: Chart[];
}

