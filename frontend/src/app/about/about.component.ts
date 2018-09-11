import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.sass']
})
export class AboutComponent implements OnInit {
  constructor(private activatedRoute: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    window.scrollTo(0, 0);
  }

  goToLink(section: string): void {
    this.router.navigate(['/', section]);
  }
}
