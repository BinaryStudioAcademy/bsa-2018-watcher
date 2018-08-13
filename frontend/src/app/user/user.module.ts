import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { UserRoutingModule } from './user-routing.module';
import { UserComponent } from './user.component';
import { DashboardsModule } from '../dashboards/dashboards.module';
import {FeedbackComponent} from '../feedback/feedback.component';

@NgModule({
  imports: [
    CommonModule,
    UserRoutingModule,
    DashboardsModule,
    FormsModule,
    ReactiveFormsModule
  ],
  declarations: [ UserComponent, FeedbackComponent ]
})
export class UserModule { }
