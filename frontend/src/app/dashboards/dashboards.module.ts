import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import {
  TabViewModule,
  PanelMenuModule,
  DialogModule,
  DropdownModule,
  CheckboxModule,
  TieredMenuModule,
  MultiSelectModule,
  SliderModule,
  SpinnerModule,
  ButtonModule,
  TabMenuModule,
  ProgressSpinnerModule,
  TooltipModule,
  ScrollPanelModule,
  InputTextModule} from 'primeng/primeng';

import { TableModule } from 'primeng/table';
import { CalendarModule } from 'primeng/calendar';
import { PaginatorModule } from 'primeng/paginator';
import { MessageModule } from 'primeng/message';
import { ToastModule } from 'primeng/toast';
import { ConfirmDialogModule } from 'primeng/confirmdialog';

import { DashboardRoutingModule } from './dashboards-routing.module';
import { NgxChartsModule } from '@swimlane/ngx-charts';
import { NgxUIModule } from '@swimlane/ngx-ui';
import { NgxSmoothDnDModule } from 'ngx-smooth-dnd';

import { DashboardComponent } from './dashboard/dashboard.component';
import { EditDashboardComponent } from './editDashboard/editDashboard.component';
import { ChartDashboardComponent } from './charts/chart-dashboard/chart-dashboard.component';
import { ChartComponent } from './charts/chart/chart.component';

import { EditInstanceComponent } from './edit-instance/edit-instance.component';
import { EditChartComponent } from './charts/edit-chart/edit-chart.component';
import { InstanceActivityComponent } from './instance-activity/instance-activity.component';
import { ReportComponent } from './report/report.component';
import { ResourceTableComponent } from './charts/resource-table/resource-table.component';

@NgModule({
  imports: [
    CommonModule,
    InputTextModule,
    TabViewModule,
    PanelMenuModule,
    ButtonModule,
    DialogModule,
    FormsModule,
    ReactiveFormsModule,
    TabMenuModule,
    ConfirmDialogModule,
    ProgressSpinnerModule,
    ToastModule,
    MessageModule,

    NgxUIModule,
    NgxChartsModule,
    NgxSmoothDnDModule,
    DashboardRoutingModule,
    DropdownModule,
    CheckboxModule,
    TieredMenuModule,
    MultiSelectModule,
    SliderModule,
    SpinnerModule,
    TableModule,
    TooltipModule,
    CalendarModule,
    ScrollPanelModule,
    TooltipModule,
    TableModule,
    PaginatorModule,
    SliderModule
  ],
  declarations: [
    DashboardComponent,
    EditDashboardComponent,
    EditInstanceComponent,

    ChartComponent,
    ChartDashboardComponent,
    EditChartComponent,
    EditChartComponent,
    ReportComponent,
    InstanceActivityComponent,
    ResourceTableComponent
  ],
  exports: []
})
export class DashboardsModule {
}
