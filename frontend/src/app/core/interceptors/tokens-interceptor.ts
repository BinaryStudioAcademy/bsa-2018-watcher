import {Injectable} from '@angular/core';
import {HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, HttpErrorResponse, HttpResponse} from '@angular/common/http';
import {AuthService} from '../services/auth.service';
import {Observable, from} from 'rxjs';
import { flatMap } from 'rxjs/operators';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable()
export class TokensInterceptor implements HttpInterceptor {
  headersConfig = {
    'Content-Type': 'application/json; charset=utf-8',
    'Accept': 'application/json'
  };

  UploadFileheadersConfig = {
    'Content-Type': 'multipart/form-data',
    'Accept': 'application/json'
  };

  constructor(public auth: AuthService) {
  }
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    // check for preventing infinite loop while getting new token from backend
      if (req.url.match(/\/Tokens\/Login/)) {
        console.log('Login...');
        return from(this.auth.getFirebaseToken()).pipe(
          flatMap<string[], HttpEvent<any>>((firebaseToken) => {
            let headers = {};
            if (firebaseToken) {
              headers = {
                'Content-Type': 'application/json; charset=utf-8',
                'Accept': 'application/json',
                'Authorization': `Bearer ${firebaseToken}`
              };
            } else {
              headers = this.headersConfig;
            }
            const request = req.clone({setHeaders: headers, responseType: 'json'});
            return next.handle(request);
          }));
      }
      return this.auth.getTokens().pipe(
        flatMap<string[], HttpEvent<any>>(([firebaseToken, watcherToken]) => {
          if (firebaseToken) {
            this.headersConfig['Authorization'] = `Bearer ${firebaseToken}`;
          }
          if (watcherToken) {
            this.headersConfig['WatcherAuthorization'] = watcherToken;
          }

          if (req.url.match(/\/uploadApp/)) {
            const request = req.clone();
            return next.handle(request);
          } else {
            const request = req.clone({setHeaders: this.headersConfig, responseType: 'json'});
            return next.handle(request);
          }
        })
      );
    }
}
