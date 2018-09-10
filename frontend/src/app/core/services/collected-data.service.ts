import {Injectable} from '@angular/core';
import {ApiService} from './api.service';
import {Observable} from 'rxjs';
import {CollectedData} from '../../shared/models/collected-data.model';
import {CollectedDataType} from '../../shared/models/collected-data-type.enum';
import {map} from 'rxjs/operators';

@Injectable()
export class CollectedDataService {
  private readonly ctrlUrl = '/CollectedData';

  constructor(private apiService: ApiService) {
  }

  getBuilderData(): Observable<CollectedData[]> {
    return this.apiService.get(`${this.ctrlUrl}/Builder`) as Observable<CollectedData[]>;
  }

  public getCollectedDataByInstanceId(guidId: string, dataType: CollectedDataType): Observable<CollectedData[]> {
    return this.apiService.get(`${this.ctrlUrl}/Data/${guidId}?dataType=${dataType}`)
      .pipe(map(this.extractData));
  }

  private extractData(res: CollectedData[]): CollectedData[] {
    const data = res || [];
    data.forEach((d) => {
      d.time = new Date(d.time);
    });
    return data;
  }
}
