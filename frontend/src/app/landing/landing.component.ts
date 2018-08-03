import { Component, OnInit } from '@angular/core';
import { DefaultService } from '../core/services/default.service';
import {ButtonModule} from 'primeng/button';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.sass'],
})
export class LandingComponent implements OnInit {
  
  scrollTo(id:string)
  {
    console.log(id);
    const element = document.getElementById(id);
    console.log(element);
    element.scrollIntoView( {block: "start",behavior:"smooth"});
  }
  constructor(private defaultService: DefaultService) {}

  ngOnInit() {
  }
}
