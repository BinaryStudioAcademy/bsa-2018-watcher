import {Component, Input, EventEmitter, Output, OnChanges} from '@angular/core';
import {DashboardChart} from '../../models/dashboard-chart';
import {ChartService} from '../../../core/services/chart.service';
import {ToastrService} from '../../../core/services/toastr.service';

@Component({
  selector: 'app-chart-dashboard',
  templateUrl: './chart-dashboard.component.html',
  styleUrls: ['./chart-dashboard.component.sass']
})
export class ChartDashboardComponent implements OnChanges {
  charts: DashboardChart[] = [];

  @Input() dashboardCharts: DashboardChart[] = [];
  @Input() dashboardId: number;
  @Input() isManager: boolean;
  @Output() editChart = new EventEmitter<DashboardChart>();
  @Output() deleteChart = new EventEmitter<number>();

  constructor(private chartService: ChartService, private toastrService: ToastrService) {}

  ngOnChanges(changes) {
    const { dashboardCharts } = changes;
    this.charts = (dashboardCharts && dashboardCharts.currentValue) ? this.mapMenu(this.dashboardCharts) : [];
  }

  mapMenu(charts: DashboardChart[]) {
    return charts.map(chart => Object.assign({}, chart, {
      chartMenu: this.getItems(chart)
    }));
  }

  getItems(chart: DashboardChart) {
    return [{
      label: 'Edit',
      icon: 'fa fa-fw fa-edit',
      command: () => {
        this.edit(chart);
      },
    }, {
      label: 'Delete',
      icon: 'fa fa-fw fa-remove',
      command: () => {
        this.delete(chart.id);
      }
    }];
  }

  edit(chart: DashboardChart) {
    this.editChart.emit(chart);
  }

  async delete(id: number): Promise<void> {
    if (await this.toastrService.confirm('You sure you want to delete chart?')) {
      this.chartService.delete(id).subscribe(
        (value) => {
          this.deleteChart.emit(id);
        },
        error => {
          this.toastrService.error(`Error occurred status: ${error.message}`);
        });
    }
  }
}
