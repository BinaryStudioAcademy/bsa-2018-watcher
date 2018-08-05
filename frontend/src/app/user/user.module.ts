import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './user-routing.module';
import { UserComponent } from './user.component';
import { DashboardsModule } from '../dashboards/dashboards.module';
import { HeaderComponent } from '../header/header.component';

@NgModule({
  imports: [
    CommonModule,
    UserRoutingModule,
    DashboardsModule
  ],
  declarations: [ UserComponent, HeaderComponent ]
})
export class UserModule { }
