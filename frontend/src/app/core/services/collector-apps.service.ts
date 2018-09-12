import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {ApiService} from './api.service';
import { HttpHeaders, HttpEvent } from '@angular/common/http';
import { CollectorApp } from '../../shared/models/collector-app.model';

@Injectable()
export class CollectorAppsService {
  private readonly ctrlUrl = 'CollectorApps';

  constructor(private apiService: ApiService) { }

  public uploadInstaller(file): Observable<HttpEvent<{}>> {
    return this.apiService.uploadFile(`/${this.ctrlUrl}/uploadApp`, file);
  }

  getAll(): Observable<CollectorApp[]> {
    return this.apiService.get(`/${this.ctrlUrl}`);
  }

  getLast(): Observable<CollectorApp> {
    return this.apiService.get(`/${this.ctrlUrl}/active`);
  }

  create(collectorApp: CollectorApp): Observable<CollectorApp> {
    return this.apiService.post(`/${this.ctrlUrl}`, collectorApp);
  }

  delete(id: number): Observable<boolean> {
    return this.apiService.delete(`/${this.ctrlUrl}/${id}`);
  }


}
