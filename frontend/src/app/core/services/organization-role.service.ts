import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { OrganizationRole } from '../../shared/models/organization-role.model';

@Injectable()
export class OrganizationRoleService {

  URL = environment.server_url + '/OrganizationRoles';

  constructor(private http: HttpClient) {
  }

  getAll(): Observable<OrganizationRole[]> {
    return this.http.get<OrganizationRole[]>(this.URL);
  }
}
