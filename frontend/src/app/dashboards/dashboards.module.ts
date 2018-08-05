import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardComponent } from './dashboard/dashboard.component';
import { InstanceListComponent } from './instance-list/instance-list.component';
import { TabViewModule } from 'primeng/primeng';

@NgModule({
  imports: [
    CommonModule,
    TabViewModule  
  ],
  declarations: [DashboardComponent, InstanceListComponent],
  exports:[ DashboardComponent, InstanceListComponent ]
})
export class DashboardsModule { }
