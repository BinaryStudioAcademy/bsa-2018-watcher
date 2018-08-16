import {Component, OnInit} from '@angular/core';
import {AuthService} from './core/services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})

export class AppComponent implements OnInit {
  constructor(private authService: AuthService) {
  }

  async ngOnInit() {
    if (!this.authService.isAuthorized()) {
    await this.authService.populate();
    }

  }
}
