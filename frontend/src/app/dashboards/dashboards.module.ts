import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { DashboardComponent } from './dashboard/dashboard.component';
import { InstanceListComponent } from './instance-list/instance-list.component';
import { TabViewModule, PanelMenuModule, DialogModule, ButtonModule, TabMenuModule, ProgressSpinnerModule } from 'primeng/primeng';
import { EditDashboardComponent } from './editDashboard/editDashboard.component';
import { FormsModule } from '@angular/forms';
import { ToastModule } from 'primeng/toast';
import {LineChartComponent} from './01_line_chart/line-chart.component';

@NgModule({
  imports: [
    CommonModule,
    TabViewModule,
    PanelMenuModule,
    ButtonModule,
    DialogModule,
    FormsModule,
    TabMenuModule,
    ConfirmDialogModule,
    ProgressSpinnerModule,
    ToastModule
  ],
  declarations: [DashboardComponent, InstanceListComponent, EditDashboardComponent, LineChartComponent],
  exports: [ DashboardComponent, InstanceListComponent, LineChartComponent ]
})
export class DashboardsModule { }
