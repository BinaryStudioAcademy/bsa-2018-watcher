import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Theme } from '../../shared/models/theme.model';
import { Observable } from 'rxjs';
import { User } from '../../shared/models/user.model';
import { DomSanitizer } from '../../../../node_modules/@angular/platform-browser';


@Injectable({
  providedIn: 'root'
})
export class ThemeService {

  private readonly ctrlUrl = 'Themes';


  constructor(private apiService: ApiService, public sanitizer: DomSanitizer) { }

  public getAll(): Observable<Theme[]> {
    return this.apiService.get(`/${this.ctrlUrl}/`) as Observable<Theme[]>;
  }

  public applyTheme(user: User): string {
    debugger;
    const theme: Theme = user.lastPickedOrganization.theme;

    const head = document.head;

    const link = document.createElement('link');
    link.type = 'text/css';

    link.setAttribute('href', '../../themes/darkness.css');
    link.setAttribute('rel', 'stylesheet');

    head.appendChild(link);

    return '../../themes/darkness.css';

    // const style = document.createElement('style');
    // style.setAttribute('type', 'text/css');
    // const styleText = document.createTextNode(`
    //   body {
    //     background-color: ${theme.bodyColor};
    //   };

    //   .header {
    //     background-color: ${theme.themeSecondaryColor};
    //   }

    //   input {
    //     height: ${theme.controlsHeight};
    //   }

    //   .ui-button {
    //     font-size: ${theme.buttonFontSize};
    //     height: ${theme.controlsHeight};
    //     background-color: ${theme.themePrimaryColor};

    //   }

    //   .logo {
    //     color: ${theme.themePrimaryColor} !important;
    //   }

    //   .logo:hover {
    //     color: ${theme.themePrimaryColor} !important;
    //   }

    //   .ui-panelmenu {
    //     .ui-panelmenu-header.ui-state-active > a {
    //       background-color: ${theme.themePrimaryColor} !important;
    //       border: ${theme.themePrimaryColor} !important;
    //     }
    //   }
    //   `);

    //   style.appendChild(styleText);

    //   head.appendChild(style);

  }
}
