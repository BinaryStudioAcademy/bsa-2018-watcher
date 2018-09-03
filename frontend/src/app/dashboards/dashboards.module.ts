import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { DashboardComponent } from './dashboard/dashboard.component';
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
  InputTextModule,
  ConfirmationService} from 'primeng/primeng';
import { EditDashboardComponent} from './editDashboard/editDashboard.component';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { ToastModule} from 'primeng/toast';
import { LineChartComponent} from './01_line_chart/line-chart.component';
import { DashboardRoutingModule} from './dashboards-routing.module';
import { MessageModule} from 'primeng/message';
import { MultiSeriesComponent} from './02_multi_series_line_chart/multi-series.component';
import { BarChartComponent} from './03_bar_chart/bar-chart.component';
import { StackedBarChartComponent} from './04_stacked_bar_chart/stacked-bar-chart.component';
import { BrushZoomComponent} from './05_brush_zoom/brush-zoom.component';
import { PieChartComponent} from './06_pie_chart/pie-chart.component';
import { DonutChartComponent} from './07_donut_chart/donut-chart.component';
import { MarketChartComponent} from './08_market_chart/market-chart.component';
import { NgxChartsModule} from '@swimlane/ngx-charts';
import {PercentageBarChartComponent } from './10_percentage-bar-chart/percentage-bar-chart.component';
import {PercentageLineChartComponent } from './11_percentage-line-chart/percentage-line-chart.component';
import { NgxUIModule} from '@swimlane/ngx-ui';
import { ChartDashboardComponent} from './charts/chart-dashboard/chart-dashboard.component';
import { ChartBuilderComponent} from './charts/chart-builder/chart-builder.component';
import { ChartComponent} from './charts/chart/chart.component';

import { EditInstanceComponent } from './edit-instance/edit-instance.component';
import { ToastrService } from '../core/services/toastr.service';
import { DashboardService } from '../core/services/dashboard.service';
import { InstanceService } from '../core/services/instance.service';

import { EditChartComponent } from './charts/edit-chart/edit-chart.component';
import { ContainerComponent, DraggableComponent } from 'ngx-smooth-dnd';

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
    // NgxDnDModule,

    DashboardRoutingModule,
    DropdownModule,
    CheckboxModule,
    TieredMenuModule,
    MultiSelectModule,
    SliderModule,
    SpinnerModule
  ],
  declarations: [
    DashboardComponent,
    EditDashboardComponent,
    EditInstanceComponent,
    LineChartComponent,
    MultiSeriesComponent,
    BarChartComponent,
    StackedBarChartComponent,
    BrushZoomComponent,
    PieChartComponent,
    DonutChartComponent,
    MarketChartComponent,
    PercentageBarChartComponent,
    PercentageLineChartComponent,

    ChartComponent,
    ChartBuilderComponent,
    ChartDashboardComponent,
    ContainerComponent,
    DraggableComponent,
    EditChartComponent
  ],
  providers: [ToastrService, DashboardService],
  exports: []
})
export class DashboardsModule {
}
