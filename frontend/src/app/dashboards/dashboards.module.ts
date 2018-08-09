import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardComponent } from './dashboard/dashboard.component';
import { InstanceListComponent } from './instance-list/instance-list.component';
import { TabViewModule, PanelMenuModule, DialogModule, ButtonModule, TabMenuModule, CodeHighlighterModule } from 'primeng/primeng';
import { CreateEditDashboardComponent } from './create-edit-dashboard/create-edit-dashboard.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  imports: [
    CommonModule,
    TabViewModule,
    PanelMenuModule,
    ButtonModule,
    DialogModule,
    FormsModule,
    CommonModule,
    TabMenuModule,
    CodeHighlighterModule
  ],
  declarations: [DashboardComponent, InstanceListComponent, CreateEditDashboardComponent],
  exports: [ DashboardComponent, InstanceListComponent ]
})
export class DashboardsModule { }
