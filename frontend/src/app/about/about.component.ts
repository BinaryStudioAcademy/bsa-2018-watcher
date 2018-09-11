import { Component, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.sass']
})
export class AboutComponent implements OnInit, OnDestroy {
  constructor(private activatedRoute: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    window.scrollTo(0, 0);
    window.addEventListener('resize', this.resize, true);
    window.addEventListener('scroll', this.headerScroll, true);
  }

  goToLink(section: string): void {
    this.router.navigate(['/', section]);
  }

  show(): void {
    const menu = document.getElementById('nav');
    menu.style.visibility = menu.style.visibility === 'visible' ? 'hidden' : 'visible';
  }

  headerScroll(): any {
    const scrolled = window.pageYOffset || document.documentElement.scrollTop;
    document.getElementById('header').style.background = scrolled < 100 ? 'rgba(0,0,0,0.2)' : 'rgba(0,0,0,0.8)';
  }

  resize(): void {
    if (window.innerWidth > 800) {
      document.getElementById('nav').style.visibility = 'visible';
    }
  }

  ngOnDestroy() {
    window.removeEventListener('scroll', this.headerScroll, true);
    window.removeEventListener('resize', this.resize, true);
  }
}
