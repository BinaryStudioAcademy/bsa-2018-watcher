import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Chart } from '../../shared/models/chart.model';
import { ChartRequest } from '../../shared/requests/chart-request.model';
import {ApiService} from './api.service';
import {DashboardChart} from '../../dashboards/models/dashboard-chart';

@Injectable()
export class ChartService {
  private readonly ctrlUrl = 'Charts';

  constructor(private apiService: ApiService) {
  }

  getAll(): Observable<Chart[]> {
    return this.apiService.get(`/${this.ctrlUrl}`);
  }

  get(id: number): Observable<Chart> {
    return this.apiService.getById(`/${this.ctrlUrl}`, id);
  }

  create(request: ChartRequest): Observable<Chart> {
    return this.apiService.post(`/${this.ctrlUrl}`, request);
  }

  update(request: ChartRequest, id: number) {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, request);
  }

  delete(id: number) {
    return this.apiService.delete(`/${this.ctrlUrl}/${id}`);
  }

  createChartRequest(dashboardChart: DashboardChart): ChartRequest {
    return {
      showCommon: dashboardChart.showCommon,
      threshold: dashboardChart.threshold,
      mostLoaded: 1,
      historyTime: dashboardChart.historyTime,
      schemeType: dashboardChart.colorScheme.name,
      dashboardId: 0,
      showLegend: dashboardChart.showLegend,
      legendTitle: dashboardChart.legendTitle,
      gradient: dashboardChart.gradient,
      showXAxis: dashboardChart.showXAxis,
      showYAxis: dashboardChart.showYAxis,
      showXAxisLabel: dashboardChart.showXAxisLabel,
      showYAxisLabel: dashboardChart.showYAxisLabel,
      yAxisLabel: dashboardChart.yAxisLabel,
      xAxisLabel: dashboardChart.xAxisLabel,
      autoScale: dashboardChart.autoScale,
      showGridLines: dashboardChart.showGridLines,
      rangeFillOpacity: dashboardChart.rangeFillOpacity,
      roundDomains: dashboardChart.roundDomains,
      isTooltipDisabled: dashboardChart.tooltipDisabled,
      isShowSeriesOnHover: dashboardChart.showSeriesOnHover,
      title: dashboardChart.title,
      type: dashboardChart.type,
      sources: dashboardChart.dataSources.join(),
      isLightTheme: dashboardChart.theme === 'light',
    };
  }
}
