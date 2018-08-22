import {Component, OnInit} from '@angular/core';
import {AuthService} from '../core/services/auth.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-shell',
  templateUrl: './shell.component.html',
  styleUrls: ['./shell.component.sass']
})

export class ShellComponent implements OnInit {
  constructor(private authService: AuthService,
              private router: Router) {  }

  ngOnInit(): void {
   // this.authService.getCurrentUser().
  }
}
