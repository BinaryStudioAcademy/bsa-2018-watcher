import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { CollectedData } from '../../shared/models/collected-data.model';
import { Observable } from 'rxjs';
import { AggregateDataRequest } from '../../shared/models/aggregate-data-request.model';

@Injectable({
  providedIn: 'root'
})
export class AggregatedDataService {
  private readonly ctrlUrl = '/AggregatedData';

  constructor(private apiService: ApiService) { }

  getDataByInstanceIdAndTypeInTime(request: AggregateDataRequest): Observable<CollectedData[]> {
    return this.apiService.get(`${this.ctrlUrl}/${request.id}/${request.type}
                                                /${request.from.toISOString()}/${request.to.toISOString()}`) as Observable<CollectedData[]>;
  }

  getDataByInstanceIdAndTypeInTimePaging(request: AggregateDataRequest, page: number, count: number): Observable<CollectedData[]> {
    return this.apiService.get(`${this.ctrlUrl}/${request.id}/${request.type}
                                                /${request.from.toISOString()}/${request.to.toISOString()}
                                                /${page}/${count}`) as Observable<CollectedData[]>;
  }
}
