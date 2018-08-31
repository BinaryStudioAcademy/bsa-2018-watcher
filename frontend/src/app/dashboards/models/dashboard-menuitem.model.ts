import { MenuItem } from 'primeng/primeng';
import {DashboardChart} from './dashboard-chart';

export interface DashboardMenuItem extends MenuItem  {
    dashId?: number;
    createdAt?: Date;
    charts?: DashboardChart[];
}

