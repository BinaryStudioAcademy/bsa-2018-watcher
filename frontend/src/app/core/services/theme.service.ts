import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Theme } from '../../shared/models/theme.model';
import { Observable } from 'rxjs';
import { User } from '../../shared/models/user.model';
import { DomSanitizer } from '../../../../node_modules/@angular/platform-browser';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ThemeService {

  private readonly ctrlUrl = 'Themes';


  constructor(private apiService: ApiService, private http: HttpClient) { }

  public getAll(): Observable<Theme[]> {
    return this.apiService.get(`/${this.ctrlUrl}/`) as Observable<Theme[]>;
  }

  public applyTheme(theme: Theme) {

    const head = document.head;

    const link = document.createElement('link');
    link.type = 'text/css';

    link.setAttribute('href', `/assets/${theme.name}.css`);
    link.setAttribute('rel', 'stylesheet');

    head.appendChild(link);
  }
}
