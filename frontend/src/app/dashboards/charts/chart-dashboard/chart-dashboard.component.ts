import {Component, Input, EventEmitter, Output} from '@angular/core';
import {MenuItem} from 'primeng/api';

import {DashboardChart} from '../../models/dashboard-chart';
import {ChartService} from '../../../core/services/chart.service';
import {ToastrService} from '../../../core/services/toastr.service';

@Component({
  selector: 'app-chart-dashboard',
  templateUrl: './chart-dashboard.component.html',
  styleUrls: ['./chart-dashboard.component.sass']
})
export class ChartDashboardComponent {

  @Input() dashboardCharts: DashboardChart[] = [];
  @Input() dashboardId: number;
  @Input() isManager: boolean;

  @Output() editChart = new EventEmitter<DashboardChart>();
  @Output() deleteChart = new EventEmitter<number>();

  currentChartMenu: MenuItem[] = [];

  constructor(
    private chartService: ChartService,
    private toastrService: ToastrService) {}

  createMenu(chart: DashboardChart) {
    this.currentChartMenu = [{
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
