import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardComponent } from './dashboard/dashboard.component';
import { InstanceListComponent } from './instance-list/instance-list.component';

@NgModule({
  imports: [
    CommonModule
    
  ],
  declarations: [DashboardComponent, InstanceListComponent],
  exports:[ DashboardComponent, InstanceListComponent ]
})
export class DashboardsModule { }
