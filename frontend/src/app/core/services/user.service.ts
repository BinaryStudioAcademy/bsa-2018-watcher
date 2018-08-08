import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from '../../../../node_modules/rxjs';
import { UserModel } from '../../shared/models/user.model';
import { User } from '../../shared/models/user';
import { PostInfo } from '../../shared/models/post-info';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private headers: HttpHeaders;
  private accessPointUrl = 'http://localhost:51880/api/users';

  constructor(private http: HttpClient) { }

  public create(postInfo: PostInfo) {
    return this.http.post(this.accessPointUrl + '/login' , postInfo.user,
     {headers: new HttpHeaders({'Content-Type': 'application/json; charset=utf-8', 'Authorization': `Bearer ${postInfo.token}`})});
  }

  public update(id: string, user: User) {
    this.http.put(`${this.accessPointUrl}${id}`, user).subscribe();
  }

  public get(id: string): Observable<User> {
    return this.http.get(`${this.accessPointUrl}${id}`) as Observable<User>;
  }

}
