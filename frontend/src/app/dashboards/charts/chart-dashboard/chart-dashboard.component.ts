import { Component, OnInit, Input } from '@angular/core';
import { CustomChart} from '../models';

@Component({
  selector: 'app-chart-dashboard',
  templateUrl: './chart-dashboard.component.html',
  styleUrls: ['./chart-dashboard.component.sass']
})
export class ChartDashboardComponent implements OnInit {
  @Input() charts: CustomChart[] = [];

  constructor() { }

  ngOnInit() {
  }
}
