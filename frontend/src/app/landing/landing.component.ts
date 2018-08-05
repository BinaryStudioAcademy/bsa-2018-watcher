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
    } else { document.getElementById('header').style.background = 'rgba(0,0,0,0.8)'; }

    const dw_getScrollOffsets = () => {
      const doc = document, w = window;
      let y, docEl;
            if (typeof w.pageYOffset === 'number') {
              y = w.pageYOffset; } else {
                  docEl = (doc.compatMode && doc.compatMode === 'CSS1Compat') ?
                  doc.documentElement : doc.body;
                  y = docEl.scrollTop;
                }
            return y;
  }; }
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
    if (menu.style.display === 'block') {
      menu.style.display = 'none'; } else { menu.style.display = 'block'; }
  }

  ngOnInit() {
    window.addEventListener('scroll', this.headerScroll, true);
  }
  ngOnDestroy() {
    window.removeEventListener('scroll', this.headerScroll, true);
}
}
