import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SettingsComponent } from './settings.component';
import { NotificationSettingsComponent } from './notification-settings/notification-settings.component';
import { OrganizationProfileComponent } from './organization-profile/organization-profile.component';

import { TabViewModule, PanelMenuModule, InputTextModule, ButtonModule, ToggleButtonModule, InputTextareaModule } from 'primeng/primeng';
import { InputSwitchModule, DropdownModule } from 'primeng/primeng';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { SettingsRoutingModule } from './settings-routing.module';

@NgModule({
  imports: [
    CommonModule,
    TabViewModule,
    PanelMenuModule,
    FormsModule,
    InputTextModule,
    InputTextareaModule,
    ButtonModule,
    InputSwitchModule,
    DropdownModule,
    ReactiveFormsModule,
    SettingsRoutingModule,
    ToggleButtonModule
  ],
  declarations: [
    SettingsComponent,
    NotificationSettingsComponent,
    UserProfileComponent,
    OrganizationProfileComponent
  ]
})
export class SettingsModule { }
