import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './user-routing.module';
import { UserComponent } from './user.component';
import { HeaderComponent } from '../header/header.component';
import {
  ToolbarModule,
  TieredMenuModule,
  ButtonModule,
  MessagesModule,
  MessageModule,
  GrowlModule
} from 'primeng/primeng';
import { DashboardsModule } from '../dashboards/dashboards.module';

@NgModule({
  imports: [
    CommonModule,
    ToolbarModule,
    TieredMenuModule,
    ButtonModule,
    GrowlModule,
    MessagesModule,
    MessageModule,
    DashboardsModule,
    UserRoutingModule
  ],
  declarations: [ UserComponent, HeaderComponent ]
})
export class UserModule { }
