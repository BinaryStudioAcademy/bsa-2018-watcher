import {Injectable} from '@angular/core';
import {HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, HttpErrorResponse, HttpResponse} from '@angular/common/http';
import {AuthService} from '../services/auth.service';
import {Observable} from 'rxjs';
import { flatMap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class TokensInterceptor implements HttpInterceptor {
  headersConfig = {
    'Content-Type': 'application/json; charset=utf-8',
    'Accept': 'application/json'
  };

  constructor(public auth: AuthService) {
    console.log('INTERCEPT CONSTRUCTOR CALLED');
  }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    // first firebase token, then watcher
    return this.auth.getTokens().pipe(
      flatMap<string[], HttpEvent<any>>(([firebaseToken, watcherToken]) => {
        this.headersConfig['Authorization'] = `Bearer ${firebaseToken}`;
        this.headersConfig['WatcherAuthorization'] = watcherToken;

        const request = req.clone({setHeaders: this.headersConfig, responseType: 'json'});
        return next.handle(request);
      })
    );
  }
}
