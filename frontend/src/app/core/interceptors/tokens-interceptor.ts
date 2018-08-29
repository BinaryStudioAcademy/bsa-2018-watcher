import {Injectable} from '@angular/core';
import {HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, HttpErrorResponse, HttpResponse} from '@angular/common/http';
import {AuthService} from '../services/auth.service';
import {Observable} from 'rxjs';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class TokensInterceptor implements HttpInterceptor {
  headersConfig = {
    'Content-Type': 'application/json; charset=utf-8',
    'Accept': 'application/json'
  };

  constructor(public auth: AuthService) {
  }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    const firebaseToken = this.auth.getFirebaseToken();
    const watcherToken = this.auth.getWatcherToken();

    if (firebaseToken) {
      this.headersConfig['Authorization'] = `Bearer ${firebaseToken}`;
    }
    if (watcherToken) {
      this.headersConfig['WatcherAuthorization'] = watcherToken;
    }

    const request = req.clone({setHeaders: this.headersConfig, responseType: 'json'});

    return next.handle(request).pipe(tap(
      (event: HttpEvent<any>) => {
        if (event instanceof HttpResponse) {
          console.log('INTERCEPTOR WITHOUT ERROR');
        }
      },
      (error: any) => {
      if (error instanceof HttpErrorResponse) {
        if (error.status === 401) {
          console.log('401 CAUGHT IN INTERCEPTOR, REFRESHING TOKEN');
         this.auth.refreshToken();
        }
      }
    }) );
  }
}
