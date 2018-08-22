import { MenuItem } from 'primeng/primeng';
import { Chart } from '../../shared/models/chart.model';

export interface DashboardMenuItem extends MenuItem  {
    dashId?: number;
    createdAt?: Date;
    charts?: Chart[];
}

