import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from '../../../../node_modules/rxjs';
import { UserModel } from '../../shared/models/user.model';
import { UserUpdate } from '../../shared/models/userUpdate';
import { User } from '../../shared/models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private headers: HttpHeaders;
  private accessPointUrl = 'http://localhost:51880/api/users/';

 // this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8', 'Authorization': `Bearer ${authtoken}`});

  constructor(private http: HttpClient) { }

  public create(postInfo) {
    console.log(postInfo);

    // return this.http.post(this.accessPointUrl , postInfo['0'],
    //  {headers: new HttpHeaders({'Content-Type': 'application/json; charset=utf-8', 'Authorization': `Bearer ${postInfo['1']}`})});
  }

  public update(id: string, user: UserUpdate) {
    this.http.put(`${this.accessPointUrl}${id}`, user).subscribe();
  }

  public get(id: string): Observable<User> {
    return this.http.get(`${this.accessPointUrl}${id}`) as Observable<User>;
  }

}
