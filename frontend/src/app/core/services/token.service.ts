import { Injectable } from '@angular/core';
import {ApiService} from './api.service';
import {Observable} from 'rxjs';
import {UserRegisterRequest} from '../../shared/models/user-register-request';
import {Token} from '../../shared/models/token.model';
import {UserLoginRequest} from '../../shared/models/user-login-request';
import {User} from '../../shared/models/user.model';

@Injectable({
  providedIn: 'root'
})
export class TokenService {
  private readonly ctrlUrl = 'Tokens';

  constructor(private apiService: ApiService) { }

  getUserByTokens(): Observable<Token> {
    return this.apiService.get(`/${this.ctrlUrl}/User`);
  }

  register(request: UserRegisterRequest): Observable<Token>  {
    return this.apiService.post(`/${this.ctrlUrl}/Register`, request);
  }

  login(request: UserLoginRequest): Observable<Token>  {
    return this.apiService.post(`/${this.ctrlUrl}/Login`, request);
  }
}
