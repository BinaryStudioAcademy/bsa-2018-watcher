import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';
import { CollectorLog } from '../../shared/models/collector-log.model';
@Injectable({
  providedIn: 'root'
})
export class CollectorLogService {
  private readonly ctrlUrl = '/CollectorLog';

  constructor(private apiService: ApiService) { }

  public getAllLogs(instanceId: string): Observable<CollectorLog[]> {
    return this.apiService.get(`${this.ctrlUrl}/${instanceId}`) as Observable<CollectorLog[]>;
  }
}
