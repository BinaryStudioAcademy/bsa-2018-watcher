import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './user-routing.module';
import { UserComponent } from './user.component';
import { DashboardsModule } from '../dashboards/dashboards.module';

@NgModule({
  imports: [
    CommonModule,
    UserRoutingModule,
    DashboardsModule
  ],
  declarations: [ UserComponent ]
})
export class UserModule { }
