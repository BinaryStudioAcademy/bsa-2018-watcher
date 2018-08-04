import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-dashboard-header',
  templateUrl: './dashboard-header.component.html',
  styleUrls: ['./dashboard-header.component.sass']
})
export class DashboardHeaderComponent implements OnInit {

  @Input()menu:any;

  constructor() { }

  ngOnInit() {
  }

}
