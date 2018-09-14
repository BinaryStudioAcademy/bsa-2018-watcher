import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';
import { InstanceAnomalyReport } from '../../shared/models/instance-anomaly-report.model';
import { AnomalyReportRequest } from '../../shared/models/anomaly-report-request.model';

@Injectable({
  providedIn: 'root'
})
export class AnomalyReportService {
  private readonly ctrlUrl = '/InstanceAnomalyReports';

  constructor(private apiService: ApiService) { }

  getDataByInstanceIdAndTypeInTime(request: AnomalyReportRequest): Observable<InstanceAnomalyReport[]> {
    return this.apiService.get(`${this.ctrlUrl}/${request.id}/${request.type}
                                    /${request.from.toISOString()}/${request.to.toISOString()}`) as Observable<InstanceAnomalyReport[]>;
  }

  getCountOfEntities(request: AnomalyReportRequest): Observable<number> {
    return this.apiService.get(`${this.ctrlUrl}/getCount/${request.id}/${request.type}
                                                /${request.from.toISOString()}/${request.to.toISOString()}`) as Observable<number>;
  }

  getDataByInstanceIdAndTypeInTimePaging(request: AnomalyReportRequest,
                                                  page: number, count: number): Observable<InstanceAnomalyReport[]> {
    return this.apiService.get(`${this.ctrlUrl}/${request.id}/${request.type}
                                                /${request.from.toISOString()}/${request.to.toISOString()}
                                                /${page}/${count}`) as Observable<InstanceAnomalyReport[]>;
  }
}
