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
  private readonly ctrlUrl = 'Tokens';

  constructor(private apiService: ApiService) { }

  register(request: UserRegisterRequest): Observable<Token>  {
    return this.apiService.post(`/${this.ctrlUrl}/Register`, request);
  }

  login(request: UserLoginRequest): Observable<Token>  {
    return this.apiService.post(`/${this.ctrlUrl}/Login`, request);
  }
}
