import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Dashboard } from '../../shared/models/dashboard';
import { environment } from '../../../environments/environment';
import { Observable, throwError } from '../../../../node_modules/rxjs';
import { retry, catchError } from '../../../../node_modules/rxjs/operators';
import { ToastrService } from './toastr.service';

@Injectable({
  providedIn: 'root'
})
export class DashboardService {

  private url = environment.server_url + '/dashboards';

  constructor(private http: HttpClient) {
  }

  getAllByInstance(id: number) {
      return this.http.get(`${this.url}/${id}`).pipe(
        retry(2),
        catchError(this.handleError)
      );
  }

  create(dashboard: Dashboard) {
    return this.http.post(this.url, dashboard).pipe(
      retry(2),
      catchError(this.handleError));
  }

  update(dashboard: Dashboard) {
      return this.http.put(`${this.url}/${dashboard.id}`, dashboard).pipe(
        retry(2),
        catchError(this.handleError));
  }

  delete(id: number) {
      return this.http.delete(`${this.url}/${id}`).pipe(
        retry(2),
        catchError(this.handleError));
  }

  handleError(error: HttpErrorResponse) {
    console.error(
      `Backend returned code ${error.status}, ` +
      `body was: ${error.error}`);

    return throwError(error.status);
  }
}

