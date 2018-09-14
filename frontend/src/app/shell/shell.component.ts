import {Component, OnInit} from '@angular/core';
import {Router, RouterEvent} from '@angular/router';
import { OrganizationService } from '../core/services/organization.service';
import { AuthService } from '../core/services/auth.service';
import { ThemeService } from '../core/services/theme.service';

@Component({
  selector: 'app-shell',
  templateUrl: './shell.component.html',
  styleUrls: ['./shell.component.sass']
})

export class ShellComponent implements OnInit {
  constructor(private router: Router,
    private organizationService: OrganizationService,
    private authService: AuthService,
    private themeService: ThemeService) {  }

  private regexInstances: RegExp = /\/user\/instances/;
  showInstanceList: boolean;

  ngOnInit(): void {

    this.checkRoute();
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
