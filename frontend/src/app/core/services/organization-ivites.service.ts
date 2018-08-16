import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
import { OrganizationInvite } from '../../shared/models/organization-invite.model';

@Injectable({
  providedIn: 'root'
})
export class OrganizationInvitesService {
  private readonly ctrlUrl = 'OrganizationInvites';

  constructor(private apiService: ApiService) {
  }

  getAll(): Observable<OrganizationInvite[]> {
    return this.apiService.get(`/${this.ctrlUrl}`);
  }

  get(id: number): Observable<OrganizationInvite> {
    return this.apiService.get(`/${this.ctrlUrl}/${id}`);
  }

  create(organizationInvite: OrganizationInvite) {
    return this.apiService.post(`/${this.ctrlUrl}`, organizationInvite);
  }

  update(id: number, organization: OrganizationInvite) {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, organization);
  }

  delete(id: number): Observable<OrganizationInvite> {
    return this.apiService.delete(`/${this.ctrlUrl}/${id}`);
  }
}
