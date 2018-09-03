import {Component, OnInit} from '@angular/core';
import {AuthService} from '../core/services/auth.service';
import {Router, RouterEvent} from '@angular/router';

@Component({
  selector: 'app-shell',
  templateUrl: './shell.component.html',
  styleUrls: ['./shell.component.sass']
})

export class ShellComponent implements OnInit {
  constructor(private router: Router) {  }

  private regexInstances: RegExp = /\/user\/instances/;
  private showInstanceList: boolean;

  ngOnInit(): void {
    this.showInstanceList = true;
    this.subscribeRouteChanges();
  }

  private subscribeRouteChanges(): void {
    this.router.events.subscribe((event: RouterEvent) => {
      this.checkRoute();
    });
  }

  private checkRoute(): void {
    this.showInstanceList = (this.router.url.match(this.regexInstances)) ? true : false;
  }
}
