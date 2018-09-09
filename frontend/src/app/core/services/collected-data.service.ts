import { Injectable } from '@angular/core';
import {ApiService} from './api.service';
import {Observable} from 'rxjs';
import {CollectedData} from '../../shared/models/collected-data.model';
import {PercentageInfo} from '../../dashboards/models/percentage-info';
import {CollectedDataType} from '../../shared/models/collected-data-type.enum';

@Injectable()
export class CollectedDataService {
  private readonly ctrlUrl = '/CollectedData';

  constructor(private apiService: ApiService) { }

  getBuilderData(): Observable<CollectedData[]> {
    return this.apiService.get(`${this.ctrlUrl}/Builder`) as Observable<CollectedData[]>;
  }

  public getRecentCollectedDataByInstanceId(guidId: string, dataType: CollectedDataType): Observable<CollectedData[]>  {
    debugger;
    return this.apiService.get(`${this.ctrlUrl}/Data/${guidId}?dataType=${dataType}`) as Observable<CollectedData[]>;
  }
}
