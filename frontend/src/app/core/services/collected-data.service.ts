import { Injectable } from '@angular/core';
import {ApiService} from './api.service';
import {Observable} from 'rxjs';
import {CollectedData} from '../../shared/models/collected-data.model';
import {PercentageInfo} from '../../dashboards/models/percentage-info';

@Injectable({
  providedIn: 'root'
})
export class CollectedDataService {
  private readonly ctrlUrl = '/CollectedData';

  constructor(private apiService: ApiService) { }

  getBuilderData(): Observable<CollectedData[]> {
    return this.apiService.get(`${this.ctrlUrl}/Builder`) as Observable<CollectedData[]>;
  }

  public getInitialPercentageInfoByInstanceId(id: number): Observable<PercentageInfo[]> {
    return this.apiService.get(`${this.ctrlUrl}/Percentage/${id}?count=20`) as Observable<PercentageInfo[]>;
  }

  public getRecentCollectedDataByInstanceId(guidId: string): Observable<CollectedData[]>  {
    return this.apiService.get(`${this.ctrlUrl}/Data/${guidId}?count=20`) as Observable<CollectedData[]>;
  }
}
