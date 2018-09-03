import {Component, OnInit, Input, EventEmitter, Output} from '@angular/core';
import { DashboardChart } from '../../models/dashboard-chart';
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
  @Input() dashboardId: number;
  @Output() editChart = new EventEmitter<DashboardChart>();

  displayEditChart = false;

  chartToEdit: DashboardChart; // = { ...defaultOptions };

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

  edit(chart: DashboardChart) {
    this.editChart.emit(chart);
    this.displayEditChart = true;
  }

  onChartEdited(obj?: any) {
    // this.toastrService.success('Successfully update chart!');
  }

  onEditChart(chart) {

  }

  onDeleteChart(id: number) {
    console.log(id);

    this.chartService.delete(id).subscribe(
      value => {
        this.toastrService.success('The chart was deleted');
      },
      error => {
        this.toastrService.error(`Error ocured status: ${error.message}`);
      });
  }
}
