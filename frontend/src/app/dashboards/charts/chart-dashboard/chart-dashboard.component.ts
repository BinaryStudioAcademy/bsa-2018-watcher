import {Component, OnInit, Input, EventEmitter, Output} from '@angular/core';
import {DashboardChart} from '../../models/dashboard-chart';
import {applyDrag} from './utils';
import {ChartService} from '../../../core/services/chart.service';
import {ToastrService} from '../../../core/services/toastr.service';

@Component({
  selector: 'app-chart-dashboard',
  templateUrl: './chart-dashboard.component.html',
  styleUrls: ['./chart-dashboard.component.sass']
})
export class ChartDashboardComponent implements OnInit {
  @Input() charts: DashboardChart[] = [];
  @Input() dashboardId: number;
  @Output() editChart = new EventEmitter<DashboardChart>();
  @Output() deleteChart = new EventEmitter<number>();

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

  edit(chart: DashboardChart) {
    this.editChart.emit(chart);
  }

  onDeleteChart(id: number) {
    this.chartService.delete(id).subscribe(
      (value) => {
        this.deleteChart.emit(id);
      },
      error => {
        this.toastrService.error(`Error occurred status: ${error.message}`);
      });
  }

  async delete(id: number): Promise<void> {
    if (await this.toastrService.confirm('You sure you want to delete chart?')) {
      this.onDeleteChart(id);
    }
  }
}
