import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class DefaultService {

  constructor(private http: HttpClient) {

  }

  getDefaultData() {
    return this.http.get<any>('/api/default')
      .pipe(
        map(response => {
          return response;
        })
      );
  }
}
