import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SettingsComponent } from './settings.component';
import { NotificationSettingsComponent } from './notification-settings/notification-settings.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [SettingsComponent, NotificationSettingsComponent]
})
export class SettingsModule { }
