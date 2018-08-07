import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SettingsComponent } from './settings.component';
import { NotificationSettingsComponent } from './notification-settings/notification-settings.component';
import { RouterModule } from '@angular/router';
import { TabViewModule, PanelMenuModule, InputTextModule, ButtonModule, InputTextareaModule, ToggleButtonModule } from 'primeng/primeng';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    TabViewModule,
    PanelMenuModule,
    FormsModule,
    InputTextModule,
    ButtonModule,
    ReactiveFormsModule,
    InputTextareaModule,
    ToggleButtonModule
  ],
  declarations: [SettingsComponent, NotificationSettingsComponent, UserProfileComponent]
})
export class SettingsModule { }
