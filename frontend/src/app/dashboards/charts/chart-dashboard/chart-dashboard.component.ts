import { Component, OnInit, Input } from '@angular/core';
import { DashboardChart } from '../../models/dashboard-chart';
import { ContainerComponent, DraggableComponent } from 'ngx-smooth-dnd';
import { applyDrag, generateItems } from './utils';
import { ChartService } from '../../../core/services/chart.service';
import { ToastrService } from '../../../core/services/toastr.service';

@Component({
  selector: 'app-chart-dashboard',
  templateUrl: './chart-dashboard.component.html',
  styleUrls: ['./chart-dashboard.component.sass']
})
export class ChartDashboardComponent implements OnInit {
  @Input() charts: DashboardChart[] = [];

  displayEditChart = false;

  constructor(private chartService: ChartService, private toastrService: ToastrService) {
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

  onChartEditClosed() {
    this.displayEditChart = false;
  }

  showPopupAddChart() {
    this.displayEditChart = true;
  }

  onChartEdited(obj?: any) {
    // this.toastrService.success('Successfully update chart!');
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
