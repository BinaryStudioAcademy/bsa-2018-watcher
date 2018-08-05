import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MainPageRoutingModule } from './main-page-routing.module';
import { MainPageComponent } from './main-page.component';
import { HeaderComponent } from './header/header.component';
import { MenuComponent } from './menu/menu.component';
import { WorkAreaComponent } from './work-area/work-area.component';
import { ToolbarModule, TieredMenuModule, ButtonModule, PanelMenuModule } from 'primeng/primeng';
import { DashboardsModule } from '../dashboards/dashboards.module';
import { DashboardComponent } from '../dashboards/dashboard/dashboard.component';

@NgModule({
  imports: [
    CommonModule,
    MainPageRoutingModule,
    ToolbarModule,
    TieredMenuModule,
    ButtonModule,
    PanelMenuModule,
    DashboardsModule
  ],
  declarations: [MainPageComponent, HeaderComponent, MenuComponent, WorkAreaComponent]
})
export class MainPageModule { }
