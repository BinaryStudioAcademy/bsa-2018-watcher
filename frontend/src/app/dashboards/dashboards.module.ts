import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {ConfirmDialogModule} from 'primeng/confirmdialog';
import { DashboardComponent } from './dashboard/dashboard.component';
import { InstanceListComponent } from './instance-list/instance-list.component';
import { TabViewModule, PanelMenuModule, DialogModule, ButtonModule, TabMenuModule, CodeHighlighterModule } from 'primeng/primeng';
import { EditDashboardComponent } from './editDashboard/editDashboard.component';
import { FormsModule } from '@angular/forms';

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
    CodeHighlighterModule,
    ConfirmDialogModule
  ],
  declarations: [DashboardComponent, InstanceListComponent, EditDashboardComponent],
  exports: [ DashboardComponent, InstanceListComponent ]
})
export class DashboardsModule { }
