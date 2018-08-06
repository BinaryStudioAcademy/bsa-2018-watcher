import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SettingsComponent } from './settings.component';
import { NotificationSettingsComponent } from './notification-settings/notification-settings.component';
import { RouterModule } from '../../../node_modules/@angular/router';
import { TabViewModule, PanelMenuModule } from 'primeng/primeng';
import { UserProfileComponent } from './user-profile/user-profile.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    TabViewModule,
    PanelMenuModule
  ],
  declarations: [SettingsComponent, NotificationSettingsComponent, UserProfileComponent]
})
export class SettingsModule { }
