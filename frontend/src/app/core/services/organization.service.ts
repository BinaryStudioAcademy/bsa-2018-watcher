import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
import { Organization } from '../../shared/models/organization.model';

@Injectable({
  providedIn: 'root'
})
export class OrganizationService {
  private readonly ctrlUrl = 'organizations';

  constructor(private apiService: ApiService) {
  }

  getAll(): Observable<Organization[]> {
    return this.apiService.get(`/${this.ctrlUrl}`);
  }

  get(id: number): Observable<Organization> {
    return this.apiService.get(`/${this.ctrlUrl}/${id}`);
  }

  create(organization: Organization) {
    return this.apiService.post(`/${this.ctrlUrl}`, organization);
  }

  update(id: number, organization: Organization) {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, organization);
  }

  delete(id: number): Observable<Organization> {
    return this.apiService.delete(`/${this.ctrlUrl}/${id}`);
  }
}
