import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from '../../../../node_modules/rxjs';
import { User } from '../../shared/models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private headers: HttpHeaders;
  private accessPointUrl = 'http://localhost:65246/users';
  private accessTokensPointUrl = 'http://localhost:65246/api/tokens';
  private tokensUrl = 'http://localhost:65246/api/Tokens';


  constructor(private http: HttpClient) { }

  public update(id: string, user: User): Observable<Object> {
    return this.http.put(`${this.accessPointUrl}/${id}`, user);
  }

  public get(id: string): Observable<User> {
    return this.http.get(`${this.accessPointUrl}/${id}`) as Observable<User>;
  }
}
