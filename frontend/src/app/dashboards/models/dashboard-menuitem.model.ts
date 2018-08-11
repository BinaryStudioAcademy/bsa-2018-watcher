import { MenuItem } from 'primeng/primeng';
import { Instance } from '../../shared/models/instance.model';
import { Chart } from '../../shared/models/chart.model';

export interface DashboardMenuItem extends MenuItem  {
    dashId?: number;
    createdAt?: Date; // required by backend
    instance?: Instance; // required by backend
    charts?: Chart[];
}

