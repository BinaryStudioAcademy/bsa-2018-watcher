import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {ConfirmDialogModule} from 'primeng/confirmdialog';
import { DashboardComponent } from './dashboard/dashboard.component';
import { InstanceListComponent } from './instance-list/instance-list.component';
import { TabViewModule, PanelMenuModule, DialogModule, ButtonModule, TabMenuModule, ProgressSpinnerModule } from 'primeng/primeng';
import { EditDashboardComponent } from './editDashboard/editDashboard.component';
import { FormsModule } from '@angular/forms';
import { ToastModule } from '../../../node_modules/primeng/toast';

@NgModule({
  imports: [
    CommonModule,
    TabViewModule,
    PanelMenuModule,
    ButtonModule,
    DialogModule,
    FormsModule,
    CommonModule,
    TabMenuModule,
    ConfirmDialogModule,
    ProgressSpinnerModule,
    ToastModule
  ],
  declarations: [DashboardComponent, InstanceListComponent, EditDashboardComponent],
  exports: [ DashboardComponent, InstanceListComponent ]
})
export class DashboardsModule { }
