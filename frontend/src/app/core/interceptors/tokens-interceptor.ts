import {Injectable} from '@angular/core';
import {HttpEvent, HttpHandler, HttpInterceptor, HttpRequest} from '@angular/common/http';
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
    const fbToken = this.auth.getFirebaseToken();
    const watcherToken = this.auth.getWatcherToken();

    if (fbToken) {
      this.headersConfig['Authorization'] = `Bearer ${fbToken}`;
    }
    if (watcherToken) {
      this.headersConfig['WatcherAuthorization'] = fbToken;
    }

    const request = req.clone({setHeaders: this.headersConfig, responseType: 'json'});

    return next.handle(request);
  }
}
