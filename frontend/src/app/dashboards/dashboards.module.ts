import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { DashboardComponent } from './dashboard/dashboard.component';
import { TabViewModule, PanelMenuModule, DialogModule, ButtonModule, TabMenuModule, ProgressSpinnerModule } from 'primeng/primeng';
import { EditDashboardComponent } from './editDashboard/editDashboard.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ToastModule } from 'primeng/toast';
import { EditInstanceComponent } from './edit-instance/edit-instance.component';
import { DashboardRoutingModule } from './dashboards-routing.module';
import {MessageModule} from 'primeng/message';


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
    ToastModule,
    MessageModule,

    DashboardRoutingModule
  ],
  declarations: [DashboardComponent, EditDashboardComponent, EditInstanceComponent],
  exports: [ DashboardComponent ]
})
export class DashboardsModule { }
