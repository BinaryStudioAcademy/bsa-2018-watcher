import { Injectable } from '@angular/core';
import {ApiService} from './api.service';
import {Observable} from 'rxjs';
import {UserRegisterRequest} from '../../shared/models/user-register-request';
import {Token} from '../../shared/models/token.model';
import {UserLoginRequest} from '../../shared/models/user-login-request';

@Injectable({
  providedIn: 'root'
})
export class TokenService {
  public readonly ctrlUrl = 'Tokens';

  constructor(private apiService: ApiService) { }

  getUserByTokens(): Observable<Token> {
    return this.apiService.get(`/${this.ctrlUrl}/User`);
  }

  getUserClaims(): Observable<any> {
    return this.apiService.get(`/${this.ctrlUrl}/Claims`);
  }

  register(request: UserRegisterRequest): Observable<Token>  {
    return this.apiService.post(`/${this.ctrlUrl}/Register`, request);
  }

  login(request: UserLoginRequest): Observable<Token>  {
    const req = this.apiService.post(`/${this.ctrlUrl}/Login`, request);
    return req;
  }
}
