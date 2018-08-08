import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Organization } from '../../shared/models/organization';

@Injectable({
  providedIn: 'root'
})
export class OrganizationService {

  URL = 'http://localhost:28046/organizations/';
  constructor(private http: HttpClient) {

  }

  getAll(): Observable<Organization[]> {
    return this.http.get<Organization[]>(this.URL);
  }

  get(id: number): Observable<Organization> {
    return this.http.get<Organization>(this.URL + id);
  }

  create(organization: Organization) {
    return this.http.post<Organization>(this.URL, organization);
  }

  update(id: number, organization: Organization) {
    return this.http.put<Organization>(this.URL + id, organization);
  }

  delete(id: number): Observable<Organization> {
    return this.http.delete<Organization>(this.URL + id);
  }
}
