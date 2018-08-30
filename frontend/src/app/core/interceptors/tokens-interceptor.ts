import {Injectable} from '@angular/core';
import {HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, HttpErrorResponse, HttpResponse} from '@angular/common/http';
import {AuthService} from '../services/auth.service';
import {Observable} from 'rxjs';

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
      if (firebaseToken) {
        this.headersConfig['Authorization'] = `Bearer ${firebaseToken}`;
      }

    const watcherToken = this.auth.getWatcherToken();
      if (watcherToken) {
        this.headersConfig['WatcherAuthorization'] = watcherToken;
      }

    const request = req.clone({setHeaders: this.headersConfig, responseType: 'json'});

    return next.handle(request);
  }
}
