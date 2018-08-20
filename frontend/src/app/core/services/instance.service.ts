import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { ToastrService } from './toastr.service';
import { InstanceRequest } from '../../dashboards/models/instance-request.model';
import { EventEmitter } from '@angular/core';
import { Instance } from '../../shared/models/instance.model';

@Injectable({
  providedIn: 'root'
})
export class InstanceService {

  private url = environment.server_url + '/instances';

  public instanceAdded: EventEmitter<Instance>;
  public instanceEdited: EventEmitter<Instance>;
  public instanceRemoved: EventEmitter<number>;
  public instanceChecked: EventEmitter<Instance>;

  constructor(private http: HttpClient,
    private toastrService: ToastrService) {
    this.instanceAdded = new EventEmitter<Instance>();
    this.instanceEdited = new EventEmitter<Instance>();
    this.instanceRemoved = new EventEmitter<number>();
    this.instanceChecked = new EventEmitter<Instance>();
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
    const responce =  this.http.post(this.url, instance).pipe(
      retry(1),
      catchError(this.handleError));
    return responce;
  }

  update(instance: InstanceRequest, id: number): Observable<Object> {
    const responce = this.http.put(`${this.url}/${id}`, instance).pipe(
      retry(1),
      catchError(this.handleError));
    return responce;
  }
/*
  updateDto(id: number, instance: Instance) {
    return this.http.put(`/${this.url}/${id}`, instance);
  }*/

  delete(id: number): Observable<Object> {
    const responce = this.http.delete(`${this.url}/${id}`).pipe(
      retry(1),
      catchError(this.handleError));
    return responce;
  }

  handleError(error: HttpErrorResponse) {
    this.toastrService.error(`Error status: ${error.status}`);
    return throwError(error.status);
  }
}

