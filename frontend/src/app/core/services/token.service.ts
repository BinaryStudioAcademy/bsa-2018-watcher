import { Injectable } from '@angular/core';
import {ApiService} from '../../shared/services/api.service';
import {Observable} from 'rxjs';
import {UserRegisterRequest} from '../../shared/models/user-register-request';
import {HttpHeaders, HttpParams} from '@angular/common/http';
import {environment} from '../../../environments/environment';
import {catchError, map} from 'rxjs/operators';
import {TokenDto} from '../../shared/models/token-dto';
import {UserLoginRequest} from '../../shared/models/user-login-request';

@Injectable({
  providedIn: 'root'
})
export class TokenService {
  private readonly ctrlUrl = 'Tokens';

  constructor(private apiService: ApiService) { }

  register(request: UserRegisterRequest): Observable<TokenDto>  {
    return this.apiService.post(`/${this.ctrlUrl}/Register`, request);
  }

  login(request: UserLoginRequest): Observable<TokenDto>  {
    return this.apiService.post(`/${this.ctrlUrl}/Login`, request);
  }
}
