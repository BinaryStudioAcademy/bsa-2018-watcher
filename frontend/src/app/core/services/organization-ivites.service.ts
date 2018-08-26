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

  getByLink(link: string): Observable<OrganizationInvite> {
    return this.apiService.get(`/${this.ctrlUrl}/${link}`);
  }

  create(organizationInvite: OrganizationInvite): Observable<OrganizationInvite> {
    return this.apiService.post(`/${this.ctrlUrl}`, organizationInvite);
  }

  createdAndSend(organizationInvite: OrganizationInvite): Observable<OrganizationInvite> {
    return this.apiService.post(`/${this.ctrlUrl}/CreatedAndSend`, organizationInvite);
  }

  update(id: number, organization: OrganizationInvite): Observable<boolean> {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, organization);
  }

/*   delete(id: number): Observable<boolean> {
    return this.apiService.delete(`/${this.ctrlUrl}/${id}`);
  } */
}
