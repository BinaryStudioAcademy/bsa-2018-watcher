import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from '../../../../node_modules/rxjs';
import { UserModel } from '../../shared/models/user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private headers: HttpHeaders;
  private accessPointUrl = 'http://localhost:51880/api/users/';

 // this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8', 'Authorization': `Bearer ${authtoken}`});

  constructor(private http: HttpClient) { }

  public create(postInfo) {
    debugger;
    console.log(postInfo);

    // return this.http.post(this.accessPointUrl , postInfo['0'],
    //  {headers: new HttpHeaders({'Content-Type': 'application/json; charset=utf-8', 'Authorization': `Bearer ${postInfo['1']}`})});
  }

}
