import { Component, OnInit } from '@angular/core';
import { DefaultService } from '../core/services/default.service';
import {ButtonModule} from 'primeng/button';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.sass'],
})
export class LandingComponent implements OnInit {
  

  constructor(private defaultService: DefaultService) {}

  ngOnInit() {
  }
}
