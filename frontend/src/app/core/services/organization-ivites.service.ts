import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
import { OrganizationInvites } from '../../shared/models/organization-invite.model';

@Injectable({
  providedIn: 'root'
})
export class OrganizationService {
  private readonly ctrlUrl = 'organizations';

  constructor(private apiService: ApiService) {
  }

  getAll(): Observable<OrganizationInvites[]> {
    return this.apiService.get(`/${this.ctrlUrl}`);
  }

  get(id: number): Observable<OrganizationInvites> {
    return this.apiService.get(`/${this.ctrlUrl}/${id}`);
  }

  create(organization: OrganizationInvites) {
    return this.apiService.post(`/${this.ctrlUrl}`, organization);
  }

  update(id: number, organization: OrganizationInvites) {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, organization);
  }

  delete(id: number): Observable<OrganizationInvites> {
    return this.apiService.delete(`/${this.ctrlUrl}/${id}`);
  }
}
