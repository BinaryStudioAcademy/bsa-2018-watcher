import { Component, OnInit } from '@angular/core';
import {AuthService} from '../core/services/auth.service';

@Component({
  selector: 'app-shell',
  templateUrl: './shell.component.html',
  styleUrls: ['./shell.component.sass']
})
export class ShellComponent implements OnInit {
  constructor (private authService: AuthService) {
    this.authService.populate().then(value => this.authService.currentUser.subscribe());
  }

   ngOnInit() {
    // await this.authService.populate();
  }
}
