import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MenuModule} from 'primeng/menu';
import {SlideMenuModule} from 'primeng/slidemenu';

import { DashboardsRoutingModule } from './dashboards-routing.module';
import { DashboardsPageComponent } from './dashboards-page/dashboards-page.component';
import { DashboardHeaderComponent } from './dashboard-header/dashboard-header.component';
import { DashboardMenuComponent } from './dashboard-menu/dashboard-menu.component';
import { ButtonModule, TabViewModule, CodeHighlighterModule, TabMenuModule } from 'primeng/primeng';
import { DashboardTabsComponent } from './dashboard-tabs/dashboard-tabs.component';

@NgModule({
  imports: [
    CommonModule,
    DashboardsRoutingModule,
    MenuModule,
    SlideMenuModule,
    ButtonModule,
    TabViewModule,
    CodeHighlighterModule,
    TabMenuModule,
    SlideMenuModule
  ],
  declarations: [DashboardsPageComponent, DashboardHeaderComponent, DashboardMenuComponent, DashboardTabsComponent]
})
export class DashboardsModule { }
