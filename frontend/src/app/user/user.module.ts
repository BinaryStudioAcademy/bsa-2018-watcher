import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { UserRoutingModule } from './user-routing.module';
import { UserComponent } from './user.component';
import { InputTextModule, ButtonModule, RadioButtonModule, InputTextareaModule } from 'primeng/primeng';
import { FeedbackComponent } from '../feedback/feedback.component';

@NgModule({
  imports: [
    CommonModule,
    UserRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    InputTextareaModule,
    ButtonModule,
    RadioButtonModule,
    InputTextModule
  ],
  declarations: [ UserComponent, FeedbackComponent ]
})
export class UserModule { }
