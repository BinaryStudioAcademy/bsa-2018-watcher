import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './user-routing.module';
import { UserComponent } from './user.component';
import { HeaderComponent } from '../header/header.component';
import { ToolbarModule, TieredMenuModule, ButtonModule } from 'primeng/primeng';
import { DashboardsModule } from '../dashboards/dashboards.module';

@NgModule({
  imports: [
    CommonModule,
    ToolbarModule,
    TieredMenuModule,
    ButtonModule,
    DashboardsModule,
    UserRoutingModule
  ],
  declarations: [ UserComponent, HeaderComponent ]
})
export class UserModule { }
