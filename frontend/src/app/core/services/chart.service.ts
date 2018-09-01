import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { Chart } from '../../shared/models/chart.model';
import { ChartRequest } from '../../shared/requests/chart-request.model';

@Injectable(/*{
  providedIn: 'root'
}*/)
export class ChartService {
  private readonly ctrlUrl = environment.server_url +  '/Charts';

  constructor(private http: HttpClient) {
  }

  getAll(): Observable<Chart[]> {
    return this.http.get<Chart[]>(`${this.ctrlUrl}`);
  }

  get(id: number): Observable<Chart> {
    return this.http.get<Chart>(`${this.ctrlUrl}/${id}`);
  }

  create(request: ChartRequest): Observable<Chart> {
    return this.http.post<Chart>(`${this.ctrlUrl}`, request);
  }

  update(id: number, request: ChartRequest) {
    return this.http.put(`${this.ctrlUrl}/${id}`, request);
  }

  delete(id: number) {
    return this.http.delete(`/${this.ctrlUrl}/${id}`);
  }
}
