import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { ToastrService } from './toastr.service';
import { InstanceRequest } from '../../dashboards/models/instance-request.model';

@Injectable({
  providedIn: 'root'
})
export class InstanceService {

  private url = environment.server_url + '/instances';

  constructor(private http: HttpClient,
              private toastrService: ToastrService) {
  }

  getOne(id: number): Observable<Object> {
    return this.http.get(`${this.url}/single/${id}`).pipe(
        retry(1),
        catchError(this.handleError)
      );
  }

  getAllByOrganization(id: number): Observable<Object> {
      return this.http.get(`${this.url}/${id}`).pipe(
        retry(1),
        catchError(this.handleError)
      );
  }

  create(instance: InstanceRequest): Observable<Object> {
    console.log('from service');
    console.log(instance);
    return this.http.post(this.url, instance).pipe(
      retry(1),
      catchError(this.handleError));
  }

  update(instance: InstanceRequest, id: number): Observable<Object> {
    return this.http.put(`${this.url}/${id}`, instance).pipe(
        retry(1),
        catchError(this.handleError));
  }

  delete(id: number): Observable<Object> {
      return this.http.delete(`${this.url}/${id}`).pipe(
        retry(1),
        catchError(this.handleError));
  }

  handleError(error: HttpErrorResponse) {
    this.toastrService.error(`Error status ${error}`);
    return throwError(error.status);
  }
}

