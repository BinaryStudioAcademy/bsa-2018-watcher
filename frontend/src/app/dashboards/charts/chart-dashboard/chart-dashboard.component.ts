import { Component, OnInit, Input } from '@angular/core';
import { DashboardChart } from '../../models/dashboard-chart';
import { ContainerComponent, DraggableComponent } from 'ngx-smooth-dnd';
import { applyDrag, generateItems } from './utils';
import { ChartService } from '../../../core/services/chart.service';

@Component({
  selector: 'app-chart-dashboard',
  templateUrl: './chart-dashboard.component.html',
  styleUrls: ['./chart-dashboard.component.sass']
})
export class ChartDashboardComponent implements OnInit {
  @Input() charts: DashboardChart[] = [];

  constructor(private chartService: ChartService) {
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

  onEditChart(chart: ChartRequest) {
    this.chartService.update(1, chart).subscribe(
      value => {
        this.toastrService.success('The chart was updated');
      },
      error => {
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });
  }

  onDeleteChart(id: number) {
    this.chartService.delete(111).subscribe(
      value => {
        this.toastrService.success('The chart was deleted');
      },
      error => {
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });
  }
}
