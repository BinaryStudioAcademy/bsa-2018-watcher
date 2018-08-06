import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './user-routing.module';
import { UserComponent } from './user.component';
import { DashboardsModule } from '../dashboards/dashboards.module';
import { HeaderComponent } from '../header/header.component';
import { ToolbarModule, TieredMenuModule, ButtonModule } from 'primeng/primeng';

@NgModule({
  imports: [
    CommonModule,
    UserRoutingModule,
    DashboardsModule,
    ToolbarModule,
    TieredMenuModule,
    ButtonModule
  ],
  declarations: [ UserComponent, HeaderComponent ]
})
export class UserModule { }
