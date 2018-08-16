import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { AdminPageComponent } from './admin-page/admin-page.component';
import { FeedbackListComponent } from './feedback-list/feedback-list.component';
import { DialogModule } from 'primeng/dialog';
import { TabViewModule, InputTextModule, ButtonModule, ToggleButtonModule, InputTextareaModule } from 'primeng/primeng';

@NgModule({
  imports: [
    CommonModule,
    AdminRoutingModule,
    TabViewModule,
    InputTextModule,
    ButtonModule,
    ToggleButtonModule,
    InputTextareaModule,
    DialogModule
  ],
  declarations: [
    AdminPageComponent,
    FeedbackListComponent
  ]
})
export class AdminModule { }
