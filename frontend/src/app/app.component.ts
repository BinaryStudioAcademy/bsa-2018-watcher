import {Component, OnInit} from '@angular/core';
import {AuthService} from './core/services/auth.service';
import { ThemeService } from './core/services/theme.service';
import { DomSanitizer } from 'node_modules/@angular/platform-browser';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})

export class AppComponent implements OnInit {
  public cssUrl: string;

  constructor(private authService: AuthService, private themeService: ThemeService, public sanitizer: DomSanitizer) {
  }

  async ngOnInit() {
    if (!this.authService.isAuthorized()) {
      await this.authService.populate();
    }

    const user =  this.authService.getCurrentUserLS();

    this.cssUrl = this.themeService.applyTheme(user);

  }
}
