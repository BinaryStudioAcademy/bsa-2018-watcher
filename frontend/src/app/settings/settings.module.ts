import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SettingsComponent } from './settings.component';
import { NotificationSettingsComponent } from './notification-settings/notification-settings.component';
import { TabViewModule, PanelMenuModule, InputTextModule, ButtonModule, InputTextareaModule, ToggleButtonModule } from 'primeng/primeng';
import { InputSwitchModule, DropdownModule } from 'primeng/primeng';
import { ReactiveFormsModule } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { SettingsRoutingModule } from './settings-routing.module';
import { OrganizationProfileComponent } from './organization-profile/organization-profile.component';
import { ToastModule } from 'primeng/toast';
import { MessageService } from 'primeng/api';


@NgModule({
  imports: [
    CommonModule,
    TabViewModule,
    PanelMenuModule,
    FormsModule,
    InputTextModule,
    ButtonModule,
    InputSwitchModule,
    DropdownModule,
    ReactiveFormsModule,
    SettingsRoutingModule,
    ToggleButtonModule,
    ToastModule
  ],
  declarations: [ SettingsComponent, NotificationSettingsComponent, UserProfileComponent, OrganizationProfileComponent],
  providers: [ MessageService ]
})
export class SettingsModule { }
