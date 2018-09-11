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

    const style = document.createElement('style');
    style.setAttribute('type', 'text/css');
    const styleText = document.createTextNode(`
      body {
        background-color: ${theme.bodyColor};
      };

      .header {
        background-color: ${theme.themeSecondaryColor};
      }

      .header button:hover {
        color: #F56C00 !important;
        background-color: transparent !important;
        border-color: transparent !important;
      }

      .ui-tabmenuitem #lastTab .ui-menuitem-icon {
        color: ${theme.themePrimaryColor};
      }

      .ui-tabmenuitem #lastTab .ui-menuitem-icon:hover {
        color: ${theme.themeSecondaryColor};
      }

      input {
        height: ${theme.controlsHeight};
      }

      .logo, .logo:hover{
        background-color: transparent !important;
        color: ${theme.themeSecondaryColor} !important;
      }`);

      style.appendChild(styleText);

      head.appendChild(style);
  }
}
