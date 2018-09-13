import { UserOrganization } from '../../shared/models/user-organization.model';
import { environment } from '../../../environments/environment';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { OrganizationRole } from '../../shared/models/organization-role.model';
import { AuthService } from './auth.service';
import { User } from '../../shared/models/user.model';

@Injectable()
export class UserOrganizationService {
  ctrlUrl = environment.server_url + '/UserOrganization';

  constructor(private http: HttpClient,
  private authService: AuthService) {
  }

  getAll(): Observable<UserOrganization[]> {
    return this.http.get<UserOrganization[]>(this.ctrlUrl);
  }

  create(entity: UserOrganization) {
    return this.http.post<UserOrganization>(`${this.ctrlUrl}`, entity);
  }

  delete(companyId: number, userId: string) {
    return this.http.delete(`${this.ctrlUrl}/?companyId=${companyId}&userId=${userId}`);
  }

  getByOrganizationId(id: number): Observable<UserOrganization[]> {
    return this.http.get<UserOrganization[]>(`${this.ctrlUrl}/${id}`);
  }

  update(entity: UserOrganization) {
    return this.http.put(this.ctrlUrl, entity);
  }

  private getUserOrganizationRole(userId: string, organizationId: number): Observable<OrganizationRole> {
    return this.http.get<OrganizationRole>(`${this.ctrlUrl}/user/${userId}/organization/${organizationId}`);
  }

  getOrganizationRole(): Promise<OrganizationRole> {
    const user: User = this.authService.getCurrentUserLS();
    if (!user) { return null; }
    return this.getUserOrganizationRole(user.id, user.lastPickedOrganizationId).toPromise();
  }

  async isOrganizationManager(): Promise<boolean> {
    const role = await this.getOrganizationRole();
    return role.name === 'Manager';
  }
}
