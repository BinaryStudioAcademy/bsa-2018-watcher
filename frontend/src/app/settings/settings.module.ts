import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SettingsComponent } from './settings.component';
import { NotificationSettingsComponent } from './notification-settings/notification-settings.component';
import { TabViewModule, PanelMenuModule } from 'primeng/primeng';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { SettingsRoutingModule } from './settings-routing.module';


@NgModule({
  imports: [
    CommonModule,
    TabViewModule,
    SettingsRoutingModule,
    PanelMenuModule
  ],
  declarations: [ SettingsComponent, NotificationSettingsComponent, UserProfileComponent]
})
export class SettingsModule { }
