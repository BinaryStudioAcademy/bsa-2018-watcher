import { Component, OnInit } from '@angular/core';
import { DefaultService } from '../core/services/default.service';
import {MenuItem } from 'primeng/primeng';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.sass']
})
export class LandingComponent implements OnInit { 
  items: Array<MenuItem>;
  public values: Array<string>;
  
  constructor(private defaultService: DefaultService) {}

  ngOnInit() {
    this.defaultService.getDefaultData().subscribe((values) => {	
      this.values = values;	
    });
  }
}
