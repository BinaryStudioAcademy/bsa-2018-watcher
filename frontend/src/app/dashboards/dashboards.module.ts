import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MenuModule} from 'primeng/menu';

import { DashboardsRoutingModule } from './dashboards-routing.module';
import { DashboardsPageComponent } from './dashboards-page/dashboards-page.component';
import { DashboardHeaderComponent } from './dashboard-header/dashboard-header.component';
import { DashboardMenuComponent } from './dashboard-menu/dashboard-menu.component';
import { ButtonModule, TabViewModule, CodeHighlighterModule, TabMenuModule, PanelMenuModule } from 'primeng/primeng';
import { DashboardTabsComponent } from './dashboard-tabs/dashboard-tabs.component';

@NgModule({
  imports: [
    CommonModule,
    DashboardsRoutingModule,
    MenuModule,
    ButtonModule,
    TabViewModule,
    CodeHighlighterModule,
    TabMenuModule,
    PanelMenuModule
  ],
  declarations: [DashboardsPageComponent, DashboardHeaderComponent, DashboardMenuComponent, DashboardTabsComponent]
})
export class DashboardsModule { }
