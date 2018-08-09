import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Dashboard } from '../../shared/models/dashboard';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  private url = environment.server_url + '/dashboards';

  constructor(private http: HttpClient) {
  }

  getAllByInstance(id: number) {
      return this.http.get(this.url + '/' + id);
  }

  create(dashboard: Dashboard) {
      return this.http.post(this.url, dashboard);
  }

  update(dashboard: Dashboard) {
      return this.http.put(this.url + '/' + dashboard.id, dashboard);
  }

  delete(id: number) {
      return this.http.delete(this.url + '/' + id);
  }
}
