import { Component, OnInit, OnDestroy } from '@angular/core';
import { DefaultService } from '../core/services/default.service';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.sass',
  './landing.component.cards.sass',
  './landing.component.footer.sass',
  './landing.component.header.sass'],
})
export class LandingComponent implements OnInit, OnDestroy {

  constructor(private defaultService: DefaultService) {}

  headerScroll(): any {
    const scrolled = window.pageYOffset || document.documentElement.scrollTop;
    if (scrolled < 100) {
      document.getElementById('header').style.background = 'rgba(0,0,0,0.2)';
    } else { document.getElementById('header').style.background = 'rgba(0,0,0,0.8)'; }}

  scrollTo(id: string) {
    const element = document.getElementById(id);
    element.scrollIntoView( {block: 'start', behavior: 'smooth'});
    const menu = document.getElementById('nav');
    if (menu.style.display === 'block') {
      this.show();
    }
  }
  show() {
    const menu = document.getElementById('nav');
    if (menu.style.visibility === 'visible') {
      menu.style.visibility = 'hidden'; } else { menu.style.visibility = 'visible'; }
  }

  resize() {
    if (window.innerWidth > 730) {document.getElementById('nav').style.visibility = 'visible'; }
  }
  ngOnInit() {
    window.addEventListener('resize', this.resize, true);
    window.addEventListener('scroll', this.headerScroll, true);
  }
  ngOnDestroy() {
    window.removeEventListener('scroll', this.headerScroll, true);
    window.removeEventListener('resize', this.resize, true);

}
}
