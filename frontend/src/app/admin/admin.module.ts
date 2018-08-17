import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AdminRoutingModule } from './admin-routing.module';
import { AdminPageComponent } from './admin-page/admin-page.component';
import { OrganizationListComponent } from './organization-list/organization-list.component';
import { UserListComponent } from './user-list/user-list.component';
import { FeedbackListComponent } from './feedback-list/feedback-list.component';
import { DialogModule } from 'primeng/dialog';
import { TabViewModule, InputTextModule, ButtonModule, ToggleButtonModule, InputTextareaModule } from 'primeng/primeng';
import { TableModule } from 'primeng/table';

@NgModule({
  imports: [
    CommonModule,
    AdminRoutingModule,
    TabViewModule,
    InputTextModule,
    ButtonModule,
    ToggleButtonModule,
    InputTextareaModule,
    DialogModule,
    FormsModule,
    ReactiveFormsModule,
    TableModule
  ],
  declarations: [
    AdminPageComponent,
    FeedbackListComponent,
    UserListComponent,
    OrganizationListComponent
  ]
})
export class AdminModule { }
