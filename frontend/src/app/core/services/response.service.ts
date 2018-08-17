import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Response } from '../../shared/models/response.model';

@Injectable(/*{
  providedIn: 'root'
}*/)
export class ResponseService {

  URL = environment.server_url + '/Responses';

  constructor(private http: HttpClient) {
  }

  getAll(): Observable<Response[]> {
    return this.http.get<Response[]>(this.URL);
  }

  get(id: number): Observable<Response> {
    return this.http.get<Response>(`${this.URL}/${id}`);
  }

  create(response: Response) {
    return this.http.post<Response>(this.URL, response);
  }

}
