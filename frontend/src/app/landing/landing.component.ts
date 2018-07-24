import { Component, OnInit } from '@angular/core';
import { DefaultService } from '../core/services/default.service';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.sass']
})
export class LandingComponent implements OnInit {
  public values: Array<string>;

  constructor(private defaultService: DefaultService) {}

  ngOnInit() {
    this.defaultService.getDefaultData().subscribe((values) => {
      this.values = values;
    });
  }
}
