import { Injectable } from '@angular/core';
import { Dashboard } from '../../shared/models/dashboard.model';
import { Observable } from 'rxjs';
import {DashboardRequest} from '../../shared/models/dashboard-request.model';
import {ApiService} from './api.service';
import {Instance} from '../../shared/models/instance.model';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {
  private ctrlUrl = 'Dashboards';

  constructor(private apiService: ApiService) {
  }

  getAllByInstance(id: number): Observable<Dashboard[]> {
      return this.apiService.get(`/${this.ctrlUrl}/${id}`);
  }

  getDefaultInstance(): Observable<Instance> {
    return this.apiService.get(`/${this.ctrlUrl}/FirstInstance`);
  }

  create(request: DashboardRequest): Observable<Dashboard> {
    return this.apiService.post(`/${this.ctrlUrl}`, request);
  }

  update(id: number, request: DashboardRequest): Observable<Object> {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, request);
  }

  delete(id: number): Observable<Object> {
    return this.apiService.delete(`/${this.ctrlUrl}/${id}`);
  }
}

