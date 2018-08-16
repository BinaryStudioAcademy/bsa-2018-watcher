import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../../shared/models/user.model';
import {ApiService} from './api.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private readonly ctrlUrl = 'Users';

  constructor(private apiService: ApiService) { }

  public update(id: string, user: User): Observable<Object> {
    return this.apiService.put(`/${this.ctrlUrl}/${id}`, user);
  }

  public get(id: string): Observable<User> {
    return this.apiService.get(`/${this.ctrlUrl}/${id}`) as Observable<User>;
  }

  public updateLastPickedOrganization(userId: string, organizationId: number): Observable<Object> {
    return this.apiService.put(`/${this.ctrlUrl}/UpdateLastPickedOrganization/${userId}/${organizationId}`);
  }
}
