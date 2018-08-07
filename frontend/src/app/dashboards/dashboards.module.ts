import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardComponent } from './dashboard/dashboard.component';
import { InstanceListComponent } from './instance-list/instance-list.component';
import { TabViewModule, PanelMenuModule } from 'primeng/primeng';
import { CreateEditDashboardComponent } from './create-edit-dashboard/create-edit-dashboard.component';

@NgModule({
  imports: [
    CommonModule,
    TabViewModule,
    PanelMenuModule,
  ],
  declarations: [DashboardComponent, InstanceListComponent, CreateEditDashboardComponent],
  exports: [ DashboardComponent, InstanceListComponent ]
})
export class DashboardsModule { }
