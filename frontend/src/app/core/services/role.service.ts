import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Role } from '../../shared/models/role.model';

@Injectable(/*{
  providedIn: 'root'
}*/)
export class RoleService {

  URL = environment.server_url + '/Roles';

  constructor(private http: HttpClient) {
  }

  getAll(): Observable<Role[]> {
    return this.http.get<Role[]>(this.URL);
  }

  get(id: number): Observable<Role> {
    return this.http.get<Role>(`${this.URL}/${id}`);
  }

  create(feedback: Role) {
    return this.http.post<Role>(this.URL, feedback);
  }

}
