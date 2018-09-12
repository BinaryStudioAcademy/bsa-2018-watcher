import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Theme } from '../../shared/models/theme.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ThemeService {

  private readonly ctrlUrl = 'Themes';

  constructor(private apiService: ApiService) { }

  public getAll(): Observable<Theme[]> {
    return this.apiService.get(`/${this.ctrlUrl}/`) as Observable<Theme[]>;
  }

  public applyTheme(theme: Theme) {

    const cssUrl = `/assets/themes/${theme.name}.css`;

    this.deleteThemeTags();

    const head = document.head;

    const link = document.createElement('link');
    link.type = 'text/css';

    link.setAttribute('id', 'themeLink');
    link.setAttribute('href', cssUrl);
    link.setAttribute('rel', 'stylesheet');

    head.appendChild(link);

    const style = document.createElement('style');
    style.setAttribute('id', 'themeStyle');
    style.setAttribute('type', 'text/css');
    const styleText = document.createTextNode(`
      body {
        background-color: ${theme.bodyColor};
      };

      .header {
        background-color: ${theme.themeSecondaryColor};
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

  public setDefaultTheme() {
    this.deleteThemeTags();
  }

  private deleteThemeTags() {
    const themeLink: HTMLElement = document.getElementById('themeLink');
    if (themeLink) {
      document.head.removeChild(themeLink);
    }

    const themeStyle: HTMLElement = document.getElementById('themeStyle');
    if (themeStyle) {
      document.head.removeChild(themeStyle);
    }
  }
}
