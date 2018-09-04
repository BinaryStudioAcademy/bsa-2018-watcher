import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
import { Organization } from '../../shared/models/organization.model';

@Injectable()
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

  getRange(page: number, pageSize: number): Observable<Organization[]> {
    return this.apiService.get(`/${this.ctrlUrl}/table?page=${page}&pageSize=${pageSize}`);
  }

  getNumber(): Observable<number> {
    return this.apiService.get(`/${this.ctrlUrl}/number`);
  }

  create(organization: Organization): Observable<Organization> {
    return this.apiService.post(`/${this.ctrlUrl}`, organization);
  }

  update(id: number, organization: Organization) {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, organization);
  }

  delete(id: number): Observable<Organization> {
    return this.apiService.delete(`/${this.ctrlUrl}/${id}`);
  }
}
