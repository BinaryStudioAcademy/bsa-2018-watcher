import { Component, OnInit } from '@angular/core';
import { DefaultService } from '../core/services/default.service';
import {ButtonModule} from 'primeng/button';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.sass','./landing.component.cards.sass','./landing.component.footer.sass'],
})
export class LandingComponent implements OnInit {
  
  headerScroll(): any {
    var scrolled = window.pageYOffset || document.documentElement.scrollTop;
    if (scrolled < 100)
      document.getElementById("header").style.background = "rgba(0,0,0,0.2)";
    else document.getElementById("header").style.background = "rgba(0,0,0,0.8)";

    const dw_getScrollOffsets = ()=> {
      let doc = document, w = window;
      let y, docEl;
            if (typeof w.pageYOffset === 'number') y = w.pageYOffset;
            else {
                  docEl = (doc.compatMode && doc.compatMode === 'CSS1Compat') ?
                  doc.documentElement : doc.body;
                  y = docEl.scrollTop;
                }
            return y
  }}
  
  scrollTo(id:string)
  {
    console.log(id);
    const element = document.getElementById(id);
    console.log(element);
    element.scrollIntoView( {block: "start",behavior:"smooth"});
  }

  constructor(private defaultService: DefaultService) {}

  ngOnInit() {
    window.addEventListener('scroll', this.headerScroll, true); 
  }
  ngOnDestroy() {
    window.removeEventListener('scroll', this.headerScroll, true);
}
}
