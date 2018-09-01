import { Component, OnInit, Input } from '@angular/core';
import {DashboardChart} from '../../models/dashboard-chart';

@Component({
  selector: 'app-chart-dashboard',
  templateUrl: './chart-dashboard.component.html',
  styleUrls: ['./chart-dashboard.component.sass']
})
export class ChartDashboardComponent implements OnInit {
  @Input() charts: DashboardChart[] = [];

  constructor() { }

  ngOnInit() {
  }
}
