import {Injectable} from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders, HttpParams} from '@angular/common/http';
import {Observable, throwError} from 'rxjs';
import {catchError, map} from 'rxjs/operators';
import {environment} from '../../../environments/environment';

const httpOptions = {
  headers: new HttpHeaders({'Content-Type': 'application/json',
                                   'Accept': 'application/json'}),
};

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  constructor(private http: HttpClient) { }

  public get(path: string, params: HttpParams = new HttpParams()): Observable<any> {
    const url = `${environment.server_url}${path}`;
    return this.http.get(url, {params})
      .pipe(map(this.extractData),
            catchError(this.handleError));
  }

  getById(path: string, id: any): Observable<any> {
    const url = `${environment.server_url}${path}/${id}`;
    return this.http.get(url, httpOptions)
      .pipe(
          map(this.extractData),
          catchError(this.handleError));
  }

  public put(path: string, body: Object = {}): Observable<any> {
    const url = `${environment.server_url}${path}`;
    return this.http.put(url, body, httpOptions)
      .pipe(
          catchError(this.handleError)
      );
  }

  public post(path: string, body: Object = {}): Observable<any> {
    return this.http.post(`${environment.server_url}${path}`, body, httpOptions)
      .pipe(
          map(this.extractData),
          catchError(this.handleError));
  }

  public delete(path): Observable<any> {
    return this.http.delete(`${environment.server_url}${path}`, httpOptions)
      .pipe(
          catchError(this.handleError)
      );
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error.message);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      console.error(
        `Backend returned code ${error.status}, ` +
        `body was: ${error.error}`);
    }
    // return an observable with a user-facing error message
    return throwError(error.error);
  }

  private extractData(res: Response) {
    return res || { };
  }
}
