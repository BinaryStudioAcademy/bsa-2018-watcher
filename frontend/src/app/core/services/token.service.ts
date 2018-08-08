import { Injectable } from '@angular/core';
import {ApiService} from '../../shared/services/api.service';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TokenService {
  private readonly ctrlUrl = 'Tokens';

  constructor(private apiService: ApiService) { }

  login(): Observable<any> {
    return this.apiService.get(`/${this.ctrlUrl}/Login`);
  }

  register(): Observable<any>  {
    return this.apiService.get(`/${this.ctrlUrl}/Register`);
  }
}
