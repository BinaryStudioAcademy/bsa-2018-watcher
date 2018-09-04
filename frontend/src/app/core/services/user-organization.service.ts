import { UserOrganization } from '../../shared/models/user-organization.model';
import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class UserOrganizationService {
  ctrlUrl = environment.server_url + '/UserOrganization';

  constructor(private http: HttpClient) {
  }

  getAll(): Observable<UserOrganization[]> {
    return this.http.get<UserOrganization[]>(this.ctrlUrl);
  }

  create(entity: UserOrganization) {
    return this.http.post<UserOrganization>(`${this.ctrlUrl}`, entity);
  }

  delete(companyId: number, userId: string) {
    //  ${companyId}`, { params: params } const params = new HttpParams().set('userId', userId);
    return this.http.delete(`${this.ctrlUrl}/?companyId=${companyId}&userId=${userId}`);
  }
}
