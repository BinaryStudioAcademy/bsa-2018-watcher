import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Chart } from '../../shared/models/chart.model';
import { ChartRequest } from '../../shared/requests/chart-request.model';
import {ApiService} from './api.service';

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
}
