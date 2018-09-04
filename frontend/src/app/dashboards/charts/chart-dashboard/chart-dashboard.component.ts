import {Component, OnInit, Input, EventEmitter, Output} from '@angular/core';
import {DashboardChart} from '../../models/dashboard-chart';
import {applyDrag} from './utils';
import {ChartService} from '../../../core/services/chart.service';
import {ToastrService} from '../../../core/services/toastr.service';
import { MenuItem } from 'primeng/api';

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

  }
/*this.getChildPayload1 = this.getChildPayload1.bind(this);
  onDrop(collection, dropResult) {
    this[collection] = applyDrag(this[collection], dropResult);
  }

  getChildPayload1(index) {
    return this.charts[index];
  }*/

  items: MenuItem[];

  ngOnInit() {
    this.items = [
      {
        label: 'Edit',
        icon: 'fa fa-fw fa-edit',
        command: (event) => console.log(),
      },
      {
        label: 'Delete',
        icon: 'fa fa-fw fa-remove',
        command: (event) => console.log()
      }
    ];
  }

  onClickMenu(chart: DashboardChart) {
    this.items = [
      {
        label: 'Edit',
        icon: 'fa fa-fw fa-edit',
        command: () => this.edit(chart),
      },
      {
        label: 'Delete',
        icon: 'fa fa-fw fa-remove',
        command: () => this.delete(chart.id)
      }
    ];
  }

  getItems(chart: DashboardChart) {
    const items: MenuItem[] = [
      {
        label: 'Edit',
        icon: 'fa fa-fw fa-edit',
        command: () => this.edit(chart),
      },
      {
        label: 'Delete',
        icon: 'fa fa-fw fa-remove',
        command: () => this.delete(chart.id)
      }
    ];

    return items;
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
