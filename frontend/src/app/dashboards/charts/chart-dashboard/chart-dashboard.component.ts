import { Component, OnInit, Input } from '@angular/core';
import { DashboardChart } from '../../models/dashboard-chart';
import { ContainerComponent, DraggableComponent } from 'ngx-smooth-dnd';
import { applyDrag, generateItems } from './utils';

@Component({
  selector: 'app-chart-dashboard',
  templateUrl: './chart-dashboard.component.html',
  styleUrls: ['./chart-dashboard.component.sass']
})
export class ChartDashboardComponent implements OnInit {
  @Input() charts: DashboardChart[] = [];

  constructor() {
    this.getChildPayload1 = this.getChildPayload1.bind(this);
  }

  onDrop(collection, dropResult) {
    this[collection] = applyDrag(this[collection], dropResult);
  }

  getChildPayload1(index) {
    return this.charts[index];
  }

  ngOnInit() {
  }
}
