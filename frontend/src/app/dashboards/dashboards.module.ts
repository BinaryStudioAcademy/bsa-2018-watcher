import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardsRoutingModule } from './dashboards-routing.module';
import { DashboardsPageComponent } from './dashboards-page/dashboards-page.component';
import { DashboardHeaderComponent } from './dashboard-header/dashboard-header.component';

@NgModule({
  imports: [
    CommonModule,
    DashboardsRoutingModule
  ],
  declarations: [DashboardsPageComponent, DashboardHeaderComponent]
})
export class DashboardsModule { }
