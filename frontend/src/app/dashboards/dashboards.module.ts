import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardComponent } from './dashboard/dashboard.component';
import { TabViewModule } from 'primeng/primeng';

@NgModule({
  imports: [
    CommonModule,
    TabViewModule
  ],
  declarations: [ DashboardComponent ],
  exports:[DashboardComponent]
})
export class DashboardsModule { }
