import { Injectable } from '@angular/core';
import {ApiService} from '../../shared/services/api.service';
import {Observable} from 'rxjs';
import {PostInfo} from '../../shared/models/post-info';
import {HttpHeaders, HttpParams} from '@angular/common/http';
import {environment} from '../../../environments/environment';
import {catchError, map} from 'rxjs/operators';
import {TokenDto} from '../../shared/models/token-dto';

@Injectable({
  providedIn: 'root'
})
export class TokenService {
  private readonly ctrlUrl = 'Tokens';

  constructor(private apiService: ApiService) { }

  // login(postInfo: PostInfo): void {
  //   return this.apiService.post(`/${this.ctrlUrl}/Login`, postInfo)
  //     .subscribe(value => {
  //       localStorage.setItem('tokenDto', JSON.stringify(value));
  //     });
  // }

  register(postInfo: PostInfo): Observable<TokenDto>  {
    // const headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8', 'Authorization': `Bearer ${postInfo.token}`});
    return this.apiService.post(`/${this.ctrlUrl}/Register`, postInfo.user);
  }
}
