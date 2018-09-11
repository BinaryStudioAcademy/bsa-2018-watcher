import {DashboardRequest} from '../models/dashboard-request.model';
import {ChartRequest} from './chart-request.model';

export interface CreateDashboardRequest extends DashboardRequest {
  chartRequests: ChartRequest[];
}
