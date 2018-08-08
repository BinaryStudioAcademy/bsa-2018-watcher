import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from '../../../../node_modules/rxjs';
import { UserModel } from '../../shared/models/user.model';
import { PostInfo } from '../../shared/models/post-info';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private headers: HttpHeaders;
  private accessPointUrl = 'http://localhost:51093/api/users';

  constructor(private http: HttpClient) { }

  public create(postInfo: PostInfo) {
    return this.http.post(this.accessPointUrl + '/login' , postInfo.user,
     {headers: new HttpHeaders({'Content-Type': 'application/json; charset=utf-8', 'Authorization': `Bearer ${postInfo.token}`})});
  }

}
