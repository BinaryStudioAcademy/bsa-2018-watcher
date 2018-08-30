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
    // first firebase token, then watcher
    this.auth.getTokens().subscribe( (tokens: [string, string]) => {
      if (tokens[0]) {
        this.headersConfig['Authorization'] = `Bearer ${tokens[0]}`;
      }
      if (tokens[1]) {
        this.headersConfig['WatcherAuthorization'] = tokens[1];
      }
    });

    const request = req.clone({setHeaders: this.headersConfig, responseType: 'json'});
    return next.handle(request);
  }
}
